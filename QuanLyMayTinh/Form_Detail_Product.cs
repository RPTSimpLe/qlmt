using BUS_Manegement;
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
    public partial class Form_Detail_Product : Form
    {
        private int proId;
        private  BUS_product bUS_Product = new BUS_product();
        public Form_Detail_Product(int proId)
        {
            InitializeComponent();
            this.proId = proId;
        }

        private void Form_Detail_Product_Load(object sender, EventArgs e)
        {
          DataTable dt =  bUS_Product.FindProductById(proId);
            ids.Text = dt.Rows[0]["ID"].ToString();
            years.Text = dt.Rows[0]["Năm sx"].ToString();
            nameProduct.Text = dt.Rows[0]["Tên sản phẩm"].ToString();
            warrantly.Text = dt.Rows[0]["Bảo hành"].ToString();
            descrption.Text = dt.Rows[0]["Mô tả"].ToString();
            category.Text = dt.Rows[0]["Loại"].ToString();
            producer.Text = dt.Rows[0]["Hãng"].ToString();
        //    ids.Text = dt.Rows.["ID"].ToString();
        }
    }
}
