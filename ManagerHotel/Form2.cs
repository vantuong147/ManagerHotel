using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Text.RegularExpressions;
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
            c.RoomID = Int32.Parse("0"+comboBoxW1_roomId.Text);
            c.Address = textBoxW1_address.Text;
            c.PictureOfHouseholdRegistry = labelW1_imgHouseholdRegPath.Text;
            c.PictureOfIDCard = labelW1_ImgIdCardPath.Text;
            return c;
        }
        private Contract getInput2Contract()
        {
            Contract c = new Contract();
            c.PersonID = textBoxW1_personId.Text;
            c.PaymentPerMonth = Str2Int(textBoxW2_paymentOneMonth.Text);
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
            BindingSource roomSource=new BindingSource();
            List<Room> lstRoom=dataHandle.GetAllRooms();
            roomSource.DataSource = lstRoom;
            comboBoxW1_roomId.DataSource = roomSource;
        }
        //Add data to database and close
        private void wizardControl1_Finished(object sender, EventArgs e)
        {
            Client c = getInput2Client();
            if (dateTimePickerW2_timeEnd.Enabled ==true)
            {
                Contract ct = getInput2Contract();
                if (dataHandle.AddTenantByObject(c)==DataHandle.SUCESS && dataHandle.AddContractByObj(ct))
                {
                    MessageBox.Show("Add Successly!");
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
            else
            {
                if (dataHandle.AddTenantByObject(c)==DataHandle.SUCESS)
                {
                    MessageBox.Show("Add Successly!");
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
           
            this.Close();
        }

        private void Form_addTenant_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
        //Check data tenants before go to next page contract
        private void wizardPage1_Commit(object sender, AeroWizard.WizardPageConfirmEventArgs e)
        {
            if (textBoxW1_personId.Text=="")
            {
                MessageBox.Show("Can not leave Person ID balnk!");
                e.Cancel = true;
            }
            if (dataHandle.isTenantExisted(textBoxW1_personId.Text))
            {
                MessageBox.Show("This tenant is existed in database!");
                e.Cancel = true;
            }
            int rid=Int32.Parse("0"+Str2Int(comboBoxW1_roomId.Text));
            if (!dataHandle.IsRoomExist(rid))
            {
                MessageBox.Show("This room is not exist!");
                e.Cancel = true;
            }
        }
        //Change to disable mode when skip button check
        private void checkBoxW2_skipContract_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxW2_skipContract.Checked)
            {
                dateTimePickerW2_timeEnd.Enabled = false;
                dateTimePickerW2_timeStart.Enabled = false;
                textBoxW2_paymentOneMonth.Enabled = false;
            }
            else
            {
                dateTimePickerW2_timeEnd.Enabled = true;
                dateTimePickerW2_timeStart.Enabled = true;
                textBoxW2_paymentOneMonth.Enabled = true;
            }
        }
        private string TransError2Text(string err)
        {
            string str="";
            if (err == "objIdNull")
            {
                str = "Data ID is null";
            }
            if (err=="objNull")
            {
                str = "Data is null";
            }
            if (err=="objExisted")
            {
                str = "Data is existed";
            }
            return str;
        }
        private int Str2Int(string s)
        {
            s = "0" + s;
            if (Regex.Matches(s,@"[0123456789]").Count!=s.Length)
            {
                return 0;
            }
            return Int32.Parse(s);
        }
    }
}
