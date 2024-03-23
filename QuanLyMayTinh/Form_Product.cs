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
    public partial class Form_Product : Form
    {
        public static BUS_product product = new BUS_product(); 
        public Form_Product()
        {
      
            InitializeComponent();
        }

        private void saveProduct_Click(object sender, EventArgs e)
        {

        }

        private void Form_Product_Load(object sender, EventArgs e)
        {
            this.getAll();
        }

        public void getAll()
        {
            dataGridView1.DataSource = product.getAllData();
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            Form_Detail_Product form_Detail = new Form_Detail_Product(Convert.ToInt32(ids.Text));
            form_Detail.ShowDialog();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dataGridView1.CurrentRow.Index;
            ids.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            namePro.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            quantity.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            category.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            producer.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
        }

        private void deleteUser_Click(object sender, EventArgs e)
        {
            product.deleteProduct(Convert.ToInt32(ids.Text));
            this.getAll();
            MessageBox.Show("Xóa thành công");
        }
    }
}
