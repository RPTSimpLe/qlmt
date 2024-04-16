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
    public partial class Form_Payment : Form
    {
        private Bus_detailBill bus_DetailBill = new Bus_detailBill();
        private BUS_Customer customer = new BUS_Customer();
        private BUS_optionProduct opProduct = new BUS_optionProduct();
        private BUS_bill bUS_Bill = new BUS_bill();
        private List<DTO_bill> dTO_Bills = new List<DTO_bill>();
        private List<int> customerIds =new List<int>() ; 
        public Form_Payment()
        {
            InitializeComponent();
            DataTable dt = customer.getAllData();
            renderCbo(dt);
        }

        public Form_Payment(List<DTO_bill> dTO_Bills)
        {
            this.dTO_Bills = dTO_Bills;
            InitializeComponent();
            DataTable dt = customer.getAllData();
            renderCbo(dt);
            renderDatagridview(dTO_Bills);
        }
        private void renderDatagridview(List<DTO_bill> dTO_Bills)
        {
            dataGridView1.ColumnCount = 5;
            dataGridView1.Columns[0].Name = "Tên";
            dataGridView1.Columns[1].Name = "Tùy chọn";
            dataGridView1.Columns[2].Name = "Số lượng";
            dataGridView1.Columns[3].Name = "Đơn giá";
            dataGridView1.Columns[4].Name = "Tổng tiền";
            long total = 0;
            foreach (var bill in dTO_Bills)
            {
                DataTable dataTable = opProduct.findName(bill.getoptionProduct_id());
                string[] row = new string[] { dataTable.Rows[0]["tensp"].ToString(),"ram: "+dataTable.Rows[0]["ram"].ToString()+", ổ cứng: "+dataTable.Rows[0]["storage"].ToString(), bill.getQuantity().ToString(),
                                              bill.getprice().ToString(), (bill.getQuantity()*bill.getprice()).ToString()};
                total += (bill.getQuantity() * bill.getprice());
                dataGridView1.Rows.Add(row);
            }
            lblTotal.Text = total.ToString();
        }
        private void txt_searchCus_TextChanged(object sender, EventArgs e)
        {
            DataTable dt =  customer.findCustomerByFullName(txt_searchCus.Text);
            renderCbo(dt);
        }
        private void renderCbo(DataTable dt)
        {
            comboBox1.Items.Clear();
            for (int a = 0; a < dt.Rows.Count; a++)
            {
                customerIds.Add(Convert.ToInt32(dt.Rows[a]["ID"].ToString()));
                String value = dt.Rows[a]["Họ và tên"].ToString() + " - " + dt.Rows[a]["Số điện thoại"].ToString() + " - " + dt.Rows[a]["Địa chỉ"].ToString();
                comboBox1.Items.Add(value);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            String value = comboBox1.SelectedItem.ToString().Trim();
            string[] parts = value.Split(new string[] { " - " }, StringSplitOptions.RemoveEmptyEntries);
            
            txt_nameCus.Text = parts[0];
            txt_phone.Text = parts[1];
            txt_Address.Text = parts[2];

            int i = comboBox1.SelectedIndex;
            foreach (var bill in this.dTO_Bills)
            {
                bill.setCustomer_id(customerIds[i]);
            }
        }
        private void addCustomer()
        {
            int i = comboBox1.SelectedIndex;
            if(i == -1)
            {
                    DTO_Customer dTO_Customer = new DTO_Customer();
                    dTO_Customer.setfullname(txt_nameCus.Text);
                    dTO_Customer.setphone(txt_phone.Text);
                    dTO_Customer.setaddres(txt_Address.Text);

                    customer.addAccountCustomer(dTO_Customer);
            }
        }
        private void btnPayment_Click(object sender, EventArgs e)
        {
            if (txt_Address.Text.Trim() == "" && txt_nameCus.Text.Trim() == "" && txt_phone.Text.Trim() == "")
            {
                MessageBox.Show("Vui long nhap day du thong tin khach hang");
            }
            else
            {
                addCustomer();
                bUS_Bill.addBill(this.dTO_Bills);
                foreach (var bill in this.dTO_Bills)
                {
                    updateOptionProduct(bill);
                }
                PrintDocument pd = new PrintDocument();
                pd.PrintPage += new PrintPageEventHandler(this.PrintDocument_PrintPage);

                PrintPreviewDialog ppd = new PrintPreviewDialog();
                ppd.Document = pd;
                ppd.ClientSize = new Size(1000, 900);
                ppd.ShowDialog();

                this.Close();
            }
        }

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            DataTable billDT = bUS_Bill.findLatedBill();
            List<DTO_detailBill> lsdTO_Detail = bus_DetailBill.findDetailBill(billDT.Rows[0]["MaHD"].ToString());

            Graphics g = e.Graphics;
            Font font = new Font("Arial", 14);
            Brush brush = Brushes.Black;
            Pen pen = new Pen(Color.Black, 1);

            float yPos = 0;
            int count = 0;
            int lineHeight = 30;

            string header = "Hóa đơn số: " + billDT.Rows[0]["MaHD"].ToString();
            yPos = lineHeight + count * font.GetHeight(g);
            g.DrawString(header, font, brush, 100, yPos);

            string nameCus = "Tên khách hàng: " + billDT.Rows[0]["tenkh"].ToString();
            yPos += lineHeight + count * font.GetHeight(g);
            g.DrawString(nameCus, font, brush, 100, yPos);

            string phone = "Điện thoại: " + billDT.Rows[0]["dienthoai"].ToString();
            yPos += lineHeight + count * font.GetHeight(g);
            g.DrawString(phone, font, brush, 100, yPos);

            string address = "Địa chỉ: " + billDT.Rows[0]["diachi"].ToString();
            yPos += lineHeight + count * font.GetHeight(g);
            g.DrawString(address, font, brush, 100, yPos);

            string createdAT = "Ngày bán: " + billDT.Rows[0]["ngaytao"].ToString();
            yPos += lineHeight + count * font.GetHeight(g);
            g.DrawString(createdAT, font, brush, 100, yPos);
            yPos += 50;

            int cellWidth = 100;
            int cellHeight = (int)font.GetHeight(g) + 10;

            g.DrawRectangle(pen, 100, yPos, cellWidth, cellHeight);
            g.DrawString("STT", font, brush, 100, yPos);

            g.DrawRectangle(pen, 200, yPos, cellWidth * 2, cellHeight);
            g.DrawString("Sản phẩm", font, brush, 200, yPos);

            g.DrawRectangle(pen, 400, yPos, cellWidth * 2, cellHeight);
            g.DrawString("Tùy chọn", font, brush, 400, yPos);

            g.DrawRectangle(pen, 500, yPos, cellWidth, cellHeight);
            g.DrawString("Số lượng", font, brush, 500, yPos);

            g.DrawRectangle(pen, 600, yPos, cellWidth, cellHeight);
            g.DrawString("Đơn giá", font, brush, 600, yPos);

            g.DrawRectangle(pen, 700, yPos, cellWidth, cellHeight);
            g.DrawString("Tổng", font, brush, 700, yPos);

            yPos += cellHeight;

            int i = 1;
            foreach (DTO_detailBill dTO_Detail in lsdTO_Detail)
            {
                g.DrawRectangle(pen, 100, yPos, cellWidth, cellHeight);
                g.DrawString(i.ToString(), font, brush, 100, yPos);

                g.DrawRectangle(pen, 200, yPos, cellWidth * 2, cellHeight);
                g.DrawString(dTO_Detail.getNamePro(), font, brush, 200, yPos);

                g.DrawRectangle(pen, 400, yPos, cellWidth, cellHeight);
                g.DrawString("ram: " + dTO_Detail.getRam() + " - ổ cứng: " + dTO_Detail.getStorage(), font, brush, 400, yPos);

                g.DrawRectangle(pen, 500, yPos, cellWidth, cellHeight);
                g.DrawString(dTO_Detail.getQuantity().ToString(), font, brush, 500, yPos);

                g.DrawRectangle(pen, 600, yPos, cellWidth, cellHeight);
                g.DrawString(dTO_Detail.getPrice().ToString(), font, brush, 600, yPos);

                g.DrawRectangle(pen, 700, yPos, cellWidth, cellHeight);
                g.DrawString(dTO_Detail.getTongTien().ToString(), font, brush, 700, yPos);


                yPos += cellHeight;
                i++;
            }
        }
    private void updateOptionProduct(DTO_bill dTO_Bill)
        {
            DTO_optionProduct dTO_OptionProduct= opProduct.findById(dTO_Bill.getoptionProduct_id());
            if(dTO_OptionProduct.getSelllingPrice()!=dTO_Bill.getprice()) {
                dTO_OptionProduct.setSellingPrice(dTO_Bill.getprice());
            }

            long newQuantity = dTO_OptionProduct.getQuantity() - dTO_Bill.getQuantity();
            dTO_OptionProduct.setQuantity(newQuantity);
            opProduct.updateOption(dTO_OptionProduct, 1);
        }

    }
}
