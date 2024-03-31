using BUS_Manegement;
using DTO_Manegement;
using Microsoft.Vbe.Interop;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using OfficeOpenXml;
using Excel = Microsoft.Office.Interop.Excel;
using System.Data.SqlClient;
using DAL_Manegement;

namespace QuanLyMayTinh
{
    public partial class Form_Account : Form
    {
        public static BUS_Users bus = new BUS_Users();
        public static DAL_Users dal = new DAL_Users();
        public Form_Account()
        {
            InitializeComponent();
        }

        private void addUser_Click(object sender, EventArgs e)
        {
            string name = names.Text;
            string username = usernames.Text;
            string pass = passw.Text;
            string phone = phones.Text;
            string gender = "";
            if (radioNam.Checked)
            {
                gender = "Nam";
            }
            else if (radioNu.Checked)
            {
                gender = "Nu";
            }
            string adres = address.Text;
            string email = emails.Text;
            string roleName = comboRole.SelectedItem.ToString();
            int roleId = dal.GetRoleIdByRoleName(roleName);
         
            DateTime birthday = births.Value;
            DTO_Users dTO_Users = new DTO_Users(0, name, username, pass, gender, phone, birthday, email, adres, roleId);
            if (bus.addUser(dTO_Users, roleName))
            {
                MessageBox.Show("Thêm người dùng thành công!");
                dataGridView1.DataSource = bus.getAllData();
            }
            else
            {
                MessageBox.Show("Thêm người dùng thất bại!");
            }
        }

        private void deleteUser_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(ids.Text);

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa tài khoản này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (bus.deleteUser(id))
                {
                    MessageBox.Show("Xóa tài khoản thành công.");
                    dataGridView1.DataSource = bus.getAllData();
                }
                else
                {
                    MessageBox.Show("Xóa tài khoản không thành công.");
                }
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            names.ResetText();
            usernames.ResetText();
            passw.ResetText();
            phones.ResetText();
            radioNam.Checked = false;
            radioNu.Checked = false;
            address.ResetText();
            emails.ResetText();
            births.ResetText();
            comboRole.ResetText();
            dataGridView1.DataSource = bus.getAllData();
        }

        private void saveUser_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(ids.Text);
            string name = names.Text;
            string username = usernames.Text;
            string pass = passw.Text;
            string phone = phones.Text;
            string gender = "";
            if (radioNam.Checked)
            {
                gender = "Nam";
            }
            else if (radioNu.Checked)
            {
                gender = "Nu";
            }
            string adres = address.Text;
            string email = emails.Text;
            string roleName = comboRole.SelectedItem.ToString();
            int roleId = dal.GetRoleIdByRoleName(roleName);
            DateTime birthday = births.Value;

            DTO_Users dTO_Users = new DTO_Users(id, name, username, pass, gender, phone, birthday, email, adres, roleId);

            if (bus.updateUser(dTO_Users))
            {
                MessageBox.Show("Cập nhật tài khoản thành công.");
                dataGridView1.DataSource = bus.getAllData();
            }
            else
            {
                MessageBox.Show("Cập nhật tài khoản không thành công.");
            }
        }

        private void export_excel_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Export Excel";
            saveFileDialog.Filter = "Excel (*.xlsx)|*.xlsx|Excel 2003 (*.xls)|*.xls";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    ExportExcel(saveFileDialog.FileName);
                    MessageBox.Show("Xuất file Excel thành công !");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xuất file không thành công !\n" + ex.Message);
                }
            }
        }
        private void ExportExcel(string path)
        {
            Excel.Application application = new Excel.Application();
            application.Application.Workbooks.Add(Type.Missing);
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {

                application.Cells[1, i + 1] = dataGridView1.Columns[i].HeaderText;
            }
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    application.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value;

                }
            }
            application.Columns.AutoFit();
            application.ActiveWorkbook.SaveCopyAs(path);
            application.ActiveWorkbook.Saved = true;
        }

        private void searchUser_Click(object sender, EventArgs e)
        {
            string searchName = nameUser.Text;

            if (string.IsNullOrEmpty(searchName))
            {
                MessageBox.Show("Vui lòng nhập tên tài khoản cần tìm kiếm.");
                return;
            }

            DataTable searchResults = bus.FindByNameAccount(searchName);

            if (searchResults != null && searchResults.Rows.Count > 0)
            {
                dataGridView1.DataSource = searchResults;
            }
            else
            {
                MessageBox.Show("Không có kết quả nào được tìm thấy.");

            }
        }

        private void Form_Account_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bus.getAllData();
            LoadRoleToComboBox();
        }
        private void LoadRoleToComboBox()
        {
            if (comboRole != null)
            {
                bus.LoadRoleToComboBox(comboRole);
            }
            else
            {
                MessageBox.Show("ERROR");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dataGridView1.CurrentRow.Index;
            ids.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            names.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            usernames.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            passw.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            phones.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
            string gender = dataGridView1.Rows[i].Cells[5].Value.ToString();
            if (gender == "Nam")
            {
                radioNam.Checked = true;
            }
            else if (gender == "Nu")
            {
                radioNu.Checked = true;
            }
            string dateString = dataGridView1.Rows[i].Cells[6].Value.ToString();
            DateTime birthday;
            if (DateTime.TryParse(dateString, out birthday))
            {
                births.Value = birthday;
            }
            address.Text = dataGridView1.Rows[i].Cells[7].Value.ToString();

            emails.Text = dataGridView1.Rows[i].Cells[8].Value.ToString();
            comboRole.Text = dataGridView1.Rows[i].Cells[9].Value.ToString();
        }
    }
}
