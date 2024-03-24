namespace QuanLyMayTinh
{
    partial class Form_AddProduct
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_AddProduct));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ids = new System.Windows.Forms.TextBox();
            this.namep = new System.Windows.Forms.TextBox();
            this.years = new System.Windows.Forms.TextBox();
            this.wranntlys = new System.Windows.Forms.TextBox();
            this.quantity = new System.Windows.Forms.TextBox();
            this.notes = new System.Windows.Forms.TextBox();
            this.comboCate = new System.Windows.Forms.ComboBox();
            this.comboPro = new System.Windows.Forms.ComboBox();
            this.btnsAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.picture = new System.Windows.Forms.PictureBox();
            this.image = new System.Windows.Forms.TextBox();
            this.btnImagesProduct = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1521, 1055);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnImagesProduct);
            this.groupBox2.Controls.Add(this.image);
            this.groupBox2.Controls.Add(this.picture);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btnsAdd);
            this.groupBox2.Controls.Add(this.comboPro);
            this.groupBox2.Controls.Add(this.comboCate);
            this.groupBox2.Controls.Add(this.notes);
            this.groupBox2.Controls.Add(this.quantity);
            this.groupBox2.Controls.Add(this.wranntlys);
            this.groupBox2.Controls.Add(this.years);
            this.groupBox2.Controls.Add(this.namep);
            this.groupBox2.Controls.Add(this.ids);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(610, 114);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(919, 802);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(444, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thêm sản phẩm";
            // 
            // ids
            // 
            this.ids.Location = new System.Drawing.Point(390, 63);
            this.ids.Name = "ids";
            this.ids.Size = new System.Drawing.Size(321, 30);
            this.ids.TabIndex = 1;
            this.ids.Visible = false;
            // 
            // namep
            // 
            this.namep.Location = new System.Drawing.Point(392, 99);
            this.namep.Name = "namep";
            this.namep.Size = new System.Drawing.Size(319, 30);
            this.namep.TabIndex = 2;
            // 
            // years
            // 
            this.years.Location = new System.Drawing.Point(390, 162);
            this.years.Name = "years";
            this.years.Size = new System.Drawing.Size(319, 30);
            this.years.TabIndex = 3;
            // 
            // wranntlys
            // 
            this.wranntlys.Location = new System.Drawing.Point(390, 229);
            this.wranntlys.Name = "wranntlys";
            this.wranntlys.Size = new System.Drawing.Size(321, 30);
            this.wranntlys.TabIndex = 4;
            // 
            // quantity
            // 
            this.quantity.Location = new System.Drawing.Point(390, 295);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(319, 30);
            this.quantity.TabIndex = 5;
            // 
            // notes
            // 
            this.notes.Location = new System.Drawing.Point(390, 566);
            this.notes.Multiline = true;
            this.notes.Name = "notes";
            this.notes.Size = new System.Drawing.Size(319, 113);
            this.notes.TabIndex = 6;
            // 
            // comboCate
            // 
            this.comboCate.FormattingEnabled = true;
            this.comboCate.Location = new System.Drawing.Point(390, 363);
            this.comboCate.Name = "comboCate";
            this.comboCate.Size = new System.Drawing.Size(321, 30);
            this.comboCate.TabIndex = 7;
            // 
            // comboPro
            // 
            this.comboPro.FormattingEnabled = true;
            this.comboPro.Location = new System.Drawing.Point(390, 433);
            this.comboPro.Name = "comboPro";
            this.comboPro.Size = new System.Drawing.Size(321, 30);
            this.comboPro.TabIndex = 8;
            // 
            // btnsAdd
            // 
            this.btnsAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnsAdd.Image")));
            this.btnsAdd.Location = new System.Drawing.Point(408, 704);
            this.btnsAdd.Name = "btnsAdd";
            this.btnsAdd.Size = new System.Drawing.Size(147, 75);
            this.btnsAdd.TabIndex = 9;
            this.btnsAdd.Text = "Thêm";
            this.btnsAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnsAdd.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(247, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 22);
            this.label2.TabIndex = 11;
            this.label2.Text = "Tên sản phẩm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(250, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 22);
            this.label3.TabIndex = 12;
            this.label3.Text = "Năm sản xuất";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(250, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 22);
            this.label4.TabIndex = 13;
            this.label4.Text = "Bảo hành";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(247, 298);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 22);
            this.label5.TabIndex = 14;
            this.label5.Text = "Số lượng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(247, 371);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 22);
            this.label6.TabIndex = 15;
            this.label6.Text = "Danh mục";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(247, 441);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 22);
            this.label7.TabIndex = 16;
            this.label7.Text = "Nhà sản xuất";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(250, 569);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 22);
            this.label8.TabIndex = 17;
            this.label8.Text = "Mô tả";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(250, 501);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 22);
            this.label9.TabIndex = 18;
            this.label9.Text = "Hình ảnh";
            // 
            // picture
            // 
            this.picture.Location = new System.Drawing.Point(18, 66);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(221, 211);
            this.picture.TabIndex = 20;
            this.picture.TabStop = false;
            // 
            // image
            // 
            this.image.Location = new System.Drawing.Point(393, 499);
            this.image.Name = "image";
            this.image.Size = new System.Drawing.Size(315, 30);
            this.image.TabIndex = 21;
            // 
            // btnImagesProduct
            // 
            this.btnImagesProduct.Location = new System.Drawing.Point(743, 498);
            this.btnImagesProduct.Name = "btnImagesProduct";
            this.btnImagesProduct.Size = new System.Drawing.Size(101, 31);
            this.btnImagesProduct.TabIndex = 22;
            this.btnImagesProduct.Text = "Chọn tệp";
            this.btnImagesProduct.UseVisualStyleBackColor = true;
            this.btnImagesProduct.Click += new System.EventHandler(this.btnImagesProduct_Click);
            // 
            // Form_AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1521, 1055);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form_AddProduct";
            this.Text = "Form_AddProduct";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox quantity;
        private System.Windows.Forms.TextBox wranntlys;
        private System.Windows.Forms.TextBox years;
        private System.Windows.Forms.TextBox namep;
        private System.Windows.Forms.TextBox ids;
        private System.Windows.Forms.Button btnsAdd;
        private System.Windows.Forms.ComboBox comboPro;
        private System.Windows.Forms.ComboBox comboCate;
        private System.Windows.Forms.TextBox notes;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnImagesProduct;
        private System.Windows.Forms.TextBox image;
        private System.Windows.Forms.PictureBox picture;
    }
}