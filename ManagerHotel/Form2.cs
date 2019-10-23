using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagerHotel
{
    public partial class Form_addTenant : Form
    {
        DataHandle dataHandle;
        public Form_addTenant()
        {
            InitializeComponent();
            dataHandle = new DataHandle();
            labelW1_ImgIdCardPath.Visible = false;
            labelW1_imgHouseholdRegPath.Visible = false;
            labelW2_contractImagePath.Visible = false;
        }

        private void pictureBoxW2_pictureContract_Click(object sender, EventArgs e)
        {

        }
        /*---------------------------------------Get input functions---------------------------------*/
        private Client getInput2Client()
        {
            Client c = new Client();
            c.LastName = textBoxW1_lastName.Text;
            c.FirstName = textBoxW1_firstName.Text;
            c.PersonID = textBoxW1_personId.Text;
            c.Phone = textBoxW1_phone.Text;
            c.RoomID = Int32.Parse(comboBoxW1_roomId.Text);
            c.Address = textBoxW1_address.Text;
            c.PictureOfHouseholdRegistry = labelW1_imgHouseholdRegPath.Text;
            c.PictureOfIDCard = labelW1_ImgIdCardPath.Text;
            return c;
        }
        private Contract getInput2Contract()
        {
            Contract c = new Contract();
            c.PersonID = textBoxW1_personId.Text;
            c.PaymentPerMonth = Int32.Parse(textBoxW2_paymentOneMonth.Text);
            c.PictureOfContract = labelW2_contractImagePath.Text;
            c.TimeStartRent = dateTimePickerW2_timeStart.Value;
            c.TimeEndRent = dateTimePickerW2_timeEnd.Value;
            return c;
        }
        /*------------------------------------------------------------------------------------------*/

        private void pictureBoxW1_idCard_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            if (fd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    labelW1_ImgIdCardPath.Text = fd.FileName;
                }
                catch (SecurityException ex)
                {
                    MessageBox.Show("Error");
                }
            }
        }
        /*-------------------------------------------Form function-----------------------------------------*/
        private void Form_addTenant_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotelManagerDataSet.Rooms' table. You can move, or remove it, as needed.
            this.roomsTableAdapter.Fill(this.hotelManagerDataSet.Rooms);
        }

        private void wizardControl1_Finished(object sender, EventArgs e)
        {
            Client c = getInput2Client();
            Contract ct = getInput2Contract();
            if (dataHandle.AddTenantByObject(c) && dataHandle.AddContractByObj(ct))
            {
                MessageBox.Show("Add Successly!");
            }
            else
            {
                MessageBox.Show("Error");
            }
            this.Close();
        }

        private void Form_addTenant_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
        //Check data tenants before next page contract
        private void wizardPage1_Commit(object sender, AeroWizard.WizardPageConfirmEventArgs e)
        {
            if (textBoxW1_personId.Text=="")
            {
                MessageBox.Show("Can not leave Person ID balnk!");
                e.Cancel = true;
            }
        }
    }
}
