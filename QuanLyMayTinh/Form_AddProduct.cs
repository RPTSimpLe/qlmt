using BUS_Manegement;
using DevExpress.DataProcessing.InMemoryDataProcessor;
using DTO_Manegement;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Security.Cryptography;
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
        public static BUS_Image bUS_Image = new BUS_Image();

        public Form_AddProduct()
        {
            InitializeComponent();
        }

        private void btnsAdd_Click(object sender, EventArgs e)
        {
            int year = Convert.ToInt32(years.Text.ToString());
            String namePro = nameProduct.Text.ToString();
            String warranty = warrantly.Text.ToString();
            String des = descrption.Text.ToString();
            String nameCate = cbo_category.SelectedItem.ToString().Trim();
            String nameProducer = cbo_Producer.SelectedItem.ToString().Trim();
            string path = image.Text;
            string outputPath = @"D:\code\c#\qlmt\QuanLyMayTinh\Images\";

            File.Copy(path, Path.Combine( outputPath, Path.GetFileName(image.Text)),true);

            DTO_product dTO_Product = new DTO_product(0, namePro, year, des, warranty, nameCate, nameProducer);
            product.AddProduct(dTO_Product);
            long proId = product.GetProductId();

            DTO_Image dTO_Image = new DTO_Image(proId, Path.Combine(outputPath, Path.GetFileName(image.Text)));
            bUS_Image.add(dTO_Image);

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

        private void btnImagesProduct_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = ofd.Filter = "Image Files (*.jpg;*.jpeg;*.png) | *.jpg;*.jpeg;*.png";
            ofd.FilterIndex = 1;
            ofd.RestoreDirectory = true;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                picture.Image = new Bitmap(ofd.FileName);
                image.Text = ofd.FileName;
            }
        }
    }
}
