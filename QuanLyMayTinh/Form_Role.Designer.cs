namespace QuanLyMayTinh
{
    partial class Form_Role
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Role));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cancel = new System.Windows.Forms.Button();
            this.saveRole = new System.Windows.Forms.Button();
            this.deleteRole = new System.Windows.Forms.Button();
            this.addRole = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.roles = new System.Windows.Forms.TextBox();
            this.ids = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.groupBox1.Size = new System.Drawing.Size(1110, 573);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(3, 18);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(718, 552);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Hiển thị";
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
            this.dataGridView1.Size = new System.Drawing.Size(712, 523);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cancel);
            this.groupBox2.Controls.Add(this.saveRole);
            this.groupBox2.Controls.Add(this.deleteRole);
            this.groupBox2.Controls.Add(this.addRole);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.roles);
            this.groupBox2.Controls.Add(this.ids);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(721, 18);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(386, 552);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Form";
            // 
            // cancel
            // 
            this.cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancel.Image = ((System.Drawing.Image)(resources.GetObject("cancel.Image")));
            this.cancel.Location = new System.Drawing.Point(211, 281);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(152, 70);
            this.cancel.TabIndex = 6;
            this.cancel.Text = "Hủy";
            this.cancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // saveRole
            // 
            this.saveRole.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveRole.Image = ((System.Drawing.Image)(resources.GetObject("saveRole.Image")));
            this.saveRole.Location = new System.Drawing.Point(19, 281);
            this.saveRole.Name = "saveRole";
            this.saveRole.Size = new System.Drawing.Size(171, 70);
            this.saveRole.TabIndex = 5;
            this.saveRole.Text = "Cập nhập";
            this.saveRole.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.saveRole.UseVisualStyleBackColor = true;
            this.saveRole.Click += new System.EventHandler(this.saveRole_Click);
            // 
            // deleteRole
            // 
            this.deleteRole.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteRole.Image = ((System.Drawing.Image)(resources.GetObject("deleteRole.Image")));
            this.deleteRole.Location = new System.Drawing.Point(211, 173);
            this.deleteRole.Name = "deleteRole";
            this.deleteRole.Size = new System.Drawing.Size(152, 75);
            this.deleteRole.TabIndex = 4;
            this.deleteRole.Text = "Xóa";
            this.deleteRole.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.deleteRole.UseVisualStyleBackColor = true;
            this.deleteRole.Click += new System.EventHandler(this.deleteRole_Click);
            // 
            // addRole
            // 
            this.addRole.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addRole.Image = ((System.Drawing.Image)(resources.GetObject("addRole.Image")));
            this.addRole.Location = new System.Drawing.Point(19, 173);
            this.addRole.Name = "addRole";
            this.addRole.Size = new System.Drawing.Size(171, 75);
            this.addRole.TabIndex = 3;
            this.addRole.Text = "Thêm";
            this.addRole.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.addRole.UseVisualStyleBackColor = true;
            this.addRole.Click += new System.EventHandler(this.addRole_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Quyền :";
            // 
            // roles
            // 
            this.roles.Location = new System.Drawing.Point(29, 96);
            this.roles.Name = "roles";
            this.roles.Size = new System.Drawing.Size(320, 30);
            this.roles.TabIndex = 1;
            // 
            // ids
            // 
            this.ids.Location = new System.Drawing.Point(68, 21);
            this.ids.Name = "ids";
            this.ids.Size = new System.Drawing.Size(219, 30);
            this.ids.TabIndex = 0;
            this.ids.Visible = false;
            // 
            // Form_Role
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 573);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form_Role";
            this.Text = "Danh sách quyền";
            this.Load += new System.EventHandler(this.Form_Role_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button saveRole;
        private System.Windows.Forms.Button deleteRole;
        private System.Windows.Forms.Button addRole;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox roles;
        private System.Windows.Forms.TextBox ids;
    }
}