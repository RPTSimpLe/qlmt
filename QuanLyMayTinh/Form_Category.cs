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
using System.IO;
using OfficeOpenXml;
using Excel = Microsoft.Office.Interop.Excel;

namespace QuanLyMayTinh
{
    public partial class Form_Category : Form
    {
        public static BUS_Category bus = new BUS_Category();
        public Form_Category()
        {
            InitializeComponent();
        }

        private void Form_Category_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bus.getAllData();
          
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dataGridView1.CurrentRow.Index;
            ids.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            codes.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            names.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            

        }

        private void addCate_Click(object sender, EventArgs e)
        {
            string code = codes.Text;
            string name = names.Text;

            if (string.IsNullOrWhiteSpace(code) || string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin !");
            }
            else
            {
                if (bus.CheckDuplicateCategory(code, name))
                {
                    MessageBox.Show("Danh mục đã tồn tại!");
                }
                else
                {
                    DTO_Category dTO_Category = new DTO_Category(0, name, code);
                    bus.AddCategory(dTO_Category);
                    codes.Text = "";
                    names.Text = "";
                    dataGridView1.DataSource = bus.getAllData();
                    MessageBox.Show("Thêm danh mục thành công.");
                }
            }
        }


        private void saveCate_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(ids.Text);
            string code = codes.Text;
            string name = names.Text;

            DTO_Category dTO_Category = new DTO_Category(id, name, code);

            if (bus.updateCategories(dTO_Category))
            {
                MessageBox.Show("Cập nhật danh mục thành công.");
                dataGridView1.DataSource = bus.getAllData();
            }
            else
            {
                MessageBox.Show("Cập nhật danh mục không thành công.");
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            ids.ResetText();
            codes.ResetText();
            names.ResetText();
            codeCate.ResetText();
            nameCate.ResetText();
            dataGridView1.DataSource = bus.getAllData();

        }

        private void deleteCate_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(ids.Text);

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa danh mục này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (bus.deleteCategories(id))
                {
                    MessageBox.Show("Xóa danh mục thành công.");
                    dataGridView1.DataSource = bus.getAllData();
                }
                else
                {
                    MessageBox.Show("Xóa danh mục không thành công.");
                }
            }
        }

        private void searchCate_Click(object sender, EventArgs e)
        {
            string searchName = nameCate.Text;
            string searchCode = codeCate.Text;

            if (string.IsNullOrEmpty(searchName) && string.IsNullOrEmpty(searchCode))
            {
                MessageBox.Show("Vui lòng nhập tên hoặc mã danh mục cần tìm kiếm.");
                return;
            }

            DataTable searchResults;

            if (!string.IsNullOrEmpty(searchName))
            {
                searchResults = bus.FindByNameCategory(searchName);
            }
            else
            {
                searchResults = bus.FindByCodeCategory(searchCode);
            }

            if (searchResults != null && searchResults.Rows.Count > 0)
            {

                dataGridView1.DataSource = searchResults;
            }
            else
            {
                MessageBox.Show("Không có kết quả nào được tìm thấy.");
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
        private void ImportExcel(string path)
        {
            using (ExcelPackage excelPackage = new ExcelPackage(new FileInfo(path))) { 
                ExcelWorksheet excelWorksheet = excelPackage.Workbook.Worksheets[0];
                DataTable dataTable = new DataTable();
                for(int i = excelWorksheet.Dimension.Start.Column;i <= excelWorksheet.Dimension.End.Column;i++)
                {
                    dataTable.Columns.Add(excelWorksheet.Cells[1, i].Value.ToString());
                }
                for(int i=excelWorksheet.Dimension.Start.Row + 1;i<= excelWorksheet.Dimension.End.Row; i++)
                {
                    List<string> listRows = new List<string>();
                    for(int j = excelWorksheet.Dimension.Start.Column; j <= excelWorksheet.Dimension.End.Column; j++)
                    {
                        listRows.Add(excelWorksheet.Cells[i, j].Value.ToString());
                    }
                    dataTable.Rows.Add(listRows.ToArray());
                }
                dataGridView1.DataSource = dataTable;
            }
        }
        //ho
        private void excelExport_Click(object sender, EventArgs e)
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
                }catch(Exception ex)
                {
                    MessageBox.Show("Xuất file không thành công !\n"+ex.Message);
                }
            }

        }

        private void import_excel_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Import Excel";
            openFileDialog.Filter = "Excel (*.xlsx)|*.xlsx|Excel 2003 (*.xls)|*.xls";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    ImportExcel(openFileDialog.FileName);
                    MessageBox.Show("Nhập file Excel thành công !");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Nhập file không thành công !\n" + ex.Message);
                }
            }
        }
    }
}
