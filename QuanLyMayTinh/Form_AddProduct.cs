using BUS_Manegement;
using DTO_Manegement;
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
        public static BUS_product product = new BUS_product();
        public static BUS_Producer bus_producer = new BUS_Producer();
        public static BUS_Category bus_category = new BUS_Category();
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

        private void btnsAdd_Click(object sender, EventArgs e)
        {
            int year = Convert.ToInt32(years.Text.ToString());
            String namePro = nameProduct.Text.ToString();
            String warranty = warrantly.Text.ToString();
            String des = descrption.Text.ToString();
            String nameCate = cbo_category.SelectedItem.ToString().Trim();
            String nameProducer = cbo_Producer.SelectedItem.ToString().Trim();

            DTO_product dTO_Product = new DTO_product(0, namePro, year, des, warranty, nameCate, nameProducer);

            product.AddProduct(dTO_Product);

            MessageBox.Show("Thêm thành công");
            this.Close();
        }

        private void Form_AddProduct_Load(object sender, EventArgs e)
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
    }
}
