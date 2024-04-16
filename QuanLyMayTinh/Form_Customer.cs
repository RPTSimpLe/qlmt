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
    public partial class Form_Customer : Form
    {
        private BUS_Customer Customer = new BUS_Customer();
        public Form_Customer()
        {
            InitializeComponent();
        }

        private void Form_Customer_Load(object sender, EventArgs e)
        {
               dataGridView1.DataSource= Customer.getAllData();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dataGridView1.CurrentRow.Index;

            ids.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            names.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            phones.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            address.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
        }

        private void search_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource =  Customer.findCustomerByFullName(nameCus.Text);
        }

        private void add_Click(object sender, EventArgs e)
        {
            String name = names.Text;
            String phone = phones.Text;
            String addres = address.Text;
            DTO_Customer customer = new DTO_Customer(0,name,phone,addres);

            Customer.addAccountCustomer(customer);
            dataGridView1.DataSource = Customer.findCustomerByFullName(nameCus.Text);
        }

        private void save_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(ids.Text);
            String name = names.Text;
            String phone = phones.Text;
            String addres = address.Text;
            DTO_Customer customer = new DTO_Customer(id, name, phone, addres);

            Customer.updateAccountCustomer(customer);
            dataGridView1.DataSource = Customer.findCustomerByFullName(nameCus.Text);
        }

        private void delete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(ids.Text);

            Customer.deleteById(id);
            dataGridView1.DataSource = Customer.findCustomerByFullName(nameCus.Text);
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(ids.Text);
            String name = names.Text;
            String phone = phones.Text;
            String addres = address.Text;
            DTO_Customer customer = new DTO_Customer(id, name, phone, addres);

        }
    }
}
