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
using Microsoft.Office.Interop.Excel;
using System.Security.Cryptography;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Text.RegularExpressions;

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
            try
            {
                string name = names.Text;
                string username = usernames.Text;
                string pass = passw.Text;
                string phone = phones.Text;
                string gender = "";
                string adres = address.Text;
                string email = emails.Text;
                if (name != "" && username != "" && username != "" && pass != "" && phone != "" && adres != "" && email != "" && comboRole.SelectedIndex > -1)
                {
                    if (radioNam.Checked)
                    {
                        gender = "Nam";
                    }
                    else if (radioNu.Checked)
                    {
                        gender = "Nữ";
                    }
                    string roleName = comboRole.SelectedItem.ToString();
                    int roleId = dal.GetRoleIdByRoleName(roleName);

                    if (IsValidEmail(email)) { throw new Exception("Email không đúng định dạng!"); }
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
                else { MessageBox.Show("Vui lòng điền đầy đủ thông tin!"); }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public bool IsValidEmail(string email)
        {
            string pattern = @"^[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@\.gmail\.com$";
            return Regex.IsMatch(email, pattern);
        }

        private void deleteUser_Click(object sender, EventArgs e)
        {
            if (ids.Text != "")
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
            else { MessageBox.Show("Vui lòng chọn tài khoản!"); }
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
            try
            {
                if (ids.Text != "")
                {
                    string name = names.Text;
                    string username = usernames.Text;
                    string pass = passw.Text;
                    string phone = phones.Text;
                    string gender = "";
                    string adres = address.Text;
                    string email = emails.Text;
                    if (name != "" && username != "" && username != "" && pass != "" && phone != "" && adres != "" && email != "" && comboRole.SelectedIndex > -1)
                    {
                        int id = Convert.ToInt32(ids.Text);
                        if (radioNam.Checked)
                        {
                            gender = "Nam";
                        }
                        else if (radioNu.Checked)
                        {
                            gender = "Nữ";
                        }
                        string roleName = comboRole.SelectedItem.ToString();
                        int roleId = dal.GetRoleIdByRoleName(roleName);
                        DateTime birthday = births.Value;
                        if (IsValidEmail(email)) { throw new Exception("Email không đúng định dạng!"); }

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
                    else { MessageBox.Show("Vui lòng điền đầy đủ thông tin!"); }
                }
                else { MessageBox.Show("Vui lòng chọn tài khoản!"); }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
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

            System.Data.DataTable searchResults = bus.FindByNameAccount(searchName);

            dataGridView1.DataSource = searchResults;
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
            else if (gender == "Nữ")
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
