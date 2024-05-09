namespace QuanLyMayTinh
{
    partial class Form_Product
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Product));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnDetail = new System.Windows.Forms.Button();
            this.ids = new System.Windows.Forms.TextBox();
            this.deleteUser = new System.Windows.Forms.Button();
            this.addUser = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.searchProduct = new System.Windows.Forms.Button();
            this.cbo_Producer = new System.Windows.Forms.ComboBox();
            this.cbo_category = new System.Windows.Forms.ComboBox();
            this.txt_findName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
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
            this.groupBox1.BackColor = System.Drawing.Color.AliceBlue;
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1558, 880);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox6);
            this.groupBox3.Controls.Add(this.groupBox5);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(3, 18);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1552, 859);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.dataGridView1);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(3, 117);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(1113, 739);
            this.groupBox6.TabIndex = 2;
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
            this.dataGridView1.Size = new System.Drawing.Size(1107, 710);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnReset);
            this.groupBox5.Controls.Add(this.btnDetail);
            this.groupBox5.Controls.Add(this.ids);
            this.groupBox5.Controls.Add(this.deleteUser);
            this.groupBox5.Controls.Add(this.addUser);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(1116, 117);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(433, 739);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Chức năng";
            // 
            // btnReset
            // 
            this.btnReset.Image = ((System.Drawing.Image)(resources.GetObject("btnReset.Image")));
            this.btnReset.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReset.Location = new System.Drawing.Point(251, 208);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(151, 75);
            this.btnReset.TabIndex = 41;
            this.btnReset.Text = "Làm mới";
            this.btnReset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnDetail
            // 
            this.btnDetail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDetail.Image = global::QuanLyMayTinh.Properties.Resources.pencil__2_;
            this.btnDetail.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDetail.Location = new System.Drawing.Point(30, 208);
            this.btnDetail.Name = "btnDetail";
            this.btnDetail.Size = new System.Drawing.Size(154, 75);
            this.btnDetail.TabIndex = 40;
            this.btnDetail.Text = "Chi tiết";
            this.btnDetail.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDetail.UseVisualStyleBackColor = true;
            this.btnDetail.Click += new System.EventHandler(this.btnDetail_Click);
            // 
            // ids
            // 
            this.ids.Location = new System.Drawing.Point(127, 6);
            this.ids.Name = "ids";
            this.ids.Size = new System.Drawing.Size(223, 30);
            this.ids.TabIndex = 27;
            this.ids.Visible = false;
            // 
            // deleteUser
            // 
            this.deleteUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteUser.Image = global::QuanLyMayTinh.Properties.Resources.delete__1_;
            this.deleteUser.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.deleteUser.Location = new System.Drawing.Point(251, 85);
            this.deleteUser.Name = "deleteUser";
            this.deleteUser.Size = new System.Drawing.Size(151, 75);
            this.deleteUser.TabIndex = 24;
            this.deleteUser.Text = "Xóa";
            this.deleteUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.deleteUser.UseVisualStyleBackColor = true;
            this.deleteUser.Click += new System.EventHandler(this.deleteUser_Click);
            // 
            // addUser
            // 
            this.addUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addUser.Image = global::QuanLyMayTinh.Properties.Resources.plus__1_;
            this.addUser.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addUser.Location = new System.Drawing.Point(30, 85);
            this.addUser.Name = "addUser";
            this.addUser.Size = new System.Drawing.Size(154, 75);
            this.addUser.TabIndex = 23;
            this.addUser.Text = "Thêm";
            this.addUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.addUser.UseVisualStyleBackColor = true;
            this.addUser.Click += new System.EventHandler(this.addUser_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.searchProduct);
            this.groupBox4.Controls.Add(this.cbo_Producer);
            this.groupBox4.Controls.Add(this.cbo_category);
            this.groupBox4.Controls.Add(this.txt_findName);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(3, 18);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1546, 99);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tìm kiếm";
            // 
            // searchProduct
            // 
            this.searchProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchProduct.Image = global::QuanLyMayTinh.Properties.Resources.search__1_;
            this.searchProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.searchProduct.Location = new System.Drawing.Point(1319, 19);
            this.searchProduct.Name = "searchProduct";
            this.searchProduct.Size = new System.Drawing.Size(196, 72);
            this.searchProduct.TabIndex = 4;
            this.searchProduct.Text = "Tìm kiếm";
            this.searchProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.searchProduct.UseVisualStyleBackColor = true;
            this.searchProduct.Click += new System.EventHandler(this.searchProduct_Click);
            // 
            // cbo_Producer
            // 
            this.cbo_Producer.FormattingEnabled = true;
            this.cbo_Producer.Location = new System.Drawing.Point(1013, 38);
            this.cbo_Producer.Name = "cbo_Producer";
            this.cbo_Producer.Size = new System.Drawing.Size(179, 30);
            this.cbo_Producer.TabIndex = 3;
            this.cbo_Producer.Text = "Lọc theo hãng";
            // 
            // cbo_category
            // 
            this.cbo_category.FormattingEnabled = true;
            this.cbo_category.Location = new System.Drawing.Point(728, 38);
            this.cbo_category.Name = "cbo_category";
            this.cbo_category.Size = new System.Drawing.Size(176, 30);
            this.cbo_category.TabIndex = 2;
            this.cbo_category.Text = "Lọc theo loại";
            // 
            // txt_findName
            // 
            this.txt_findName.Location = new System.Drawing.Point(305, 41);
            this.txt_findName.Name = "txt_findName";
            this.txt_findName.Size = new System.Drawing.Size(283, 30);
            this.txt_findName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tìm kiếm theo tên";
            // 
            // Form_Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1558, 880);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form_Product";
            this.Text = "       Danh sách sản phẩm";
            this.Load += new System.EventHandler(this.Form_Product_Load);
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
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button searchProduct;
        private System.Windows.Forms.ComboBox cbo_Producer;
        private System.Windows.Forms.ComboBox cbo_category;
        private System.Windows.Forms.TextBox txt_findName;
        private System.Windows.Forms.Button deleteUser;
        private System.Windows.Forms.Button addUser;
        private System.Windows.Forms.TextBox ids;
        private System.Windows.Forms.Button btnDetail;
        private System.Windows.Forms.Button btnReset;
    }
}