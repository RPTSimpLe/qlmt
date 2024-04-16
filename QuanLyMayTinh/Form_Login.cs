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
    public partial class Form_login : Form
    {
        private BUS_Users bus_Users = new BUS_Users();
        public Form_login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text == "" || txtPass.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ");
            }
            else
            {
                int check = 0;
                DataTable dt = bus_Users.getAllRoleId();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (dt.Rows[i]["Tên đăng nhập"].ToString() == txtUserName.Text && dt.Rows[i]["Mật khẩu"].ToString() == txtPass.Text)
                    {

                        DTO_Users users = new DTO_Users(Convert.ToInt32(dt.Rows[i]["ID"].ToString()), dt.Rows[i]["Họ và tên"].ToString(), dt.Rows[i]["Tên đăng nhập"].ToString(),
                                                        dt.Rows[i]["Mật khẩu"].ToString(), dt.Rows[i]["Giới tính"].ToString(), dt.Rows[i]["Số điện thoại"].ToString(),
                                                        Convert.ToDateTime(dt.Rows[i]["Ngày sinh"].ToString()), dt.Rows[i]["Email"].ToString(), dt.Rows[i]["Địa chỉ"].ToString(),
                                                        Convert.ToInt32(dt.Rows[i]["Quyền"].ToString()));
                        Form_Sidebar form_Sidebar = new Form_Sidebar(users);
                        form_Sidebar.ShowDialog();
                        check++;
                        this.Close();
                        return;
                    }
                }
                if(check==0) { MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu"); }
            }
        }
    }
}
