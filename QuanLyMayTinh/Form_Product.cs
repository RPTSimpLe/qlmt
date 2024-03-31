using BUS_Manegement;
using DTO_Manegement;
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
using static System.Windows.Forms.AxHost;

namespace QuanLyMayTinh
{
    public partial class Form_Product : Form
    {
        public static BUS_product product = new BUS_product();
        public static BUS_Producer bus_producer = new BUS_Producer();
        public static BUS_Category bus_category = new BUS_Category();

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

            this.resetCbo();
        }
        public void resetCbo()
        {
            cbo_category.Items.Clear();
            System.Data.DataTable dtCate = bus_category.getAllData();
            foreach (DataRow dr in dtCate.Rows)
            {
                cbo_category.Items.Add(dr["Tên danh mục"]);
            }

            cbo_Producer.Items.Clear();
            System.Data.DataTable dtProducer = bus_producer.getAllData();
            foreach (DataRow dr in dtProducer.Rows)
            {
                cbo_Producer.Items.Add(dr["Tên NSX"]);
            }
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

        private void searchProduct_Click(object sender, EventArgs e)
        {
            String categoryva = "";
            if (cbo_category.SelectedIndex != -1)
            {
                categoryva = cbo_category.SelectedItem.ToString().Trim();
            }
            String producerva = "";
            if (cbo_Producer.SelectedIndex != -1)
            {
                producerva = cbo_Producer.SelectedItem.ToString().Trim();
            }
            String namePro = txt_findName.Text.Trim();

            dataGridView1.DataSource = product.FindProduct(namePro, categoryva, producerva);
        }

        private void addUser_Click(object sender, EventArgs e)
        {
            Form_AddProduct form_AddProduct = new Form_AddProduct();
            form_AddProduct.ShowDialog();
        }
    }
}
