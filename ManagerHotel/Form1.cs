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
using System.Security;

namespace ManagerHotel
{
    public partial class Form_manageHotel : Form
    {
        string imgGrey = "images/grey.jpg";

        List<Client> lstClient;
        BindingSource sourceClient;
        DataHandle dataHandle;

        List<Vehicle> lstVehicle;
        BindingSource sourceVehicle;


        int rowIndexTenantNow;
        int rowIndexVehicleNow;
        int loaded;
        string idClientNow;

        bool isSearchVehicle;
        bool isChangedByCellClickVehicle;
        public Form_manageHotel()
        {
            InitializeComponent();
            dataHandle = new DataHandle();
            sourceClient = new BindingSource();
            sourceVehicle = new BindingSource();
            rowIndexTenantNow = 0;
            rowIndexVehicleNow = 0;
            loaded = 0;
            isSearchVehicle = false;
            isChangedByCellClickVehicle = false;
        }
        /*---------------------------------------------------Form Function--------------------------------------------------*/
        private void Form_manageHotel_Load(object sender, EventArgs e)
        {
            RefreshDataTable1();
            RefreshDataTable5();

            lstVehicle = dataHandle.GetAllVehicles();
            sourceVehicle.DataSource = lstVehicle;
            dataGridView5_showVehicles.DataSource = sourceVehicle;
            comboBox5_personId.DataSource = lstClient;

            label5_vehicleAddPath.Visible = false;
            button5_addVehicle.Enabled = false;

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
            OpenFileDialog fd = new OpenFileDialog();
            if (fd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pictureBox2.Image = Image.FromFile(fd.FileName);
                    string preImage = dataGridView1_showTenants.Rows[rowIndexTenantNow].Cells["PictureOfHouseholdRegistry"].Value.ToString();
                    if (preImage == fd.FileName)
                    {
                        return;
                    }
                    DialogResult dialogResult = MessageBox.Show("Are you sure to change image?", "Confirm", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.No)
                    {
                        if (preImage == "na")
                        {
                            preImage = imgGrey;
                        }
                        pictureBox2.Image = Image.FromFile(preImage);
                        return;
                    }
                    else
                    {
                        dataHandle.EditPictureHousehold(idClientNow, fd.FileName);
                    }
                }
                catch (SecurityException ex)
                {
                    MessageBox.Show("Error");
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            if (fd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pictureBox1.Image = Image.FromFile(fd.FileName);
                    string preImage = dataGridView1_showTenants.Rows[rowIndexTenantNow].Cells["PictureOfIDCard"].Value.ToString();
                    if (preImage == fd.FileName)
                    {
                        return;
                    }
                    DialogResult dialogResult = MessageBox.Show("Are you sure to change image?", "Confirm", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.No)
                    {
                        if (preImage == "na")
                        {
                            preImage = imgGrey;
                        }
                        pictureBox1.Image = Image.FromFile(preImage);
                        return;
                    }
                    else
                    {
                        dataHandle.EditPictureIdCard(idClientNow, fd.FileName);
                    }
                }
                catch (SecurityException ex)
                {
                    MessageBox.Show("Error");
                }
            }
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
            idClientNow = dataGridView1_showTenants.Rows[rowIndexTenantNow].Cells["personIDCol"].Value.ToString();
            string img1 = dataGridView1_showTenants.Rows[rowIndexTenantNow].Cells["PictureOfIDCard"].Value.ToString();
            if (img1!="na")
            {
                pictureBox1.Image = Image.FromFile(img1);
            }
            else
            {
                pictureBox1.Image = Image.FromFile(imgGrey);
            }
            string img2 = dataGridView1_showTenants.Rows[rowIndexTenantNow].Cells["PictureOfHouseholdRegistry"].Value.ToString();
            if (img2 != "na")
            {
                pictureBox2.Image = Image.FromFile(img2);
            }
            else
            {
                pictureBox2.Image = Image.FromFile(imgGrey);
            }

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
            isSearchVehicle = true;
            tabControl.SelectedTab = tabPage_manageVehicle;
        }
        private void button1_search_Click(object sender, EventArgs e)
        {
            string key = textBox1_searchTenants.Text;
            lstClient = dataHandle.FindTenantsByKey(key);
            sourceClient.DataSource = lstClient;
            dataGridView1_showTenants.DataSource = sourceClient;
        }
        private void button1_showAll_Click(object sender, EventArgs e)
        {
            RefreshDataTable1();
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
        private void RefreshDataTable5ByData(List<Vehicle> lst)
        {
            sourceVehicle.DataSource = lst;
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
            v.Picture = label5_vehicleAddPath.Text;
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
                button5_addVehicle.Enabled = false;
            }
            if (result == DataHandle.ERR_DATA_EXISTED)
            {
                MessageBox.Show("This Vehicle ID has existed!");
            }
        }

