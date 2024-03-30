namespace QuanLyMayTinh
{
    partial class Form_Producer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Producer));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.names = new System.Windows.Forms.TextBox();
            this.export_excel = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.saveProducer = new System.Windows.Forms.Button();
            this.deleteProducer = new System.Windows.Forms.Button();
            this.addProducer = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.codes = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ids = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.searchProducer = new System.Windows.Forms.Button();
            this.code_producer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.name_producer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1568, 814);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Controls.Add(this.groupBox3);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(3, 18);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1562, 793);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.groupBox2);
            this.groupBox5.Controls.Add(this.groupBox6);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(3, 127);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(1556, 663);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 26);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1125, 634);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hiển thị";
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
            this.dataGridView1.Size = new System.Drawing.Size(1119, 605);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.names);
            this.groupBox6.Controls.Add(this.export_excel);
            this.groupBox6.Controls.Add(this.cancel);
            this.groupBox6.Controls.Add(this.saveProducer);
            this.groupBox6.Controls.Add(this.deleteProducer);
            this.groupBox6.Controls.Add(this.addProducer);
            this.groupBox6.Controls.Add(this.label4);
            this.groupBox6.Controls.Add(this.codes);
            this.groupBox6.Controls.Add(this.label3);
            this.groupBox6.Controls.Add(this.ids);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(1128, 26);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(425, 634);
            this.groupBox6.TabIndex = 3;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Form";
            // 
            // names
            // 
            this.names.Location = new System.Drawing.Point(32, 274);
            this.names.Name = "names";
            this.names.Size = new System.Drawing.Size(362, 30);
            this.names.TabIndex = 11;
            // 
            // export_excel
            // 
            this.export_excel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.export_excel.Image = ((System.Drawing.Image)(resources.GetObject("export_excel.Image")));
            this.export_excel.Location = new System.Drawing.Point(139, 569);
            this.export_excel.Name = "export_excel";
            this.export_excel.Size = new System.Drawing.Size(200, 66);
            this.export_excel.TabIndex = 9;
            this.export_excel.Text = "Xuất Excel";
            this.export_excel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.export_excel.UseVisualStyleBackColor = true;
            this.export_excel.Click += new System.EventHandler(this.export_excel_Click);
            // 
            // cancel
            // 
            this.cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancel.Image = ((System.Drawing.Image)(resources.GetObject("cancel.Image")));
            this.cancel.Location = new System.Drawing.Point(250, 469);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(153, 62);
            this.cancel.TabIndex = 8;
            this.cancel.Text = "Hủy";
            this.cancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // saveProducer
            // 
            this.saveProducer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveProducer.Image = ((System.Drawing.Image)(resources.GetObject("saveProducer.Image")));
            this.saveProducer.Location = new System.Drawing.Point(35, 459);
            this.saveProducer.Name = "saveProducer";
            this.saveProducer.Size = new System.Drawing.Size(174, 72);
            this.saveProducer.TabIndex = 7;
            this.saveProducer.Text = "Cập nhập";
            this.saveProducer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.saveProducer.UseVisualStyleBackColor = true;
            this.saveProducer.Click += new System.EventHandler(this.saveProducer_Click);
            // 
            // deleteProducer
            // 
            this.deleteProducer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteProducer.Image = ((System.Drawing.Image)(resources.GetObject("deleteProducer.Image")));
            this.deleteProducer.Location = new System.Drawing.Point(250, 351);
            this.deleteProducer.Name = "deleteProducer";
            this.deleteProducer.Size = new System.Drawing.Size(153, 66);
            this.deleteProducer.TabIndex = 6;
            this.deleteProducer.Text = "Xóa";
            this.deleteProducer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.deleteProducer.UseVisualStyleBackColor = true;
            this.deleteProducer.Click += new System.EventHandler(this.deleteProducer_Click);
            // 
            // addProducer
            // 
            this.addProducer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addProducer.Image = ((System.Drawing.Image)(resources.GetObject("addProducer.Image")));
            this.addProducer.Location = new System.Drawing.Point(35, 351);
            this.addProducer.Name = "addProducer";
            this.addProducer.Size = new System.Drawing.Size(174, 66);
            this.addProducer.TabIndex = 4;
            this.addProducer.Text = "Thêm";
            this.addProducer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.addProducer.UseVisualStyleBackColor = true;
            this.addProducer.Click += new System.EventHandler(this.addProducer_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tên nhà sản xuất";
            // 
            // codes
            // 
            this.codes.Location = new System.Drawing.Point(32, 153);
            this.codes.Name = "codes";
            this.codes.Size = new System.Drawing.Size(360, 30);
            this.codes.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 22);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mã nhà sản xuất";
            // 
            // ids
            // 
            this.ids.Location = new System.Drawing.Point(34, 42);
            this.ids.Name = "ids";
            this.ids.Size = new System.Drawing.Size(360, 30);
            this.ids.TabIndex = 0;
            this.ids.Visible = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.searchProducer);
            this.groupBox3.Controls.Add(this.code_producer);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.name_producer);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(3, 18);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1556, 109);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tìm kiếm";
            // 
            // searchProducer
            // 
            this.searchProducer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchProducer.Image = ((System.Drawing.Image)(resources.GetObject("searchProducer.Image")));
            this.searchProducer.Location = new System.Drawing.Point(1174, 29);
            this.searchProducer.Name = "searchProducer";
            this.searchProducer.Size = new System.Drawing.Size(196, 68);
            this.searchProducer.TabIndex = 4;
            this.searchProducer.Text = "Tìm kiếm";
            this.searchProducer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.searchProducer.UseVisualStyleBackColor = true;
            this.searchProducer.Click += new System.EventHandler(this.searchProducer_Click);
            // 
            // code_producer
            // 
            this.code_producer.Location = new System.Drawing.Point(805, 34);
            this.code_producer.Name = "code_producer";
            this.code_producer.Size = new System.Drawing.Size(233, 30);
            this.code_producer.TabIndex = 3;
            this.code_producer.Click += new System.EventHandler(this.code_producer_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(634, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tìm kiếm theo mã";
            // 
            // name_producer
            // 
            this.name_producer.Location = new System.Drawing.Point(263, 34);
            this.name_producer.Name = "name_producer";
            this.name_producer.Size = new System.Drawing.Size(230, 30);
            this.name_producer.TabIndex = 1;
            this.name_producer.Click += new System.EventHandler(this.name_producer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tìm kiếm theo tên";
            // 
            // Form_Producer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1568, 814);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form_Producer";
            this.Text = "Danh sách nhà sản xuất";
            this.Load += new System.EventHandler(this.Form_Producer_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox name_producer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox code_producer;
        private System.Windows.Forms.Button searchProducer;
        private System.Windows.Forms.TextBox ids;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox codes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button export_excel;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button saveProducer;
        private System.Windows.Forms.Button deleteProducer;
        private System.Windows.Forms.Button addProducer;
        private System.Windows.Forms.TextBox names;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}