﻿using DTO_Manegement;
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
    public partial class Form_DetailBill : Form
    {

        private DataTable billDT;
        private List<DTO_detailBill> lsdTO_Detail;
        public Form_DetailBill(DataTable billDT, List<DTO_detailBill> lsdTO_Detail)
        {
            InitializeComponent();
            this.billDT = billDT;
            this.lsdTO_Detail = lsdTO_Detail;
        }

        private void btnPrint_Click(object sender, EventArgs e)
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

            string header = "Hóa đơn số: " + this.billDT.Rows[0]["MaHD"].ToString();
            yPos = lineHeight + count * font.GetHeight(g);
            g.DrawString(header, font, brush, 100, yPos);

            string nameCus = "Tên khách hàng: " + this.billDT.Rows[0]["tenkh"].ToString();
            yPos += lineHeight + count * font.GetHeight(g);
            g.DrawString(nameCus, font, brush, 100, yPos);

            string phone = "Điện thoại: " + this.billDT.Rows[0]["dienthoai"].ToString();
            yPos += lineHeight + count * font.GetHeight(g);
            g.DrawString(phone, font, brush, 100, yPos);

            string address = "Địa chỉ: " + this.billDT.Rows[0]["diachi"].ToString();
            yPos += lineHeight + count * font.GetHeight(g);
            g.DrawString(address, font, brush, 100, yPos);

            string createdAT = "Ngày bán: " + this.billDT.Rows[0]["ngaytao"].ToString();
            yPos += lineHeight + count * font.GetHeight(g);
            g.DrawString(createdAT, font, brush, 100, yPos);
            yPos += 50;

            int cellWidth = 100;
            int cellHeight = (int)font.GetHeight(g) + 10;

            g.DrawRectangle(pen, 70, yPos, 50, cellHeight);
            g.DrawString("STT", font, brush, 70, yPos);

            g.DrawRectangle(pen, 120, yPos, cellWidth * 2, cellHeight);
            g.DrawString("Sản phẩm", font, brush, 120, yPos);

            g.DrawRectangle(pen, 320, yPos, cellWidth * 2, cellHeight);
            g.DrawString("Tùy chọn", font, brush, 320, yPos);

            g.DrawRectangle(pen, 520, yPos, cellWidth, cellHeight);
            g.DrawString("Số lượng", font, brush, 520, yPos);

            g.DrawRectangle(pen, 620, yPos, cellWidth, cellHeight);
            g.DrawString("Đơn giá", font, brush, 620, yPos);

            g.DrawRectangle(pen, 720, yPos, cellWidth, cellHeight);
            g.DrawString("Tổng", font, brush, 720, yPos);

            yPos += cellHeight;

            int i = 1;
            foreach (DTO_detailBill dTO_Detail in this.lsdTO_Detail)
            {
                g.DrawRectangle(pen, 70, yPos, 50, cellHeight);
                g.DrawString(i.ToString(), font, brush, 70, yPos);

                g.DrawRectangle(pen, 120, yPos, cellWidth * 2, cellHeight);
                g.DrawString(dTO_Detail.getNamePro(), font, brush, 120, yPos);

                g.DrawRectangle(pen, 320, yPos, cellWidth * 2, cellHeight);
                g.DrawString("ram: "+dTO_Detail.getRam()+" - ổ cứng: "+ dTO_Detail.getStorage(), font, brush, 320, yPos);

                g.DrawRectangle(pen, 520, yPos, cellWidth, cellHeight);
                g.DrawString(dTO_Detail.getQuantity().ToString(), font, brush, 520, yPos);

                g.DrawRectangle(pen, 620, yPos, cellWidth, cellHeight);
                g.DrawString(dTO_Detail.getPrice().ToString(), font, brush, 620, yPos);

                g.DrawRectangle(pen, 720, yPos, cellWidth, cellHeight);
                g.DrawString(dTO_Detail.getTongTien().ToString(), font, brush, 720, yPos);


                yPos += cellHeight;
                i++;
            }
        }

        private void Form_DetailBill_Load(object sender, EventArgs e)
        {
            txt_Address.Text = this.billDT.Rows[0]["diachi"].ToString();
            txt_idBill.Text = this.billDT.Rows[0]["MaHD"].ToString();
            txt_nameCus.Text = this.billDT.Rows[0]["tenkh"].ToString();
            txt_phone.Text = this.billDT.Rows[0]["dienthoai"].ToString();
            txt_createdAt.Text = this.billDT.Rows[0]["ngaytao"].ToString();

            int i = 1;
            dataGridView1.ColumnCount = 6;
            dataGridView1.Columns[0].Name = "STT";
            dataGridView1.Columns[1].Name = "Sản phẩm";
            dataGridView1.Columns[2].Name = "Tùy chọn";
            dataGridView1.Columns[3].Name = "Số lượng";
            dataGridView1.Columns[4].Name = "Đơn giá";
            dataGridView1.Columns[5].Name = "Tổng";
            double total = 0;
            foreach (var dTO_Detail in lsdTO_Detail)
            {
                string[] row = new string[] { i.ToString(),dTO_Detail.getNamePro(),"ram: "+dTO_Detail.getRam()+" - ổ cứng: "+ dTO_Detail.getStorage(),dTO_Detail.getQuantity().ToString(),
                                  dTO_Detail.getPrice().ToString(), dTO_Detail.getTongTien().ToString()};
                total += dTO_Detail.getTongTien();
                dataGridView1.Rows.Add(row);
                i++;
            }
            lblTotal.Text = total.ToString();
        }
    }
}
