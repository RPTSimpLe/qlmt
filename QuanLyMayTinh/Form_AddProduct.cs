using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyMayTinh
{
    public partial class Form_AddProduct : Form
    {
        public Form_AddProduct()
        {
            InitializeComponent();
        }

        private void btnImagesProduct_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = ofd.Filter = "JPG files (*.jpg) | *.jpg|All files (*.*)|*.*";
            ofd.FilterIndex = 1;
            ofd.RestoreDirectory = true;
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                picture.ImageLocation = ofd.FileName;
                image.Text = ofd.FileName;
            }
        }
    }
}
