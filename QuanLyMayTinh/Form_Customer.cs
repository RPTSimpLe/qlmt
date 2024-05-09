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
using System.Text.RegularExpressions;
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
            try
            {
                String name = names.Text;
                String phone = phones.Text;
                String addres = address.Text;
                if (!String.IsNullOrEmpty(name) && !String.IsNullOrEmpty(phone) && !String.IsNullOrEmpty(addres))
                {
                    DTO_Customer customer = new DTO_Customer(0, name, phone, addres);

                    if (!IsValidPhone(phone)) {
                        throw new Exception("Số điện thoại phải dài 10 hoặc 11 số!");
                    }

                    Customer.addAccountCustomer(customer);
                    dataGridView1.DataSource = Customer.findCustomerByFullName(nameCus.Text);
                    MessageBox.Show("Thêm thành công!");
                    names.Text="";
                    phones.Text = "";
                    address.Text = "";
                }
                else { MessageBox.Show("Vui lòng điền đầy đủ thông tin!"); }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private bool IsValidPhone(string phone)
        {
            if (phone.Length == 10 || phone.Length == 11) {
                return true;
            }
            return false;
        }

        private void save_Click(object sender, EventArgs e)
        {
            try
            {
                if (ids.Text != "")
                {
                    String name = names.Text;
                    String phone = phones.Text;
                    String addres = address.Text;
                    if (!String.IsNullOrEmpty(name) && !String.IsNullOrEmpty(phone) && !String.IsNullOrEmpty(addres))
                    {

                        if (!IsValidPhone(phone))
                        {
                            throw new Exception("Số điện thoại phải dài 10 hoặc 11 số!");
                        }
                        int id = Convert.ToInt32(ids.Text);
                        DTO_Customer customer = new DTO_Customer(id, name, phone, addres);

                        Customer.updateAccountCustomer(customer);
                        dataGridView1.DataSource = Customer.findCustomerByFullName(nameCus.Text);
                        MessageBox.Show("Cập nhật thành công");
                    }
                }
                else { MessageBox.Show("Vui lòng chọn khách hàng"); }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (ids.Text != "")
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa danh mục này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                int id = Convert.ToInt32(ids.Text);

                if (result == DialogResult.Yes)
                {
                    Customer.deleteById(id);
                    dataGridView1.DataSource = Customer.findCustomerByFullName(nameCus.Text);
                    MessageBox.Show("Xóa thành công.");
                }

            }
            else { MessageBox.Show("Vui lòng chọn khách hàng"); }
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(ids.Text);
            String name = names.Text;
            String phone = phones.Text;
            String addres = address.Text;
            DTO_Customer customer = new DTO_Customer(id, name, phone, addres);

        }

        private void cancel_Click(object sender, EventArgs e)
        {
            names.Text = "";
            phones.Text = "";
            nameCus.Text = "";
            address.Text = "";
            dataGridView1.DataSource = Customer.getAllData();
        }
    }
}
