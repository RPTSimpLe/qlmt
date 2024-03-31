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
    public partial class form_AddOption : Form
    {
        long proId;
        private BUS_optionProduct optionProduct = new BUS_optionProduct();
        public form_AddOption(long proId)
        {
            InitializeComponent();
            this.proId = proId;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String ram = txt_Ram.Text.ToString();
            long quantity = Convert.ToInt64(txt_Quantity.Text.ToString());
            long sellingPrice = Convert.ToInt64(txt_SellPrice.Text.ToString());
            long importPrice = Convert.ToInt64(txt_ImportPrice.Text.ToString());
            String storage = txt_Storegate.Text.ToString();

            DTO_optionProduct dTO_OptionProduct = new DTO_optionProduct(0, ram, storage, quantity, sellingPrice, importPrice, proId);
            optionProduct.addOption(dTO_OptionProduct);
            this.Close();
        }
    }
}
