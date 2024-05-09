namespace QuanLyMayTinh
{
    partial class Form_Bill
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Bill));
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_idBills = new System.Windows.Forms.TextBox();
            this.txt_NameCus = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.export_excel = new System.Windows.Forms.Button();
            this.saveBill = new System.Windows.Forms.Button();
            this.searchBill = new System.Windows.Forms.Button();
            this.deleteBill = new System.Windows.Forms.Button();
            this.txt_IdBill = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.dataGridView1);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(0, 220);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(1791, 835);
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
            this.dataGridView1.Size = new System.Drawing.Size(1785, 806);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_idBills);
            this.groupBox2.Controls.Add(this.txt_NameCus);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.export_excel);
            this.groupBox2.Controls.Add(this.saveBill);
            this.groupBox2.Controls.Add(this.searchBill);
            this.groupBox2.Controls.Add(this.deleteBill);
            this.groupBox2.Controls.Add(this.txt_IdBill);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1791, 220);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm kiếm";
            // 
            // txt_idBills
            // 
            this.txt_idBills.Location = new System.Drawing.Point(731, 129);
            this.txt_idBills.Name = "txt_idBills";
            this.txt_idBills.Size = new System.Drawing.Size(322, 30);
            this.txt_idBills.TabIndex = 28;
            this.txt_idBills.Visible = false;
            // 
            // txt_NameCus
            // 
            this.txt_NameCus.Location = new System.Drawing.Point(196, 124);
            this.txt_NameCus.Name = "txt_NameCus";
            this.txt_NameCus.Size = new System.Drawing.Size(322, 30);
            this.txt_NameCus.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 22);
            this.label3.TabIndex = 26;
            this.label3.Text = "Tên Khách hàng:";
            // 
            // export_excel
            // 
            this.export_excel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.export_excel.Image = global::QuanLyMayTinh.Properties.Resources.excel;
            this.export_excel.Location = new System.Drawing.Point(1462, 29);
            this.export_excel.Name = "export_excel";
            this.export_excel.Size = new System.Drawing.Size(170, 72);
            this.export_excel.TabIndex = 23;
            this.export_excel.Text = "Xuất Excel";
            this.export_excel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.export_excel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.export_excel.UseVisualStyleBackColor = true;
            this.export_excel.Click += new System.EventHandler(this.export_excel_Click);
            // 
            // saveBill
            // 
            this.saveBill.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveBill.Image = ((System.Drawing.Image)(resources.GetObject("saveBill.Image")));
            this.saveBill.Location = new System.Drawing.Point(1224, 115);
            this.saveBill.Name = "saveBill";
            this.saveBill.Size = new System.Drawing.Size(168, 76);
            this.saveBill.TabIndex = 21;
            this.saveBill.Text = "Chi tiết";
            this.saveBill.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.saveBill.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.saveBill.UseVisualStyleBackColor = true;
            this.saveBill.Click += new System.EventHandler(this.saveBill_Click);
            // 
            // searchBill
            // 
            this.searchBill.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchBill.Image = global::QuanLyMayTinh.Properties.Resources.search__1_;
            this.searchBill.Location = new System.Drawing.Point(1224, 29);
            this.searchBill.Name = "searchBill";
            this.searchBill.Size = new System.Drawing.Size(168, 72);
            this.searchBill.TabIndex = 2;
            this.searchBill.Text = "Tìm kiếm";
            this.searchBill.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.searchBill.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.searchBill.UseVisualStyleBackColor = true;
            this.searchBill.Click += new System.EventHandler(this.searchBill_Click);
            // 
            // deleteBill
            // 
            this.deleteBill.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteBill.Image = global::QuanLyMayTinh.Properties.Resources.delete__1_;
            this.deleteBill.Location = new System.Drawing.Point(1462, 115);
            this.deleteBill.Name = "deleteBill";
            this.deleteBill.Size = new System.Drawing.Size(170, 75);
            this.deleteBill.TabIndex = 20;
            this.deleteBill.Text = "Xóa";
            this.deleteBill.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.deleteBill.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.deleteBill.UseVisualStyleBackColor = true;
            this.deleteBill.Click += new System.EventHandler(this.deleteBill_Click);
            // 
            // txt_IdBill
            // 
            this.txt_IdBill.Location = new System.Drawing.Point(196, 49);
            this.txt_IdBill.Name = "txt_IdBill";
            this.txt_IdBill.Size = new System.Drawing.Size(322, 30);
            this.txt_IdBill.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã hóa đơn: ";
            // 
            // Form_Bill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1791, 1055);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form_Bill";
            this.Text = "                Hóa đơn";
            this.Load += new System.EventHandler(this.Form_Bill_Load);
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button export_excel;
        private System.Windows.Forms.Button saveBill;
        private System.Windows.Forms.Button searchBill;
        private System.Windows.Forms.Button deleteBill;
        private System.Windows.Forms.TextBox txt_IdBill;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_idBills;
        private System.Windows.Forms.TextBox txt_NameCus;
        private System.Windows.Forms.Label label3;
    }
}