        private void button5_clear_Click(object sender, EventArgs e)
        {
            isChangedByCellClickVehicle = true;
            textBox5_vehicleId.Text = "";
            textBox5_vehicleModel.Text = "";
            comboBox5_vehicleColor.Text = "";
            comboBox5_personId.Text = "";
            pictureBox8.Image = Image.FromFile(imgGrey);
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

        //Click to edit/add picture
        private void pictureBox8_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            if (fd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pictureBox8.Image = Image.FromFile(fd.FileName);
                    label5_vehicleAddPath.Text = fd.FileName;
                    if (button5_addVehicle.Enabled == true)
                    {
                        return;
                    }
                    string preImage = dataGridView5_showVehicles.Rows[rowIndexVehicleNow].Cells["Picture"].Value.ToString();
                    if (preImage == fd.FileName)
                    {
                        return;
                    }
                    DialogResult dialogResult = MessageBox.Show("Are you sure to change image?", "Confirm", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.No)
                    {
                        if (preImage == "na")
                        {
                            preImage = imgGrey;
                        }
                        pictureBox8.Image = Image.FromFile(preImage);
                        return;
                    }
                    else
                    {
                        dataHandle.EditVehiclePicture(dataGridView5_showVehicles.Rows[rowIndexVehicleNow].Cells["vehicleIDCol"].Value.ToString(), fd.FileName);
                    }
                }
                catch (SecurityException ex)
                {
                    MessageBox.Show("Error");
                }
            }
        }

        private void dataGridView5_showVehicles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            isChangedByCellClickVehicle = true;
            button5_addVehicle.Enabled = false;
            rowIndexVehicleNow = e.RowIndex;
            comboBox5_personId.Text = dataGridView5_showVehicles.Rows[rowIndexVehicleNow].Cells["personIDCol_dataGrid5"].Value.ToString();
            textBox5_vehicleId.Text = dataGridView5_showVehicles.Rows[rowIndexVehicleNow].Cells["vehicleIDCol"].Value.ToString();
            textBox5_vehicleModel.Text = dataGridView5_showVehicles.Rows[rowIndexVehicleNow].Cells["modelCol"].Value.ToString();
            comboBox5_vehicleColor.Text = dataGridView5_showVehicles.Rows[rowIndexVehicleNow].Cells["colorCol"].Value.ToString();
            
            string img = dataGridView5_showVehicles.Rows[rowIndexVehicleNow].Cells["Picture"].Value.ToString();
            if (img == "na")
            {
                img=imgGrey;
            }
            pictureBox8.Image = Image.FromFile(img);
        }

        private void textBox5_vehicleId_TextChanged(object sender, EventArgs e)
        {
            if (isChangedByCellClickVehicle)
            {
                isChangedByCellClickVehicle = false;
            }
            else
            {
                pictureBox8.Image = Image.FromFile(imgGrey);
                button5_addVehicle.Enabled = true;
                label5_vehicleAddPath.Text = "na";
            }
           
        }

        private void tabPage_manageVehicle_Enter(object sender, EventArgs e)
        {
            if (isSearchVehicle)
            {
                isSearchVehicle = false;
                lstVehicle = dataHandle.FindVehiclesByPersonId(idClientNow);
                RefreshDataTable5ByData(lstVehicle);
                comboBox5_personId.Text = idClientNow;
            }
            else
            {
                RefreshDataTable5();
            }
        }

        private void button5_showAll_Click(object sender, EventArgs e)
        {
            RefreshDataTable5();
        }

        private void button5_search_Click(object sender, EventArgs e)
        {
            string key = textBox5_search.Text;
            lstVehicle = dataHandle.FindVehiclesByKey(key);
            RefreshDataTable5ByData(lstVehicle);
        }

        private void button5_showVehicleOfPerson_Click(object sender, EventArgs e)
        {
            lstVehicle = dataHandle.FindVehiclesByPersonId(comboBox5_personId.Text);
            RefreshDataTable5ByData(lstVehicle);
        }

        /*------------------------------------------------------------------------------------------------------*/
        
    }
}
