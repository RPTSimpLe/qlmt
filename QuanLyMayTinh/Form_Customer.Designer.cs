namespace QuanLyMayTinh
{
    partial class Form_Customer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Customer));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.cancel = new System.Windows.Forms.Button();
            this.saveUser = new System.Windows.Forms.Button();
            this.deleteUser = new System.Windows.Forms.Button();
            this.addUser = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.address = new System.Windows.Forms.TextBox();
            this.ids = new System.Windows.Forms.TextBox();
            this.phones = new System.Windows.Forms.TextBox();
            this.names = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.export_excel = new System.Windows.Forms.Button();
            this.searchUser = new System.Windows.Forms.Button();
            this.nameCus = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1924, 1055);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(3, 124);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1918, 928);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.groupBox6);
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(3, 18);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1912, 907);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.dataGridView1);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(3, 18);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(1398, 886);
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
            this.dataGridView1.Size = new System.Drawing.Size(1392, 857);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.cancel);
            this.groupBox5.Controls.Add(this.saveUser);
            this.groupBox5.Controls.Add(this.deleteUser);
            this.groupBox5.Controls.Add(this.addUser);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.address);
            this.groupBox5.Controls.Add(this.ids);
            this.groupBox5.Controls.Add(this.phones);
            this.groupBox5.Controls.Add(this.names);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(1401, 18);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(508, 886);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Form";
            // 
            // cancel
            // 
            this.cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancel.Image = ((System.Drawing.Image)(resources.GetObject("cancel.Image")));
            this.cancel.Location = new System.Drawing.Point(281, 389);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(170, 76);
            this.cancel.TabIndex = 22;
            this.cancel.Text = "Hủy";
            this.cancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cancel.UseVisualStyleBackColor = true;
            // 
            // saveUser
            // 
            this.saveUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveUser.Image = ((System.Drawing.Image)(resources.GetObject("saveUser.Image")));
            this.saveUser.Location = new System.Drawing.Point(46, 389);
            this.saveUser.Name = "saveUser";
            this.saveUser.Size = new System.Drawing.Size(168, 76);
            this.saveUser.TabIndex = 21;
            this.saveUser.Text = "Cập nhập";
            this.saveUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.saveUser.UseVisualStyleBackColor = true;
            this.saveUser.Click += new System.EventHandler(this.save_Click);
            // 
            // deleteUser
            // 
            this.deleteUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteUser.Image = ((System.Drawing.Image)(resources.GetObject("deleteUser.Image")));
            this.deleteUser.Location = new System.Drawing.Point(281, 279);
            this.deleteUser.Name = "deleteUser";
            this.deleteUser.Size = new System.Drawing.Size(170, 75);
            this.deleteUser.TabIndex = 20;
            this.deleteUser.Text = "Xóa";
            this.deleteUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.deleteUser.UseVisualStyleBackColor = true;
            this.deleteUser.Click += new System.EventHandler(this.delete_Click);
            // 
            // addUser
            // 
            this.addUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addUser.Image = ((System.Drawing.Image)(resources.GetObject("addUser.Image")));
            this.addUser.Location = new System.Drawing.Point(46, 279);
            this.addUser.Name = "addUser";
            this.addUser.Size = new System.Drawing.Size(168, 75);
            this.addUser.TabIndex = 19;
            this.addUser.Text = "Thêm";
            this.addUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.addUser.UseVisualStyleBackColor = true;
            this.addUser.Click += new System.EventHandler(this.add_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 158);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 22);
            this.label8.TabIndex = 15;
            this.label8.Text = "Địa chỉ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 22);
            this.label6.TabIndex = 13;
            this.label6.Text = "Số điện thoại";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 22);
            this.label2.TabIndex = 9;
            this.label2.Text = "Họ và tên";
            // 
            // address
            // 
            this.address.Location = new System.Drawing.Point(167, 150);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(296, 30);
            this.address.TabIndex = 7;
            // 
            // ids
            // 
            this.ids.Location = new System.Drawing.Point(168, -15);
            this.ids.Name = "ids";
            this.ids.Size = new System.Drawing.Size(315, 30);
            this.ids.TabIndex = 6;
            this.ids.Visible = false;
            // 
            // phones
            // 
            this.phones.Location = new System.Drawing.Point(164, 90);
            this.phones.Name = "phones";
            this.phones.Size = new System.Drawing.Size(299, 30);
            this.phones.TabIndex = 3;
            // 
            // names
            // 
            this.names.Location = new System.Drawing.Point(165, 26);
            this.names.Name = "names";
            this.names.Size = new System.Drawing.Size(298, 30);
            this.names.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.export_excel);
            this.groupBox2.Controls.Add(this.searchUser);
            this.groupBox2.Controls.Add(this.nameCus);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(3, 18);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1918, 106);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm kiếm";
            // 
            // export_excel
            // 
            this.export_excel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.export_excel.Image = ((System.Drawing.Image)(resources.GetObject("export_excel.Image")));
            this.export_excel.Location = new System.Drawing.Point(1519, 18);
            this.export_excel.Name = "export_excel";
            this.export_excel.Size = new System.Drawing.Size(195, 72);
            this.export_excel.TabIndex = 23;
            this.export_excel.Text = "Xuất Excel";
            this.export_excel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.export_excel.UseVisualStyleBackColor = true;
            // 
            // searchUser
            // 
            this.searchUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchUser.Image = ((System.Drawing.Image)(resources.GetObject("searchUser.Image")));
            this.searchUser.Location = new System.Drawing.Point(948, 18);
            this.searchUser.Name = "searchUser";
            this.searchUser.Size = new System.Drawing.Size(201, 72);
            this.searchUser.TabIndex = 2;
            this.searchUser.Text = "Tìm kiếm";
            this.searchUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.searchUser.UseVisualStyleBackColor = true;
            this.searchUser.Click += new System.EventHandler(this.search_Click);
            // 
            // nameCus
            // 
            this.nameCus.Location = new System.Drawing.Point(419, 40);
            this.nameCus.Name = "nameCus";
            this.nameCus.Size = new System.Drawing.Size(322, 30);
            this.nameCus.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(201, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tìm kiếm theo tên ";
            // 
            // Form_Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form_Customer";
            this.Text = "Form_AddCustomer";
            this.Load += new System.EventHandler(this.Form_Customer_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button saveUser;
        private System.Windows.Forms.Button deleteUser;
        private System.Windows.Forms.Button addUser;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.TextBox ids;
        private System.Windows.Forms.TextBox phones;
        private System.Windows.Forms.TextBox names;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button export_excel;
        private System.Windows.Forms.Button searchUser;
        private System.Windows.Forms.TextBox nameCus;
        private System.Windows.Forms.Label label1;
    }
}