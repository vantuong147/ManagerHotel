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
        HotelManagerEntities db;
        List<Client> lstClient;
        BindingSource source;
        DataHandle dataHandle;
        public Form_manageHotel()
        {
            InitializeComponent();
            dataHandle = new DataHandle();
            source = new BindingSource();
        }
        private void Form_manageHotel_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotelManagerDataSet1.Clients' table. You can move, or remove it, as needed.
            this.clientsTableAdapter.Fill(this.hotelManagerDataSet1.Clients);
        }
        private void button1_addTenantsWizard_Click(object sender, EventArgs e)
        {
            var f2 = new Form_addTenant();
            f2.FormClosed += Form_addTenant_FormClosed;
            f2.Show();
        }
        private void Form_addTenant_FormClosed(object sender, FormClosedEventArgs e)
        {
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
        /*-------------------------------------Other function------------------------------------------------*/
        private void RefreshDataTable1()
        {
            this.clientsTableAdapter.Fill(this.hotelManagerDataSet1.Clients);
        }
       


       
    }
}
