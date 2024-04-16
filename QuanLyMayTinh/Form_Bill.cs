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
using System.IO;
using OfficeOpenXml;
using Excel = Microsoft.Office.Interop.Excel;
using DTO_Manegement;

namespace QuanLyMayTinh
{
    public partial class Form_Bill : Form
    {
        private BUS_bill bUS_Bill = new BUS_bill();
        private Bus_detailBill bus_Detail = new Bus_detailBill();
        public Form_Bill()
        {
            InitializeComponent();
        }

        private void Form_Bill_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bUS_Bill.findBill("","");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dataGridView1.CurrentRow.Index;
            txt_idBills.Text = dataGridView1.Rows[i].Cells[0].Value.ToString(); 
        }

        private void deleteBill_Click(object sender, EventArgs e)
        {
            if(txt_idBills.Text == "") { MessageBox.Show("Vui lòng chọn hóa đơn muốn xóa"); }
            else {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa hóa đơn này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    if (bUS_Bill.deleteBillById(txt_idBills.Text))
                    {
                        MessageBox.Show("Xóa thành công");
                        dataGridView1.DataSource = bUS_Bill.findBill( "", "");
                    }
                    else { MessageBox.Show("Xóa thất bại"); }
                }
            }
        }

        private void searchBill_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bUS_Bill.findBill(txt_IdBill.Text, txt_NameCus.Text);
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

        private void saveBill_Click(object sender, EventArgs e)
        {
            int i = dataGridView1.CurrentRow.Index;
            List< DTO_detailBill> list = bus_Detail.findDetailBill(dataGridView1.Rows[i].Cells[0].Value.ToString());
            DataTable billDT = bUS_Bill.findAllFeatureBill(dataGridView1.Rows[i].Cells[0].Value.ToString());

            Form_DetailBill form_DetailBill = new Form_DetailBill(billDT, list);
            form_DetailBill.ShowDialog();
        }
    }
}
