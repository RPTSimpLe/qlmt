using BUS_Manegement;
using DTO_Manegement;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyMayTinh
{
    public partial class Form_Role : Form
    {
        public static BUS_Role role = new BUS_Role();
        public Form_Role()
        {
            InitializeComponent();
        }

        private void addRole_Click(object sender, EventArgs e)
        {
            string roless = roles.Text;

            if (string.IsNullOrWhiteSpace(roless))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin !");
            }
            else
            {
                DTO_Role dTO_Role = new DTO_Role(0, roless);
                role.AddRoles(dTO_Role);
                roles.Text = "";
                dataGridView1.DataSource = role.getAllData();
                MessageBox.Show("Thêm quyền thành công.");
            }
        }

        private void deleteRole_Click(object sender, EventArgs e)
        {
            if (ids.Text != "")
            {
                int id = Convert.ToInt32(ids.Text);

                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa quyền này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    if (role.deleteRoles(id))
                    {
                        roles.Text = "";
                        MessageBox.Show("Xóa quyền thành công.");
                        dataGridView1.DataSource = role.getAllData();
                    }
                    else
                    {
                        MessageBox.Show("Xóa quyền không thành công.");
                    }
                }
            }
            else { MessageBox.Show("Vui lòng chọn quyền!"); }
        }

        private void saveRole_Click(object sender, EventArgs e)
        {
            if (ids.Text != "")
            {
                int id = Convert.ToInt32(ids.Text);
                string name = roles.Text;

                DTO_Role dTO_Role = new DTO_Role(id, name);
                if (string.IsNullOrWhiteSpace(name))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin !");
                }
                else
                {
                    if (role.updateRoles(dTO_Role))
                    {
                        roles.Text = "";
                        MessageBox.Show("Cập nhật quyền thành công.");
                        dataGridView1.DataSource = role.getAllData();
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật quyền không thành công.");
                    }
                }
            }
            else { MessageBox.Show("Vui lòng chọn quyền!"); }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            ids.ResetText();
            roles.ResetText();
            dataGridView1.DataSource = role.getAllData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dataGridView1.CurrentRow.Index;
            ids.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            roles.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
        }

        private void Form_Role_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = role.getAllData();
        }
    }
}
