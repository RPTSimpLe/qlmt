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

namespace QuanLyMayTinh
{
    public partial class Form_Sell : Form
    {
        BUS_product bUS_Product = new BUS_product();
        BUS_optionProduct bUS_OptionProduct = new BUS_optionProduct();
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
            int i = dataGridView1.CurrentRow.Index;


            for (int j = 1; j <= 4; j++) {

                System.Windows.Forms.GroupBox groupBox = groupBox5.Controls.Find("product" + j, true).FirstOrDefault() as System.Windows.Forms.GroupBox;
                ComboBox cbo = groupBox5.Controls.Find("cbo" + j, true).FirstOrDefault() as ComboBox;
                System.Windows.Forms.Button button = groupBox5.Controls.Find("btnXoa" + j, true).FirstOrDefault() as System.Windows.Forms.Button ;
                //System.Windows.Forms.TextBox textBoxQuantity = groupBox5.Controls.Find("quantity" + j, true).FirstOrDefault() as System.Windows.Forms.TextBox;
                //System.Windows.Forms.TextBox textBoxSellingPrice = groupBox5.Controls.Find("sellingPrice" + j, true).FirstOrDefault() as System.Windows.Forms.TextBox;
                System.Windows.Forms.TextBox textBoxProId = groupBox5.Controls.Find("idPro" + j, true).FirstOrDefault() as System.Windows.Forms.TextBox;

                if(groupBox.Visible == false)
                {
                    int product_id = Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value.ToString());

                    System.Data.DataTable dt = bUS_OptionProduct.getAllData(product_id);
                    for (int a = 0; a < dt.Rows.Count; a++)
                    {
                        String value = "Ram: " + dt.Rows[a]["ram"].ToString() + ", Ổ cứng:  " + dt.Rows[a]["storage"].ToString() + ", Tồn kho: " + dt.Rows[a]["quantity"].ToString() + ", Giá: " + dt.Rows[a]["sellingPrice"].ToString();
                        cbo.Items.Add(value);
                    }
                    cbo.Tag = j;
                    button.Tag = j;

                    textBoxProId.Text = product_id.ToString();
                    groupBox.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
                    groupBox.Visible = true;
                    return;
                }
            }
        }

        private void cbo1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cbo = sender as ComboBox;
            int j = (int)cbo.Tag;
            //System.Windows.Forms.GroupBox groupBox = groupBox5.Controls.Find("product" + i, true).FirstOrDefault() as System.Windows.Forms.GroupBox;
            //groupBox.Visible = false;

           // System.Windows.Forms.TextBox textBoxQuantity = groupBox5.Controls.Find("quantity" + j, true).FirstOrDefault() as System.Windows.Forms.TextBox;
            System.Windows.Forms.TextBox textBoxSellingPrice = groupBox5.Controls.Find("price" + j, true).FirstOrDefault() as System.Windows.Forms.TextBox;

            String value = cbo.SelectedItem.ToString().Trim();
            string[] parts = value.Split(new string[] { ", ", ": " }, StringSplitOptions.RemoveEmptyEntries);

           // string ram = parts[1];
            //string storage = parts[3];
            //int quantity = Convert.ToInt32(parts[5]);
            textBoxSellingPrice.Text = parts[7];

           // if(sellingPrice  != textBoxSellingPrice.Text)
           // {
                
           // }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Button button = sender as System.Windows.Forms.Button;
            int j = (int)button.Tag;

            System.Windows.Forms.GroupBox groupBox = groupBox5.Controls.Find("product" + j, true).FirstOrDefault() as System.Windows.Forms.GroupBox;
            groupBox.Visible = false;
        }

        private void deleteProduct_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 4; i++)
            {
                System.Windows.Forms.GroupBox groupBox = groupBox5.Controls.Find("product" + i, true).FirstOrDefault() as System.Windows.Forms.GroupBox;
                groupBox.Visible=false;
            }
        }
    }
}
