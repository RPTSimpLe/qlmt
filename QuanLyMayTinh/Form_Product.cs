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
    public partial class Form_Product : Form
    {
        public Form_Product()
        {
            LoadThemme();
            InitializeComponent();
        }

        private void saveProduct_Click(object sender, EventArgs e)
        {

        }

        private void Form_Product_Load(object sender, EventArgs e)
        {

        }
        private void LoadThemme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
            }
           
        }
    }
}
