using BUS_Manegement;
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
    public partial class Form_ThongKeChi : Form
    {
        private BUS_expense_statistics bUS_Expense_Statistics = new BUS_expense_statistics();
        private BUS_incomeStatistics bUS_IncomeStatistics = new BUS_incomeStatistics();
        public Form_ThongKeChi()
        {
            InitializeComponent();
        }

        private void Form_ThongKeChi_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bUS_Expense_Statistics.getAll();
            lbl_chi.Text = bUS_Expense_Statistics.total().Rows[0]["tong"].ToString();
            lbl_thu.Text = bUS_IncomeStatistics.total().Rows[0]["tong"].ToString();
            lbl_doanhThu.Text = (Convert.ToDouble(bUS_IncomeStatistics.total().Rows[0]["tong"]) - Convert.ToDouble(bUS_Expense_Statistics.total().Rows[0]["tong"])).ToString();
        }
    }
}
