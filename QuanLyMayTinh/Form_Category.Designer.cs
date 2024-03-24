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
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1577, 784);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox6);
            this.groupBox3.Controls.Add(this.groupBox5);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(3, 18);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1571, 763);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.dataGridView1);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(3, 113);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(1131, 647);
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
            this.dataGridView1.Location = new System.Drawing.Point(3, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1125, 618);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // groupBox5
            // 
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
            this.groupBox5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(1134, 113);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(434, 647);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Form";
            // 
            // excelExport
            // 
            this.excelExport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.excelExport.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.excelExport.Image = ((System.Drawing.Image)(resources.GetObject("excelExport.Image")));
            this.excelExport.Location = new System.Drawing.Point(112, 567);
            this.excelExport.Name = "excelExport";
            this.excelExport.Size = new System.Drawing.Size(227, 74);
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
            this.deleteCate.Location = new System.Drawing.Point(246, 337);
            this.deleteCate.Name = "deleteCate";
            this.deleteCate.Size = new System.Drawing.Size(154, 68);
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
            this.saveCate.Location = new System.Drawing.Point(47, 451);
            this.saveCate.Name = "saveCate";
            this.saveCate.Size = new System.Drawing.Size(175, 75);
            this.saveCate.TabIndex = 7;
            this.saveCate.Text = "Cập nhập";
            this.saveCate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.saveCate.UseVisualStyleBackColor = true;
            this.saveCate.Click += new System.EventHandler(this.saveCate_Click);
            // 
            // cancel
            // 
            this.cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel.Image = ((System.Drawing.Image)(resources.GetObject("cancel.Image")));
            this.cancel.Location = new System.Drawing.Point(246, 451);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(154, 75);
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
            this.addCate.Location = new System.Drawing.Point(47, 337);
            this.addCate.Name = "addCate";
            this.addCate.Size = new System.Drawing.Size(175, 68);
            this.addCate.TabIndex = 5;
            this.addCate.Text = "Thêm";
            this.addCate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.addCate.UseVisualStyleBackColor = true;
            this.addCate.Click += new System.EventHandler(this.addCate_Click);
            // 
            // ids
            // 
            this.ids.Location = new System.Drawing.Point(38, 29);
            this.ids.Name = "ids";
            this.ids.Size = new System.Drawing.Size(361, 30);
            this.ids.TabIndex = 4;
            this.ids.Visible = false;
            // 
            // names
            // 
            this.names.Location = new System.Drawing.Point(47, 245);
            this.names.Name = "names";
            this.names.Size = new System.Drawing.Size(353, 30);
            this.names.TabIndex = 3;
            // 
            // codes
            // 
            this.codes.Location = new System.Drawing.Point(41, 115);
            this.codes.Name = "codes";
            this.codes.Size = new System.Drawing.Size(359, 30);
            this.codes.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(33, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 22);
            this.label5.TabIndex = 1;
            this.label5.Text = "Tên danh mục";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 22);
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
            this.groupBox4.Location = new System.Drawing.Point(3, 18);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1565, 95);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tìm kiếm";
            // 
            // searchCate
            // 
            this.searchCate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchCate.Image = ((System.Drawing.Image)(resources.GetObject("searchCate.Image")));
            this.searchCate.Location = new System.Drawing.Point(1291, 23);
            this.searchCate.Name = "searchCate";
            this.searchCate.Size = new System.Drawing.Size(179, 66);
            this.searchCate.TabIndex = 4;
            this.searchCate.Text = "Tìm kiếm";
            this.searchCate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.searchCate.UseVisualStyleBackColor = true;
            this.searchCate.Click += new System.EventHandler(this.searchCate_Click);
            // 
            // codeCate
            // 
            this.codeCate.Location = new System.Drawing.Point(959, 31);
            this.codeCate.Name = "codeCate";
            this.codeCate.Size = new System.Drawing.Size(256, 30);
            this.codeCate.TabIndex = 3;
            // 
            // nameCate
            // 
            this.nameCate.Location = new System.Drawing.Point(312, 31);
            this.nameCate.Name = "nameCate";
            this.nameCate.Size = new System.Drawing.Size(256, 30);
            this.nameCate.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(753, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 22);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tìm kiếm theo mã";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tìm kiếm theo tên";
            // 
            // Form_Category
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1577, 784);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form_Category";
            this.Text = "Danh sách danh mục";
            this.Load += new System.EventHandler(this.Form_Category_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox codeCate;
        private System.Windows.Forms.TextBox nameCate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
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
    }
}

