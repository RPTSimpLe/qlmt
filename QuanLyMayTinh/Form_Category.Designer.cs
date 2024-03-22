namespace QuanLyMayTinh
{
    partial class Form_Category
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Category));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.import_excel = new System.Windows.Forms.Button();
            this.excelExport = new System.Windows.Forms.Button();
            this.deleteCate = new System.Windows.Forms.Button();
            this.saveCate = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.addCate = new System.Windows.Forms.Button();
            this.ids = new System.Windows.Forms.TextBox();
            this.names = new System.Windows.Forms.TextBox();
            this.codes = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.searchCate = new System.Windows.Forms.Button();
            this.codeCate = new System.Windows.Forms.TextBox();
            this.nameCate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(1338, 501);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox6);
            this.groupBox3.Controls.Add(this.groupBox5);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(3, 99);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Size = new System.Drawing.Size(1332, 398);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.dataGridView1);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox6.Location = new System.Drawing.Point(3, 142);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox6.Size = new System.Drawing.Size(838, 252);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Hiển thị";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 23);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(832, 225);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.import_excel);
            this.groupBox5.Controls.Add(this.excelExport);
            this.groupBox5.Controls.Add(this.deleteCate);
            this.groupBox5.Controls.Add(this.saveCate);
            this.groupBox5.Controls.Add(this.cancel);
            this.groupBox5.Controls.Add(this.addCate);
            this.groupBox5.Controls.Add(this.ids);
            this.groupBox5.Controls.Add(this.names);
            this.groupBox5.Controls.Add(this.codes);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox5.Location = new System.Drawing.Point(841, 142);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox5.Size = new System.Drawing.Size(488, 252);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Form";
            // 
            // import_excel
            // 
            this.import_excel.Location = new System.Drawing.Point(277, 708);
            this.import_excel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.import_excel.Name = "import_excel";
            this.import_excel.Size = new System.Drawing.Size(161, 82);
            this.import_excel.TabIndex = 10;
            this.import_excel.Text = "Nhập Excel";
            this.import_excel.UseVisualStyleBackColor = true;
            this.import_excel.Click += new System.EventHandler(this.import_excel_Click);
            // 
            // excelExport
            // 
            this.excelExport.Image = ((System.Drawing.Image)(resources.GetObject("excelExport.Image")));
            this.excelExport.Location = new System.Drawing.Point(53, 698);
            this.excelExport.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.excelExport.Name = "excelExport";
            this.excelExport.Size = new System.Drawing.Size(161, 92);
            this.excelExport.TabIndex = 9;
            this.excelExport.Text = "Xuất Excel";
            this.excelExport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.excelExport.UseVisualStyleBackColor = true;
            this.excelExport.Click += new System.EventHandler(this.excelExport_Click);
            // 
            // deleteCate
            // 
            this.deleteCate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteCate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteCate.Image = ((System.Drawing.Image)(resources.GetObject("deleteCate.Image")));
            this.deleteCate.Location = new System.Drawing.Point(277, 421);
            this.deleteCate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.deleteCate.Name = "deleteCate";
            this.deleteCate.Size = new System.Drawing.Size(161, 85);
            this.deleteCate.TabIndex = 8;
            this.deleteCate.Text = "Xóa";
            this.deleteCate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.deleteCate.UseVisualStyleBackColor = true;
            this.deleteCate.Click += new System.EventHandler(this.deleteCate_Click);
            // 
            // saveCate
            // 
            this.saveCate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveCate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveCate.Image = ((System.Drawing.Image)(resources.GetObject("saveCate.Image")));
            this.saveCate.Location = new System.Drawing.Point(53, 575);
            this.saveCate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.saveCate.Name = "saveCate";
            this.saveCate.Size = new System.Drawing.Size(161, 82);
            this.saveCate.TabIndex = 7;
            this.saveCate.Text = "Lưu";
            this.saveCate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.saveCate.UseVisualStyleBackColor = true;
            this.saveCate.Click += new System.EventHandler(this.saveCate_Click);
            // 
            // cancel
            // 
            this.cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel.Image = ((System.Drawing.Image)(resources.GetObject("cancel.Image")));
            this.cancel.Location = new System.Drawing.Point(277, 572);
            this.cancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(161, 85);
            this.cancel.TabIndex = 6;
            this.cancel.Text = "Hủy";
            this.cancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // addCate
            // 
            this.addCate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addCate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCate.Image = ((System.Drawing.Image)(resources.GetObject("addCate.Image")));
            this.addCate.Location = new System.Drawing.Point(53, 421);
            this.addCate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addCate.Name = "addCate";
            this.addCate.Size = new System.Drawing.Size(161, 85);
            this.addCate.TabIndex = 5;
            this.addCate.Text = "Thêm";
            this.addCate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.addCate.UseVisualStyleBackColor = true;
            this.addCate.Click += new System.EventHandler(this.addCate_Click);
            // 
            // ids
            // 
            this.ids.Location = new System.Drawing.Point(43, 36);
            this.ids.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ids.Name = "ids";
            this.ids.Size = new System.Drawing.Size(406, 26);
            this.ids.TabIndex = 4;
            this.ids.Visible = false;
            // 
            // names
            // 
            this.names.Location = new System.Drawing.Point(53, 306);
            this.names.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.names.Name = "names";
            this.names.Size = new System.Drawing.Size(397, 26);
            this.names.TabIndex = 3;
            // 
            // codes
            // 
            this.codes.Location = new System.Drawing.Point(46, 144);
            this.codes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.codes.Name = "codes";
            this.codes.Size = new System.Drawing.Size(403, 26);
            this.codes.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(37, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 27);
            this.label5.TabIndex = 1;
            this.label5.Text = "Tên danh mục";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(37, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 27);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mã danh mục";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.searchCate);
            this.groupBox4.Controls.Add(this.codeCate);
            this.groupBox4.Controls.Add(this.nameCate);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(3, 23);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox4.Size = new System.Drawing.Size(1326, 119);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tìm kiếm";
            // 
            // searchCate
            // 
            this.searchCate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchCate.Image = ((System.Drawing.Image)(resources.GetObject("searchCate.Image")));
            this.searchCate.Location = new System.Drawing.Point(1576, 21);
            this.searchCate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.searchCate.Name = "searchCate";
            this.searchCate.Size = new System.Drawing.Size(201, 82);
            this.searchCate.TabIndex = 4;
            this.searchCate.Text = "Tìm kiếm";
            this.searchCate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.searchCate.UseVisualStyleBackColor = true;
            this.searchCate.Click += new System.EventHandler(this.searchCate_Click);
            // 
            // codeCate
            // 
            this.codeCate.Location = new System.Drawing.Point(1079, 39);
            this.codeCate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.codeCate.Name = "codeCate";
            this.codeCate.Size = new System.Drawing.Size(288, 35);
            this.codeCate.TabIndex = 3;
            // 
            // nameCate
            // 
            this.nameCate.Location = new System.Drawing.Point(351, 39);
            this.nameCate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nameCate.Name = "nameCate";
            this.nameCate.Size = new System.Drawing.Size(288, 35);
            this.nameCate.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(847, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 27);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tìm kiếm theo mã";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(108, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 27);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tìm kiếm theo tên";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(3, 23);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(1332, 76);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1050, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh sách danh mục";
            // 
            // Form_Category
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1338, 501);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form_Category";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form_Category_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox codeCate;
        private System.Windows.Forms.TextBox nameCate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button searchCate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ids;
        private System.Windows.Forms.TextBox names;
        private System.Windows.Forms.TextBox codes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button deleteCate;
        private System.Windows.Forms.Button saveCate;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button addCate;
        private System.Windows.Forms.Button excelExport;
        private System.Windows.Forms.Button import_excel;
    }
}

