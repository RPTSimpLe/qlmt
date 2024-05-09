using BUS_Manegement;
using DTO_Manegement;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
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

        private void printBTN_Click(object sender, EventArgs e)
        {
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(this.PrintDocument_PrintPage);

            PrintPreviewDialog ppd = new PrintPreviewDialog();
            ppd.Document = pd;
            ppd.ClientSize = new Size(1000, 900);
            ppd.ShowDialog();
        }
        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            Font font = new Font("Arial", 14);
            Brush brush = Brushes.Black;
            Pen pen = new Pen(Color.Black, 1);

            float yPos = 0;
            int count = 0;
            int lineHeight = 30;

            string header = "";
            yPos = lineHeight + count * font.GetHeight(g);
            g.DrawString(header, font, brush, 100, yPos);
            yPos += 50;

            int cellWidth = 100;
            int cellHeight = (int)font.GetHeight(g) + 10;

            g.DrawRectangle(pen, 10, yPos, 50, cellHeight);
            g.DrawString("STT", font, brush, 10, yPos);

            g.DrawRectangle(pen, 60, yPos, cellWidth * 2, cellHeight);
            g.DrawString("Sản phẩm", font, brush, 60, yPos);

            g.DrawRectangle(pen, 260, yPos, cellWidth * 2, cellHeight);
            g.DrawString("Linh kiện", font, brush, 260, yPos);

            g.DrawRectangle(pen, 460, yPos, 50, cellHeight);
            g.DrawString("SL", font, brush, 460, yPos);

            g.DrawRectangle(pen, 510, yPos, cellWidth, cellHeight);
            g.DrawString("Giá nhập", font, brush, 510, yPos);

            g.DrawRectangle(pen, 610, yPos, cellWidth, cellHeight);
            g.DrawString("Tổng", font, brush, 610, yPos);

            g.DrawRectangle(pen, 710, yPos, cellWidth, cellHeight);
            g.DrawString("Ngày nhập", font, brush, 710, yPos);

            yPos += cellHeight;

            DataTable dts = bUS_Expense_Statistics.getAll();

            for (int i = 0; i < dts.Rows.Count; i++)
            {
                g.DrawRectangle(pen, 10, yPos, 50, cellHeight);
                g.DrawString(""+(i+1), font, brush, 10, yPos);

                g.DrawRectangle(pen, 60, yPos, cellWidth * 2, cellHeight);
                g.DrawString(dts.Rows[i]["Tên sản phẩm"].ToString(), font, brush, 60, yPos);

                g.DrawRectangle(pen, 260, yPos, cellWidth * 2, cellHeight);
                g.DrawString(dts.Rows[i]["Linh kiện"].ToString(), font, brush, 260, yPos);

                g.DrawRectangle(pen, 460, yPos, 50, cellHeight);
                g.DrawString(dts.Rows[i]["Số lượng nhập"].ToString(), font, brush, 460, yPos);

                g.DrawRectangle(pen, 510, yPos, cellWidth, cellHeight);
                g.DrawString(dts.Rows[i]["Giá nhập"].ToString(), font, brush, 510, yPos);

                g.DrawRectangle(pen, 610, yPos, cellWidth, cellHeight);
                g.DrawString(dts.Rows[i]["Tổng"].ToString(), font, brush, 610, yPos);

                g.DrawRectangle(pen, 710, yPos, cellWidth, cellHeight);
                g.DrawString(dts.Rows[i]["Ngày nhập"].ToString().Substring(0,9), font, brush, 710, yPos);

                yPos += cellHeight;
            }
        }

    }
}
