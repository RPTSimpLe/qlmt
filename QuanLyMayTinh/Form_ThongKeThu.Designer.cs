namespace QuanLyMayTinh
{
    partial class Form_ThongKeThu
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbl_doanhThu = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_thu = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_chi = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1458, 611);
            this.dataGridView1.TabIndex = 1;
            // 
            // lbl_doanhThu
            // 
            this.lbl_doanhThu.AutoSize = true;
            this.lbl_doanhThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_doanhThu.Location = new System.Drawing.Point(112, 698);
            this.lbl_doanhThu.Name = "lbl_doanhThu";
            this.lbl_doanhThu.Size = new System.Drawing.Size(18, 20);
            this.lbl_doanhThu.TabIndex = 12;
            this.lbl_doanhThu.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 698);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Doanh thu";
            // 
            // lbl_thu
            // 
            this.lbl_thu.AutoSize = true;
            this.lbl_thu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_thu.Location = new System.Drawing.Point(112, 666);
            this.lbl_thu.Name = "lbl_thu";
            this.lbl_thu.Size = new System.Drawing.Size(18, 20);
            this.lbl_thu.TabIndex = 10;
            this.lbl_thu.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 666);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Tổng thu";
            // 
            // lbl_chi
            // 
            this.lbl_chi.AutoSize = true;
            this.lbl_chi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_chi.Location = new System.Drawing.Point(112, 635);
            this.lbl_chi.Name = "lbl_chi";
            this.lbl_chi.Size = new System.Drawing.Size(18, 20);
            this.lbl_chi.TabIndex = 8;
            this.lbl_chi.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 635);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tổng chi";
            // 
            // Form_ThongKeThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1482, 728);
            this.Controls.Add(this.lbl_doanhThu);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbl_thu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_chi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form_ThongKeThu";
            this.Text = "Form_ThongKeThu";
            this.Load += new System.EventHandler(this.Form_ThongKeThu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbl_doanhThu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_thu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_chi;
        private System.Windows.Forms.Label label3;
    }
}