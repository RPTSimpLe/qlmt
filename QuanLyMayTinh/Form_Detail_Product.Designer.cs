namespace QuanLyMayTinh
{
    partial class Form_Detail_Product
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
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.descrption = new System.Windows.Forms.TextBox();
            this.warrantly = new System.Windows.Forms.TextBox();
            this.years = new System.Windows.Forms.TextBox();
            this.nameProduct = new System.Windows.Forms.TextBox();
            this.ids = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.totalQuantity = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.category = new System.Windows.Forms.ComboBox();
            this.producer = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(258, 301);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 22);
            this.label7.TabIndex = 55;
            this.label7.Text = "Nhà sản xuất";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(259, 236);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 22);
            this.label6.TabIndex = 54;
            this.label6.Text = "Danh mục";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(259, 371);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 22);
            this.label5.TabIndex = 53;
            this.label5.Text = "Mô tả";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(259, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 22);
            this.label4.TabIndex = 52;
            this.label4.Text = "Bảo hành";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(259, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 22);
            this.label3.TabIndex = 51;
            this.label3.Text = "Năm sản xuất";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(259, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 22);
            this.label2.TabIndex = 50;
            this.label2.Text = "Tên sản phẩm";
            // 
            // descrption
            // 
            this.descrption.Location = new System.Drawing.Point(387, 357);
            this.descrption.Multiline = true;
            this.descrption.Name = "descrption";
            this.descrption.Size = new System.Drawing.Size(327, 194);
            this.descrption.TabIndex = 49;
            // 
            // warrantly
            // 
            this.warrantly.Location = new System.Drawing.Point(387, 133);
            this.warrantly.Name = "warrantly";
            this.warrantly.Size = new System.Drawing.Size(327, 30);
            this.warrantly.TabIndex = 48;
            // 
            // years
            // 
            this.years.Location = new System.Drawing.Point(387, 70);
            this.years.Name = "years";
            this.years.Size = new System.Drawing.Size(327, 30);
            this.years.TabIndex = 47;
            // 
            // nameProduct
            // 
            this.nameProduct.Location = new System.Drawing.Point(387, 9);
            this.nameProduct.Name = "nameProduct";
            this.nameProduct.Size = new System.Drawing.Size(322, 30);
            this.nameProduct.TabIndex = 46;
            // 
            // ids
            // 
            this.ids.Location = new System.Drawing.Point(387, -15);
            this.ids.Name = "ids";
            this.ids.Size = new System.Drawing.Size(303, 30);
            this.ids.TabIndex = 45;
            this.ids.Visible = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(262, 591);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(117, 58);
            this.btnUpdate.TabIndex = 58;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(257, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 22);
            this.label1.TabIndex = 60;
            this.label1.Text = "Tổng số lượng";
            // 
            // totalQuantity
            // 
            this.totalQuantity.Location = new System.Drawing.Point(387, 185);
            this.totalQuantity.Name = "totalQuantity";
            this.totalQuantity.Size = new System.Drawing.Size(327, 30);
            this.totalQuantity.TabIndex = 59;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.producer);
            this.groupBox1.Controls.Add(this.category);
            this.groupBox1.Controls.Add(this.totalQuantity);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ids);
            this.groupBox1.Controls.Add(this.nameProduct);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.years);
            this.groupBox1.Controls.Add(this.warrantly);
            this.groupBox1.Controls.Add(this.descrption);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(724, 680);
            this.groupBox1.TabIndex = 61;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sản phẩm";
            // 
            // groupBox2
            // 
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(764, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(774, 671);
            this.groupBox2.TabIndex = 62;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tùy chọn";
            // 
            // category
            // 
            this.category.FormattingEnabled = true;
            this.category.Location = new System.Drawing.Point(389, 233);
            this.category.Name = "category";
            this.category.Size = new System.Drawing.Size(324, 30);
            this.category.TabIndex = 61;
            // 
            // producer
            // 
            this.producer.FormattingEnabled = true;
            this.producer.Location = new System.Drawing.Point(392, 293);
            this.producer.Name = "producer";
            this.producer.Size = new System.Drawing.Size(321, 30);
            this.producer.TabIndex = 62;
            // 
            // Form_Detail_Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1550, 704);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form_Detail_Product";
            this.Text = "Chi tiết sản phẩm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form_Detail_Product_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox descrption;
        private System.Windows.Forms.TextBox warrantly;
        private System.Windows.Forms.TextBox years;
        private System.Windows.Forms.TextBox nameProduct;
        private System.Windows.Forms.TextBox ids;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox totalQuantity;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox producer;
        private System.Windows.Forms.ComboBox category;
    }
}