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
    public partial class Form_Category : Form
    {
        public static BUS_Category bus = new BUS_Category();
        public Form_Category()
        {
            InitializeComponent();
        }

        private void Form_Category_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bus.getAllData();
          
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dataGridView1.CurrentRow.Index;
            ids.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            codes.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            names.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            

        }

        private void addCate_Click(object sender, EventArgs e)
        {
            string code = codes.Text;
            string name = names.Text;

            if (string.IsNullOrWhiteSpace(code) || string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin !");
            }
            else
            {
                if (bus.CheckDuplicateCategory(code, name))
                {
                    MessageBox.Show("Danh mục đã tồn tại!");
                }
                else
                {
                    DTO_Category dTO_Category = new DTO_Category(0, name, code);
                    bus.AddCategory(dTO_Category);
                    codes.Text = "";
                    names.Text = "";
                    dataGridView1.DataSource = bus.getAllData();
                    MessageBox.Show("Thêm danh mục thành công.");
                }
            }
        }


        private void saveCate_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(ids.Text);
            string code = codes.Text;
            string name = names.Text;

            DTO_Category dTO_Category = new DTO_Category(id, name, code);

            if (bus.updateCategories(dTO_Category))
            {
                MessageBox.Show("Cập nhật danh mục thành công.");
                dataGridView1.DataSource = bus.getAllData();
            }
            else
            {
                MessageBox.Show("Cập nhật danh mục không thành công.");
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            ids.ResetText();
            codes.ResetText();
            names.ResetText();
            codeCate.ResetText();
            nameCate.ResetText();
            dataGridView1.DataSource = bus.getAllData();

        }

        private void deleteCate_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(ids.Text);

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa danh mục này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (bus.deleteCategories(id))
                {
                    MessageBox.Show("Xóa danh mục thành công.");
                    dataGridView1.DataSource = bus.getAllData();
                }
                else
                {
                    MessageBox.Show("Xóa danh mục không thành công.");
                }
            }
        }

        private void searchCate_Click(object sender, EventArgs e)
        {
            string searchName = nameCate.Text;
            string searchCode = codeCate.Text;

            if (string.IsNullOrEmpty(searchName) && string.IsNullOrEmpty(searchCode))
            {
                MessageBox.Show("Vui lòng nhập tên hoặc mã danh mục cần tìm kiếm.");
                return;
            }

            DataTable searchResults;

            if (!string.IsNullOrEmpty(searchName))
            {
                searchResults = bus.FindByNameCategory(searchName);
            }
            else
            {
                searchResults = bus.FindByCodeCategory(searchCode);
            }

            if (searchResults != null && searchResults.Rows.Count > 0)
            {

                dataGridView1.DataSource = searchResults;
            }
            else
            {
                MessageBox.Show("Không có kết quả nào được tìm thấy.");
            }
        }

    }
}
