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
        DTO_bill dTO_Bill;
        List<long> lstotalPrice = new List<long>();
        public Form_Sell()
        {
            InitializeComponent();
            for(int i = 0; i < 4; i++) {
                this.lstotalPrice.Add(0);
            }
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
                System.Windows.Forms.TextBox textBoxQuantity = groupBox5.Controls.Find("quantity" + j, true).FirstOrDefault() as System.Windows.Forms.TextBox;
                System.Windows.Forms.TextBox textBoxPrice = groupBox5.Controls.Find("price" + j, true).FirstOrDefault() as System.Windows.Forms.TextBox;
                System.Windows.Forms.TextBox textBoxTotalPrice = groupBox5.Controls.Find("totalPrice" + j, true).FirstOrDefault() as System.Windows.Forms.TextBox;

                if (groupBox.Visible == false)
                {
                    cbo.Items.Clear();
                    int product_id = Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value.ToString());
                    System.Data.DataTable dt = bUS_OptionProduct.getAllData(product_id);
                    for (int a = 0; a < dt.Rows.Count; a++)
                    {
                        String value = "Ram: " + dt.Rows[a]["ram"].ToString() + ", Ổ cứng:  " + dt.Rows[a]["storage"].ToString() + ", Tồn kho: " + dt.Rows[a]["quantity"].ToString() + ", Giá: " + dt.Rows[a]["sellingPrice"].ToString();
                        cbo.Items.Add(value);
                    }
                    cbo.Tag = j;
                    button.Tag = j;
                    textBoxQuantity.Tag = j;
                    textBoxPrice.Tag = j;
                    textBoxTotalPrice.Tag = j;

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
            System.Windows.Forms.TextBox textBoxSellingPrice = groupBox5.Controls.Find("price" + j, true).FirstOrDefault() as System.Windows.Forms.TextBox;
            System.Windows.Forms.TextBox textBoxProId = groupBox5.Controls.Find("idCus" + j, true).FirstOrDefault() as System.Windows.Forms.TextBox;

            String value = cbo.SelectedItem.ToString().Trim();
            string[] parts = value.Split(new string[] { ", ", ": " }, StringSplitOptions.RemoveEmptyEntries);

            textBoxProId.Text = bUS_OptionProduct.findId(parts[1].Trim(), parts[3].Trim(), Convert.ToInt64(parts[7].Trim())).Rows[0]["id"].ToString();
            textBoxSellingPrice.Text = parts[7];
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Button button = sender as System.Windows.Forms.Button;
            int j = (int)button.Tag;

            System.Windows.Forms.GroupBox groupBox = groupBox5.Controls.Find("product" + j, true).FirstOrDefault() as System.Windows.Forms.GroupBox;
            ComboBox cbo = groupBox5.Controls.Find("cbo" + j, true).FirstOrDefault() as ComboBox;
            System.Windows.Forms.TextBox textBoxProId = groupBox5.Controls.Find("idCus" + j, true).FirstOrDefault() as System.Windows.Forms.TextBox;
            System.Windows.Forms.TextBox textBoxSellingPrice = groupBox5.Controls.Find("price" + j, true).FirstOrDefault() as System.Windows.Forms.TextBox;
            System.Windows.Forms.TextBox textBoxQuantity = groupBox5.Controls.Find("quantity" + j, true).FirstOrDefault() as System.Windows.Forms.TextBox;
            System.Windows.Forms.TextBox TextBoxTotalPrice = groupBox5.Controls.Find("totalPrice" + j, true).FirstOrDefault() as System.Windows.Forms.TextBox;

            cbo.Items.Clear();
            textBoxProId.Text = "";
            textBoxSellingPrice.Text = "";
            textBoxQuantity.Text = "1";
            TextBoxTotalPrice.Text = "0";
            groupBox.Visible = false;
        }

        private void deleteProduct_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 4; i++)
            {
                System.Windows.Forms.GroupBox groupBox = groupBox5.Controls.Find("product" + i, true).FirstOrDefault() as System.Windows.Forms.GroupBox;
                ComboBox cbo = groupBox5.Controls.Find("cbo" + i, true).FirstOrDefault() as ComboBox;
                System.Windows.Forms.TextBox textBoxProId = groupBox5.Controls.Find("idCus" + i, true).FirstOrDefault() as System.Windows.Forms.TextBox;
                System.Windows.Forms.TextBox textBoxSellingPrice = groupBox5.Controls.Find("price" + i, true).FirstOrDefault() as System.Windows.Forms.TextBox;
                System.Windows.Forms.TextBox textBoxQuantity = groupBox5.Controls.Find("quantity" + i, true).FirstOrDefault() as System.Windows.Forms.TextBox;
                System.Windows.Forms.TextBox TextBoxTotalPrice = groupBox5.Controls.Find("totalPrice" + i, true).FirstOrDefault() as System.Windows.Forms.TextBox;

                if (groupBox.Visible)
                {
                    TextBoxTotalPrice.Text = "0";
                    cbo.Items.Clear();
                    textBoxProId.Text = "";
                    textBoxSellingPrice.Text = "";
                    textBoxQuantity.Text = "1";

                    this.lstotalPrice[(i - 1)] = 0;
                    groupBox.Visible = false;
                }
            }
        }

        private void listtotalprice(int i,string totalprice)
        {
            lstotalPrice[(i-1)] = Convert.ToInt64(totalprice);
        }

        private void payments_Click(object sender, EventArgs e)
        {
            List<DTO_bill> list = new List<DTO_bill>();
            for (int i = 1; i <= 4; i++)
            {
                System.Windows.Forms.TextBox textBoxProId = groupBox5.Controls.Find("idCus" + i, true).FirstOrDefault() as System.Windows.Forms.TextBox;
                System.Windows.Forms.TextBox textBoxSellingPrice = groupBox5.Controls.Find("price" + i, true).FirstOrDefault() as System.Windows.Forms.TextBox;
                System.Windows.Forms.TextBox textBoxQuantity = groupBox5.Controls.Find("quantity" + i, true).FirstOrDefault() as System.Windows.Forms.TextBox;

               if(textBoxProId.Text != "")
                {
                    DTO_bill bill = new DTO_bill(Convert.ToInt64(textBoxQuantity.Text.Trim()), Convert.ToInt64(textBoxSellingPrice.Text), Convert.ToInt32(textBoxProId.Text));
                    list.Add(bill);
                }
            }
            Form_Payment payment = new Form_Payment(list);
            payment.ShowDialog();
        }

        private void quantity_TextChanged(object sender, EventArgs e)
        {
            try
            {
                System.Windows.Forms.TextBox textBoxQuantity = sender as System.Windows.Forms.TextBox;
                int j = (int)textBoxQuantity.Tag;

                System.Windows.Forms.TextBox TextBoxPrice = groupBox5.Controls.Find("price" + j, true).FirstOrDefault() as System.Windows.Forms.TextBox;
                System.Windows.Forms.TextBox TextBoxTotalPrice = groupBox5.Controls.Find("totalPrice" + j, true).FirstOrDefault() as System.Windows.Forms.TextBox;

                if (textBoxQuantity.Text != "" && TextBoxPrice.Text != "")
                {
                    TextBoxTotalPrice.Text = Convert.ToInt64(TextBoxPrice.Text) * Convert.ToInt64(textBoxQuantity.Text)+"";
                }
            }
            catch
            {
                MessageBox.Show("Số lượng phải là số!");
            }
        }

        private void price_TextChanged(object sender, EventArgs e)
        {
            try
            {
                System.Windows.Forms.TextBox textBoxPrice = sender as System.Windows.Forms.TextBox;
                int j = (int)textBoxPrice.Tag;

                System.Windows.Forms.TextBox textBoxQuantity = groupBox5.Controls.Find("quantity" + j, true).FirstOrDefault() as System.Windows.Forms.TextBox;
                System.Windows.Forms.TextBox TextBoxTotalPrice = groupBox5.Controls.Find("totalPrice" + j, true).FirstOrDefault() as System.Windows.Forms.TextBox;

                if (textBoxQuantity.Text != "" && textBoxPrice.Text != "")
                {
                    TextBoxTotalPrice.Text = Convert.ToInt64(textBoxPrice.Text) * Convert.ToInt64(textBoxQuantity.Text) + "";
                }
            }
            catch
            {
                MessageBox.Show("Giá phải là số!");
            }
        }

        private void totalPrice_TextChanged(object sender, EventArgs e)
        {
            System.Windows.Forms.TextBox TextBoxTotalPrice = sender as System.Windows.Forms.TextBox;
            int j = (int)TextBoxTotalPrice.Tag;

            lblTotal.Text = (Convert.ToInt64(lblTotal.Text.ToString()) - lstotalPrice[(j-1)]).ToString();

            listtotalprice(j, TextBoxTotalPrice.Text);

            lblTotal.Text = (Convert.ToInt64(lblTotal.Text.ToString()) + lstotalPrice[(j - 1)]).ToString();
        }
    }
}
