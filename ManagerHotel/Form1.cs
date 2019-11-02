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
        BindingSource sourceClient;
        DataHandle dataHandle;

        List<Vehicle> lstVehicle;
        BindingSource sourceVehicle;


        int rowIndexTenantNow;
        int loaded;
        public Form_manageHotel()
        {
            InitializeComponent();
            dataHandle = new DataHandle();
            sourceClient = new BindingSource();
            sourceVehicle = new BindingSource();
            rowIndexTenantNow = 0;
            loaded = 0;
        }
        /*---------------------------------------------------Form Function--------------------------------------------------*/
        private void Form_manageHotel_Load(object sender, EventArgs e)
        {
            lstClient = dataHandle.GetAllClients();
            sourceClient.DataSource = lstClient;
            dataGridView1_showTenants.DataSource = sourceClient;

            lstVehicle = dataHandle.GetAllVehicles();
            sourceVehicle.DataSource = lstVehicle;
            dataGridView5_showVehicles.DataSource = sourceVehicle;
            comboBox5_personId.DataSource = lstClient;

            loaded = 1;
        }
        
        private void Form_addTenant_FormClosed(object sender, FormClosedEventArgs e)
        {
            RefreshDataTable1();
            RefreshComboBoxPersonId5();
        }
        /*--------------------------------------------------Tab tennant function------------------------------------------------*/
        
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        
        private void RefreshDataTable1()
        {
            lstClient = dataHandle.GetAllClients();
            sourceClient.DataSource = lstClient;
            dataGridView1_showTenants.DataSource = sourceClient;
        }

        private void dataGridView1_showTenants_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rowIndexTenantNow = e.RowIndex;
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
        private void button1_manageVehicles_Click(object sender, EventArgs e)
        {

        }
        /*---------------------------------------------------Tab vehicle function-------------------------------*/
        private void button5_removeVehicles_Click(object sender, EventArgs e)
        {
            var checkedRows = from DataGridViewRow r in dataGridView5_showVehicles.Rows
                              where Convert.ToBoolean(r.Cells[0].Value) == true
                              select r;
            List<string> lstVehicleChk = new List<string>();
            foreach (var row in checkedRows)
            {
                lstVehicleChk.Add(row.Cells["vehicleIDCol"].Value.ToString());
            }
            int i = 0;
            int n = lstVehicleChk.Count;
            if (n < 1)
            {
                return;
            }
            DialogResult dialogResult = MessageBox.Show("Are you sure to remove " + n + " Vehicles", "Confirm", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
            {
                return;
            }
            string VehicleId = "";
            for (i = 0; i < n; i++)
            {
                VehicleId = lstVehicleChk.ElementAt(i);
                if (!dataHandle.RemoveVehicleById(VehicleId))
                {
                    MessageBox.Show("Error when remove " + VehicleId + "!");
                }
            }
            RefreshDataTable5();
        }
        private void RefreshDataTable5()
        {
            lstVehicle = dataHandle.GetAllVehicles();
            sourceVehicle.DataSource = lstVehicle;
            dataGridView5_showVehicles.DataSource = sourceVehicle;
        }
        private void RefreshComboBoxPersonId5()
        {
            lstClient = dataHandle.GetAllClients();
            sourceClient.DataSource=lstClient;
            comboBox5_personId.DataSource=sourceClient;
        }

        private Vehicle GetInput2Vehicle()
        {
            Vehicle v = new Vehicle();
            v.VehicleID = textBox5_vehicleId.Text;
            v.Model = textBox5_vehicleModel.Text;
            v.Color = comboBox5_vehicleColor.Text;
            v.PersonID = comboBox5_personId.Text;
            return v;
        }
        private void button4_addContracts_Click(object sender, EventArgs e)
        {

        }

        private void button5_addVehicle_Click(object sender, EventArgs e)
        {
            Vehicle v = GetInput2Vehicle();
            string result = dataHandle.AddVehicleByObject(v);
            if (result == DataHandle.SUCESS)
            {
                MessageBox.Show("Add Success!");
                RefreshDataTable5();
            }
        }

        private void button5_clear_Click(object sender, EventArgs e)
        {
            textBox5_vehicleId.Text = ""; ;
            textBox5_vehicleModel.Text = "";
            comboBox5_vehicleColor.Text = "";
            comboBox5_personId.Text = "";
        }

        private void dataGridView5_showVehicles_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 || loaded == 0)
            {
                return;
            }
            string colName = dataGridView5_showVehicles.Columns[e.ColumnIndex].Name;
            string dataChange = dataGridView5_showVehicles.Rows[e.RowIndex].Cells[colName].Value.ToString();
            string vehicleId = dataGridView5_showVehicles.Rows[e.RowIndex].Cells["vehicleIDCol"].Value.ToString();
            Vehicle v = dataHandle.GetVehicle(vehicleId);
            switch (colName)
            {
                case "modelCol":
                    v.Model = dataChange;
                    break;
                case "colorCol":
                    v.Color = dataChange;
                    break;
                case "personIDCol_dataGrid5":
                    v.PersonID = dataChange;
                    break;
                default:
                    break;
            }
            dataHandle.EditVehicleById(v.VehicleID, v);
        }
        /*------------------------------------------------------------------------------------------------------*/
        
    }
}
