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
        public Form_manageHotel()
        {
            InitializeComponent();
        }
        private void Form_manageHotel_Load(object sender, EventArgs e)
        {
            db = new HotelManagerEntities();
            lstClient = db.Clients.ToList();
            source = new BindingSource();
            source.DataSource = lstClient;
            dataGridView1_showTenants.DataSource = source;
        }
        private void button1_addTenantsWizard_Click(object sender, EventArgs e)
        {
            var f2 = new Form2();
            f2.Show();
            AddTenantByDataset("000000000","t", "nguyen", "nha heo", "0121222", "", "",1);
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
        private bool AddTenantByObject(Client obj)
        {
            if (obj != null && db.Clients.AsEnumerable().Where(x => x.PersonID == obj.PersonID).Count() == 0)
            {
                db.Clients.Add(obj);
                db.SaveChanges();
                return true;
            }
            return false;
        }
        private bool AddTenantByDataset(string personId, string lastName, string firstName, string address, string phone, string pictureHouseholdReg, string pictureIDCard, int roomId)
        {
            Client c = new Client();
            c.PersonID = personId;
            c.LastName=lastName;
            c.FirstName = firstName;
            c.Address = address;
            c.Phone = phone;
            c.PictureOfHouseholdRegistry = pictureHouseholdReg;
            c.PictureOfIDCard = pictureIDCard;
            c.RoomID = roomId;
            return AddTenantByObject(c);
        }

        private void button4_addContracts_Click(object sender, EventArgs e)
        {

        }
       


       
    }
}
