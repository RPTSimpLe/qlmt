using BUS_Manegement;
using DevExpress.XtraExport.Implementation;
using DTO_Manegement;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyMayTinh
{
    public partial class Form_Detail_Product : Form
    {
        private int proId = 0;
        private BUS_product bUS_Product = new BUS_product();
        private BUS_Image bUS_Image = new BUS_Image();
        private BUS_optionProduct bUS_OptionProduct = new BUS_optionProduct();
        public Form_Detail_Product(int proId)
        {
            InitializeComponent();
            this.proId = proId;
        }

        private void deleteOption_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            int ma = (int)button.Tag;

            GroupBox groupBox = (GroupBox)button.Parent;
            TextBox textBoxId = groupBox.Controls.Find("id_" + ma, true).FirstOrDefault() as TextBox;

            bUS_OptionProduct.deleteOptionById(Convert.ToInt32(textBoxId.Text.ToString()));
            MessageBox.Show("Xóa thành công");
            this.loadProduct();
            this.loadOption();
        }

        private void updateOptionClick(object sender, EventArgs e)
        {
            Button button = sender as Button;
            int ma = (int)button.Tag;


            GroupBox groupBox = (GroupBox)button.Parent;

            // Lấy ra các controls con trong GroupBox để lấy giá trị
            TextBox textBoxRam = groupBox.Controls.Find("ram_" + ma, true).FirstOrDefault() as TextBox;
            TextBox textBoxStorage = groupBox.Controls.Find("storage_" + ma, true).FirstOrDefault() as TextBox;
            TextBox textBoxQuantity = groupBox.Controls.Find("quantity_" + ma, true).FirstOrDefault() as TextBox;
            TextBox textBoxImportPrice = groupBox.Controls.Find("importPrice_" + ma, true).FirstOrDefault() as TextBox;
            TextBox textBoxSellingPrice = groupBox.Controls.Find("sellingPrice_" + ma, true).FirstOrDefault() as TextBox;
            TextBox textBoxId = groupBox.Controls.Find("id_" + ma, true).FirstOrDefault() as TextBox;

            try
            {
                if (textBoxRam.Text != "" && textBoxStorage.Text != "" && textBoxQuantity.Text != "" && textBoxImportPrice.Text != "" && textBoxSellingPrice.Text != "" && textBoxId.Text != "")
                {
                    string ram = textBoxRam.Text;
                    string storage = textBoxStorage.Text;
                    long quantity = Convert.ToInt64(textBoxQuantity.Text);
                    long importPrice = Convert.ToInt64(textBoxImportPrice.Text);
                    long sellingPrice = Convert.ToInt64(textBoxSellingPrice.Text);
                    int id = Convert.ToInt32(textBoxId.Text);
                    DTO_optionProduct dTO_Option = new DTO_optionProduct(id, ram, storage, quantity, importPrice, sellingPrice, Convert.ToInt64(proId));

                    bUS_OptionProduct.updateOption(dTO_Option, 0);

                    MessageBox.Show("Cập nhật thành công");
                }
                else { MessageBox.Show("Vui lòng điền đầy đủ thông tin!"); }
                this.loadProduct();
                this.loadOption();
            }
            catch
            {
                MessageBox.Show("Số lượng, giá nhập, giá bán phải là số!");
            }
        }

        private void Form_Detail_Product_Load(object sender, EventArgs e)
        {
            this.loadProduct();
            this.loadOption();
        }

        public void loadProduct()
        {
            DataTable dt = bUS_Product.FindProductById(proId);
            ids.Text = dt.Rows[0]["ID"].ToString();
            years.Text = dt.Rows[0]["Năm sx"].ToString();
            nameProduct.Text = dt.Rows[0]["Tên sản phẩm"].ToString();
            warrantly.Text = dt.Rows[0]["Bảo hành"].ToString();
            descrption.Text = dt.Rows[0]["Mô tả"].ToString();
            category.Text = dt.Rows[0]["Loại"].ToString();
            producer.Text = dt.Rows[0]["Hãng"].ToString();
            totalQuantity.Text = dt.Rows[0]["Tồn kho"].ToString();
            pictureBox1.Image = System.Drawing.Image.FromFile(bUS_Image.getByUrl(proId));
        }

        public void loadOption()
        {
            groupBox2.Controls.Clear();
            DataTable dataTable = bUS_OptionProduct.getAllData(Convert.ToInt32(ids.Text));
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                GroupBox groupBox = new GroupBox();

                groupBox.Location = new System.Drawing.Point(17, 20 + i * 120);
                groupBox.Name = "option_" + (i + 1);
                groupBox.Size = new System.Drawing.Size(750, 108);
                groupBox.TabIndex = 0;
                groupBox.TabStop = false;
                groupBox.Text = "Lựa chọn " + (i + 1);

                Label label = new Label();
                label.AutoSize = true;
                label.Location = new System.Drawing.Point(6, 32);
                label.Name = "label" + (i + 10);
                label.Size = new System.Drawing.Size(52, 22);
                label.TabIndex = 56;
                label.Text = "Ram:";
                // 
                // label11
                // 
                Label label1 = new Label();
                label1.AutoSize = true;
                label1.Location = new System.Drawing.Point(143, 32);
                label1.Name = "label" + (i + 11);
                label1.Size = new System.Drawing.Size(78, 22);
                label1.TabIndex = 55;
                label1.Text = "Ổ cứng: ";

                Label label2 = new Label();
                label2.AutoSize = true;
                label2.Location = new System.Drawing.Point(400, 29);
                label2.Name = "label" + (i + 12);
                label2.Size = new System.Drawing.Size(87, 22);
                label2.TabIndex = 54;
                label2.Text = "Giá nhập:";

                Label label3 = new Label();
                label3.AutoSize = true;
                label3.Location = new System.Drawing.Point(520, 29);
                label3.Name = "label" + (i + 13);
                label3.Size = new System.Drawing.Size(78, 22);
                label3.TabIndex = 53;
                label3.Text = "Giá bán:";

                Label label4 = new Label();
                label4.AutoSize = true;
                label4.Location = new System.Drawing.Point(270, 32);
                label4.Name = "label" + (i + 14);
                label4.Size = new System.Drawing.Size(88, 22);
                label4.TabIndex = 52;
                label4.Text = "Số lượng:";

                TextBox textBox1 = new TextBox();
                textBox1.Location = new System.Drawing.Point(6, 60);
                textBox1.Name = "ram_" + (i + 1);
                textBox1.Size = new System.Drawing.Size(88, 30);
                textBox1.TabIndex = 50;
                textBox1.Text = dataTable.Rows[i]["ram"].ToString();

                TextBox textBox3 = new TextBox();
                textBox3.Location = new System.Drawing.Point(143, 60);
                textBox3.Name = "storage_" + (i + 1);
                textBox3.Size = new System.Drawing.Size(88, 30);
                textBox3.TabIndex = 51;
                textBox3.Text = dataTable.Rows[i]["storage"].ToString();

                TextBox textBox4 = new TextBox();
                textBox4.Location = new System.Drawing.Point(270, 60);
                textBox4.Name = "quantity_" + (i + 1);
                textBox4.Size = new System.Drawing.Size(88, 30);
                textBox4.TabIndex = 47;
                textBox4.Text = dataTable.Rows[i]["quantity"].ToString();

                TextBox textBox2 = new TextBox();
                textBox2.Location = new System.Drawing.Point(400, 60);
                textBox2.Name = "importPrice_" + (i + 1);
                textBox2.Size = new System.Drawing.Size(88, 30);
                textBox2.TabIndex = 49;
                textBox2.Text = dataTable.Rows[i]["importPrice"].ToString();

                TextBox textBox = new TextBox();
                textBox.Location = new System.Drawing.Point(520, 60);
                textBox.Name = "sellingPrice_" + (i + 1);
                textBox.Size = new System.Drawing.Size(88, 30);
                textBox.TabIndex = 48;
                textBox.Text = dataTable.Rows[i]["sellingPrice"].ToString();




                Button button = new Button();
                button.Cursor = System.Windows.Forms.Cursors.Hand;
                button.Location = new System.Drawing.Point(620, 60);
                button.Name = "btnDelete";
                button.Size = new System.Drawing.Size(105, 40);
                button.TabIndex = 58;
                button.Text = "Xóa";
                button.UseVisualStyleBackColor = true;
                button.TextImageRelation = TextImageRelation.ImageBeforeText;
                button.Image = Properties.Resources.bin;

                button.Tag = (i + 1);
                button.Click += new System.EventHandler(deleteOption_Click);
                Button button1 = new Button();
                button1.Cursor = System.Windows.Forms.Cursors.Hand;
                button1.Location = new System.Drawing.Point(620, 20);
                button1.Name = "btnUpdate";
                button1.Size = new System.Drawing.Size(105, 40);
                button1.TabIndex = 58;
                button1.Text = "Cập nhật";
                button1.UseVisualStyleBackColor = true;
                button1.Tag = (i + 1);
                button1.Click += new System.EventHandler(updateOptionClick);
                button1.TextImageRelation = TextImageRelation.ImageBeforeText;
                button1.Image = Properties.Resources.edit1;

                TextBox textBox5 = new TextBox();
                textBox5.Location = new System.Drawing.Point(298, 60);
                textBox5.Name = "id_" + (i + 1);
                textBox5.Size = new System.Drawing.Size(98, 30);
                textBox5.TabIndex = 47;
                textBox5.Text = dataTable.Rows[i]["id"].ToString();
                textBox5.Visible = false;

                groupBox.Controls.Add(label);
                groupBox.Controls.Add(label1);
                groupBox.Controls.Add(label2);
                groupBox.Controls.Add(label3);
                groupBox.Controls.Add(label4);
                groupBox.Controls.Add(textBox);
                groupBox.Controls.Add(textBox1);
                groupBox.Controls.Add(textBox2);
                groupBox.Controls.Add(textBox3);
                groupBox.Controls.Add(textBox4);
                groupBox.Controls.Add(textBox5);
                groupBox.Controls.Add(button1);
                groupBox.Controls.Add(button);
                groupBox2.Controls.Add(groupBox);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            form_AddOption form_AddOption = new form_AddOption(proId);
            form_AddOption.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.loadProduct();
            this.loadOption();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(ids.Text.ToString());
            String namePro = nameProduct.Text.ToString();
            String warranty = warrantly.Text.ToString();
            String des = descrption.Text.ToString();
            String nameCate = category.Text.ToString();
            String nameProducer = producer.Text.ToString();
            string path = image.Text;
            String outputPath = @"D:\code\c#\qlmt\QuanLyMayTinh\Images\";


            if ( namePro != "" && warranty != "" && des != "" && nameCate != "" && nameProducer != "" && years.Text.ToString() != "")
            {
                int year = Convert.ToInt32(years.Text.ToString());
                if (path != "")
                {
                    File.Copy(path, Path.Combine(outputPath, Path.GetFileName(image.Text)), true);

                    DTO_Image dTO_Image = new DTO_Image(proId, Path.Combine(outputPath, Path.GetFileName(image.Text)));
                    bUS_Image.update(dTO_Image);
                }
                DTO_product dTO_Product = new DTO_product(id,namePro,year,des,warranty,nameCate,nameProducer);
                bUS_Product.updateProduct(dTO_Product);

                MessageBox.Show("Cập nhật thành công");
            }
            else
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!");
            }

        }

        private void btnImagesProduct_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = ofd.Filter = "Image Files (*.jpg;*.jpeg;*.png) | *.jpg;*.jpeg;*.png";
            ofd.FilterIndex = 1;
            ofd.RestoreDirectory = true;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(ofd.FileName);
                image.Text = ofd.FileName;
            }
        }

    }
}
