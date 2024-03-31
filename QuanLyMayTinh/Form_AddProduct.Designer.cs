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
            this.btnImagesProduct = new System.Windows.Forms.Button();
            this.image = new System.Windows.Forms.TextBox();
            this.picture = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnsAdd = new System.Windows.Forms.Button();
            this.cbo_Producer = new System.Windows.Forms.ComboBox();
            this.cbo_category = new System.Windows.Forms.ComboBox();
            this.descrption = new System.Windows.Forms.TextBox();
            this.warrantly = new System.Windows.Forms.TextBox();
            this.years = new System.Windows.Forms.TextBox();
            this.nameProduct = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
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
            this.groupBox1.Size = new System.Drawing.Size(1924, 1055);
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
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btnsAdd);
            this.groupBox2.Controls.Add(this.cbo_Producer);
            this.groupBox2.Controls.Add(this.cbo_category);
            this.groupBox2.Controls.Add(this.descrption);
            this.groupBox2.Controls.Add(this.warrantly);
            this.groupBox2.Controls.Add(this.years);
            this.groupBox2.Controls.Add(this.nameProduct);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(610, 114);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(919, 802);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // btnImagesProduct
            // 
            this.btnImagesProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImagesProduct.Location = new System.Drawing.Point(743, 420);
            this.btnImagesProduct.Name = "btnImagesProduct";
            this.btnImagesProduct.Size = new System.Drawing.Size(101, 31);
            this.btnImagesProduct.TabIndex = 22;
            this.btnImagesProduct.Text = "Chọn tệp";
            this.btnImagesProduct.UseVisualStyleBackColor = true;
            this.btnImagesProduct.Click += new System.EventHandler(this.btnImagesProduct_Click);
            // 
            // image
            // 
            this.image.Location = new System.Drawing.Point(393, 421);
            this.image.Name = "image";
            this.image.Size = new System.Drawing.Size(315, 30);
            this.image.TabIndex = 21;
            // 
            // picture
            // 
            this.picture.Location = new System.Drawing.Point(18, 66);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(221, 211);
            this.picture.TabIndex = 20;
            this.picture.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(250, 423);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 22);
            this.label9.TabIndex = 18;
            this.label9.Text = "Hình ảnh";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(250, 491);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 22);
            this.label8.TabIndex = 17;
            this.label8.Text = "Mô tả";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(247, 363);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 22);
            this.label7.TabIndex = 16;
            this.label7.Text = "Nhà sản xuất";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(247, 293);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 22);
            this.label6.TabIndex = 15;
            this.label6.Text = "Danh mục";
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(250, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 22);
            this.label3.TabIndex = 12;
            this.label3.Text = "Năm sản xuất";
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
            // btnsAdd
            // 
            this.btnsAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnsAdd.Image")));
            this.btnsAdd.Location = new System.Drawing.Point(408, 626);
            this.btnsAdd.Name = "btnsAdd";
            this.btnsAdd.Size = new System.Drawing.Size(147, 75);
            this.btnsAdd.TabIndex = 9;
            this.btnsAdd.Text = "Thêm";
            this.btnsAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnsAdd.UseVisualStyleBackColor = true;
            this.btnsAdd.Click += new System.EventHandler(this.btnsAdd_Click);
            // 
            // cbo_Producer
            // 
            this.cbo_Producer.FormattingEnabled = true;
            this.cbo_Producer.Location = new System.Drawing.Point(390, 355);
            this.cbo_Producer.Name = "cbo_Producer";
            this.cbo_Producer.Size = new System.Drawing.Size(321, 30);
            this.cbo_Producer.TabIndex = 8;
            // 
            // cbo_category
            // 
            this.cbo_category.FormattingEnabled = true;
            this.cbo_category.Location = new System.Drawing.Point(390, 285);
            this.cbo_category.Name = "cbo_category";
            this.cbo_category.Size = new System.Drawing.Size(321, 30);
            this.cbo_category.TabIndex = 7;
            // 
            // descrption
            // 
            this.descrption.Location = new System.Drawing.Point(390, 488);
            this.descrption.Multiline = true;
            this.descrption.Name = "descrption";
            this.descrption.Size = new System.Drawing.Size(319, 113);
            this.descrption.TabIndex = 6;
            // 
            // warrantly
            // 
            this.warrantly.Location = new System.Drawing.Point(390, 229);
            this.warrantly.Name = "warrantly";
            this.warrantly.Size = new System.Drawing.Size(321, 30);
            this.warrantly.TabIndex = 4;
            // 
            // years
            // 
            this.years.Location = new System.Drawing.Point(390, 162);
            this.years.Name = "years";
            this.years.Size = new System.Drawing.Size(319, 30);
            this.years.TabIndex = 3;
            // 
            // nameProduct
            // 
            this.nameProduct.Location = new System.Drawing.Point(392, 99);
            this.nameProduct.Name = "nameProduct";
            this.nameProduct.Size = new System.Drawing.Size(319, 30);
            this.nameProduct.TabIndex = 2;
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
            // Form_AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form_AddProduct";
            this.Text = "Form_AddProduct";
            this.Load += new System.EventHandler(this.Form_AddProduct_Load);
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
        private System.Windows.Forms.TextBox warrantly;
        private System.Windows.Forms.TextBox years;
        private System.Windows.Forms.TextBox nameProduct;
        private System.Windows.Forms.Button btnsAdd;
        private System.Windows.Forms.ComboBox cbo_Producer;
        private System.Windows.Forms.ComboBox cbo_category;
        private System.Windows.Forms.TextBox descrption;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnImagesProduct;
        private System.Windows.Forms.TextBox image;
        private System.Windows.Forms.PictureBox picture;
    }
}