using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagerHotel
{
    public partial class FormManageClients : Form
    {
        public FormManageClients()
        {
            InitializeComponent();
        }


        private void button_searchClients_Click(object sender, EventArgs e)
        {
            Image img = Image.FromFile(@"d:\picture\29.jpg");
            Size s = new Size();
            s.Width = pictureBox_idCard.Width;
            s.Height = pictureBox_idCard.Height;
            pictureBox_idCard.Image = new Bitmap(img, s.Width,s.Height);
        }
    }
}
