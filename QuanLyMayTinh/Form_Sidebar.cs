using DTO_Manegement;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyMayTinh
{
    public partial class Form_Sidebar : Form
    {
        private Button currentButton;
        private int tempIndex;
        private Form activeForm;
        private DTO_Users users;
        public Form_Sidebar()
        {
            InitializeComponent();
            btnCloseChildForm.Visible = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        public Form_Sidebar(DTO_Users users)
        {
            InitializeComponent();
            btnCloseChildForm.Visible = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.users = users;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    currentButton = (Button)btnSender;
                    currentButton.ForeColor = Color.Black;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    btnCloseChildForm.Visible = true;
                }
            }
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(176, 196, 222);
                    previousBtn.ForeColor = Color.Black;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktopPane.Controls.Add(childForm);
            this.panelDesktopPane.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = childForm.Text;           
        }
             
        private void Reset()
        {
            DisableButton();
            lblTitle.Text = "Trang Chủ";
            panelTitleBar.BackColor = Color.FromArgb(70, 130, 180);
            panelLogo.BackColor = Color.FromArgb(176, 196, 222);
            currentButton = null;
            btnCloseChildForm.Visible = false;
        }
        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }
        private void bntMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btProducts_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form_Product(), sender);
        }

        private void btCategorys_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form_Category(), sender);
        }

        private void btProducers_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form_Producer(), sender);
        }

        private void btnCloseChildForm_Click_1(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            Reset();
        }

        private void btAccounts_Click(object sender, EventArgs e)
        {
            Console.WriteLine(users.getRole_id());
            if (this.users.getRole_id() == 1)
            {
                OpenChildForm(new Form_Account(), sender);
            }
            else { MessageBox.Show("bạn không được sử dụng tính năng này"); }
        }

        private void btnRole_Click(object sender, EventArgs e)
        {
            if (this.users.getRole_id() == 1) {
                OpenChildForm(new Form_Role(), sender);            
            }
            else { MessageBox.Show("bạn không được sử dụng tính năng này"); }
        }

        private void btnSell_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form_Sell(), sender);
        }

        private void btnThongKeChi_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form_Customer(), sender);
        }

        private void btnThongKeThu_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form_Bill(), sender);
        }

        private void Form_Sidebar_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            OpenChildForm(new Form_ThongKeChi(), sender);
        }

        private void button2_Click(object sender, EventArgs e)
        {
     
            OpenChildForm(new Form_ThongKeThu(), sender);

        }
    }
}
