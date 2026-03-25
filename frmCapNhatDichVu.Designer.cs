namespace HeThongQuanLyKyTucXa
{
    partial class frmCapNhatDichVu
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaDV = new System.Windows.Forms.TextBox();
            this.txtTenDV = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDonViTinh = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvDichVu = new System.Windows.Forms.DataGridView();
            this.btnCapNhat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDichVu)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã dịch vụ";
            // 
            // txtMaDV
            // 
            this.txtMaDV.Location = new System.Drawing.Point(130, 48);
            this.txtMaDV.Name = "txtMaDV";
            this.txtMaDV.ReadOnly = true;
            this.txtMaDV.Size = new System.Drawing.Size(133, 22);
            this.txtMaDV.TabIndex = 1;
            this.txtMaDV.TextChanged += new System.EventHandler(this.txtMaDV_TextChanged);
            // 
            // txtTenDV
            // 
            this.txtTenDV.Location = new System.Drawing.Point(130, 76);
            this.txtTenDV.Name = "txtTenDV";
            this.txtTenDV.ReadOnly = true;
            this.txtTenDV.Size = new System.Drawing.Size(133, 22);
            this.txtTenDV.TabIndex = 3;
            this.txtTenDV.TextChanged += new System.EventHandler(this.txtTenDV_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên dịch vụ";
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(130, 104);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(133, 22);
            this.txtDonGia.TabIndex = 5;
            this.txtDonGia.TextChanged += new System.EventHandler(this.txtDonGia_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Đơn giá";
            // 
            // txtDonViTinh
            // 
            this.txtDonViTinh.Location = new System.Drawing.Point(130, 132);
            this.txtDonViTinh.Name = "txtDonViTinh";
            this.txtDonViTinh.ReadOnly = true;
            this.txtDonViTinh.Size = new System.Drawing.Size(133, 22);
            this.txtDonViTinh.TabIndex = 7;
            this.txtDonViTinh.TextChanged += new System.EventHandler(this.txtDonViTinh_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Đơn vị tính";
            // 
            // dgvDichVu
            // 
            this.dgvDichVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDichVu.Location = new System.Drawing.Point(1, 172);
            this.dgvDichVu.Name = "dgvDichVu";
            this.dgvDichVu.RowHeadersWidth = 51;
            this.dgvDichVu.RowTemplate.Height = 24;
            this.dgvDichVu.Size = new System.Drawing.Size(738, 212);
            this.dgvDichVu.TabIndex = 8;
            this.dgvDichVu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDichVu_CellClick);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(301, 79);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(98, 35);
            this.btnCapNhat.TabIndex = 9;
            this.btnCapNhat.Text = "Cập nhật ";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // frmCapNhatDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 364);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.dgvDichVu);
            this.Controls.Add(this.txtDonViTinh);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDonGia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTenDV);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMaDV);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(755, 411);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(755, 411);
            this.Name = "frmCapNhatDichVu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmCapNhatDichVu";
            this.Load += new System.EventHandler(this.frmCapNhatDichVu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDichVu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaDV;
        private System.Windows.Forms.TextBox txtTenDV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDonViTinh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvDichVu;
        private System.Windows.Forms.Button btnCapNhat;
    }
}