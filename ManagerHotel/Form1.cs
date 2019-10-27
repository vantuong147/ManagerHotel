using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AeroWizard;

namespace ManagerHotel
{
    public partial class Form_manageHotel : Form
    {
        List<Client> lstClient;
        BindingSource source;
        DataHandle dataHandle;
        int rowIndexNow;
        int loaded;
        public Form_manageHotel()
        {
            InitializeComponent();
            dataHandle = new DataHandle();
            source = new BindingSource();
            rowIndexNow = 0;
            loaded = 0;
        }
        /*---------------------------------------------------Form Function--------------------------------------------------*/
        private void Form_manageHotel_Load(object sender, EventArgs e)
        {
            lstClient = dataHandle.GetAllClients();
            source.DataSource = lstClient;
            dataGridView1_showTenants.DataSource = source;
            loaded = 1;
        }
        private void Form_addTenant_FormClosed(object sender, FormClosedEventArgs e)
        {
            RefreshDataTable1();
        }
        /*--------------------------------------------------Click Function------------------------------------------------*/
        //Add new Tenant(Show AddTenant Wizard)
        private void button1_addTenantsWizard_Click(object sender, EventArgs e)
        {
            var f2 = new Form_addTenant();
            f2.FormClosed += Form_addTenant_FormClosed;
            f2.Show();
        }
        //Delete selected Tenants and their Contracts
        private void button1_removeTenants_Click(object sender, EventArgs e)
        {
            var checkedRows = from DataGridViewRow r in dataGridView1_showTenants.Rows
                              where Convert.ToBoolean(r.Cells[0].Value) == true
                              select r;
            List<string> lstTenantsChk = new List<string>();
            foreach (var row in checkedRows)
            {
                lstTenantsChk.Add(row.Cells["personIDCol"].Value.ToString());
            }
            int i = 0;
            int n = lstTenantsChk.Count;
            if (n<1)
            {
                return;
            }
            DialogResult dialogResult = MessageBox.Show("Are you sure to remove " + n + " Tenants and their Contracts(The Contracts will be saved to HistoryContracts)", "Confirm", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
            {
                return;
            }
            string tenantId = "";
            for (i = 0; i < n; i++)
            {
                tenantId = lstTenantsChk.ElementAt(i);
                if (!dataHandle.RemoveTenantById(tenantId))
                {
                    MessageBox.Show("Error when remove " + tenantId + "!");
                }
            }
            RefreshDataTable1();
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
        private void button4_addContracts_Click(object sender, EventArgs e)
        {

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        /*---------------------------------------------------Other function------------------------------------------------*/
        private void RefreshDataTable1()
        {
            lstClient = dataHandle.GetAllClients();
            source.DataSource = lstClient;
            dataGridView1_showTenants.DataSource = source;
        }

        private void dataGridView1_showTenants_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rowIndexNow = e.RowIndex;
        }
        private void dataGridView1_showTenants_CellValueChanged_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex==0 || loaded==0)
            {
                return;
            }
            string colName = dataGridView1_showTenants.Columns[e.ColumnIndex].Name;
            string dataChange = dataGridView1_showTenants.Rows[e.RowIndex].Cells[colName].Value.ToString();
            string personId = dataGridView1_showTenants.Rows[e.RowIndex].Cells["personIDCol"].Value.ToString();
            Client c = dataHandle.GetTenantById(personId);
            switch (colName)
            {
                case "lNameCol":
                    c.LastName = dataChange;
                    break;
                case "fNameCol":
                    c.FirstName = dataChange;
                    break;
                case "addressCol":
                    c.Address = dataChange;
                    break;
                case "phoneCol":
                    c.Phone = dataChange;
                    break;
                default:
                    break;
            }
            dataHandle.EditTenantById(personId, c);
        }
    }
}
