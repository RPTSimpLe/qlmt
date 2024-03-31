using BUS_Manegement;
using Microsoft.Office.Interop.Excel;
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
    public partial class Form_Sell : Form
    {
        BUS_product bUS_Product = new BUS_product();
        public Form_Sell()
        {
            InitializeComponent();
        }

        private void Form_Sell_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bUS_Product.getAllData();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

    }
}
