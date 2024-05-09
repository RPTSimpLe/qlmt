using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS_Manegement;
using DTO_Manegement;
using System.IO;
using OfficeOpenXml;
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Vbe.Interop;


namespace QuanLyMayTinh
{
    public partial class Form_Producer : Form
    {
        public static BUS_Producer bus = new BUS_Producer();
        public Form_Producer()
        {
            InitializeComponent();
        }

        private void Form_Producer_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bus.getAllData();
        }

        private void addProducer_Click(object sender, EventArgs e)
        {
            string code = codes.Text;
            string name = names.Text;

            if (string.IsNullOrWhiteSpace(code) || string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin !");
            }
            else
            {
                if (bus.CheckDuplicateProducer(code, name))
                {
                    MessageBox.Show("Nhà sản xuất đã tồn tại!");
                }
                else
                {
                    DTO_Producer dTO_Producer = new DTO_Producer(0, code, name);
                    bus.AddProducer(dTO_Producer);
                    codes.Text = "";
                    names.Text = "";
                    dataGridView1.DataSource = bus.getAllData();
                    MessageBox.Show("Thêm nhà sản xuất thành công.");
                }
            }
        }

        private void deleteProducer_Click(object sender, EventArgs e)
        {
            if (ids.Text != "")
            {
                int id = Convert.ToInt32(ids.Text);

                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa nhà sản xuất này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    if (bus.deleteProducer(id))
                    {
                        MessageBox.Show("Xóa nhà sản xuất thành công.");
                        dataGridView1.DataSource = bus.getAllData();
                    }
                    else
                    {
                        MessageBox.Show("Xóa nhà sản xuất không thành công.");
                    }
                }
            }
            else { MessageBox.Show("Vui lòng chọn nhà sản xuất!"); }
        }
       

        private void saveProducer_Click(object sender, EventArgs e)
        {
            if (ids.Text != "")
            {
                string code = codes.Text;
                string name = names.Text;
                if (code != "" && name != "")
                {

                    int id = Convert.ToInt32(ids.Text);
                    DTO_Producer dTO_Producer = new DTO_Producer(id, code, name);

                    if (bus.updateProducer(dTO_Producer))
                    {
                        MessageBox.Show("Cập nhật nhà sản xuất thành công.");
                        dataGridView1.DataSource = bus.getAllData();
                    }
                }
                else { MessageBox.Show("Vui lòng điền đầy đủ thông tin!"); }
            }
            else { MessageBox.Show("Vui lòng chọn nhà sản xuất!"); }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            ids.ResetText();
            code_producer.ResetText();
            name_producer.ResetText();
            codes.ResetText();
            names.ResetText();
            dataGridView1.DataSource = bus.getAllData();
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

        private void searchProducer_Click(object sender, EventArgs e)
        {
            string searchName = name_producer.Text;
            string searchCode = code_producer.Text;

            DataTable searchResults;

            searchResults = bus.FindProducer(searchName,searchCode);
            dataGridView1.DataSource = searchResults;
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int i = dataGridView1.CurrentRow.Index;
            ids.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            codes.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            names.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
        }

        private void name_producer_TextChanged(object sender, EventArgs e)
        {
            code_producer.Text = "";
            dataGridView1.DataSource = bus.getAllData();
        }

        private void code_producer_TextChanged(object sender, EventArgs e)
        {
            name_producer.Text = "";
            dataGridView1.DataSource = bus.getAllData();
        }
    }
}
