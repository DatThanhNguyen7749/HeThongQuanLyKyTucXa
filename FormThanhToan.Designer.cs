namespace HeThongQuanLyKyTucXa
{
    partial class FormThanhToan
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
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewHD = new System.Windows.Forms.DataGridView();
            this.ColumnSoPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSoDien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSoNuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnGiaDien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnGiaNuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnGiaPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonThanhToan = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxPhuongThuc = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.labelSoTien = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHD)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(392, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "HÓA ĐƠN VÀ THANH TOÁN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hóa đơn:";
            // 
            // dataGridViewHD
            // 
            this.dataGridViewHD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnSoPhong,
            this.ColumnSoDien,
            this.ColumnSoNuoc,
            this.ColumnGiaDien,
            this.ColumnGiaNuoc,
            this.ColumnGiaPhong,
            this.ColumnTong});
            this.dataGridViewHD.Location = new System.Drawing.Point(20, 128);
            this.dataGridViewHD.Name = "dataGridViewHD";
            this.dataGridViewHD.ReadOnly = true;
            this.dataGridViewHD.RowHeadersWidth = 51;
            this.dataGridViewHD.RowTemplate.Height = 24;
            this.dataGridViewHD.Size = new System.Drawing.Size(1095, 49);
            this.dataGridViewHD.TabIndex = 2;
            // 
            // ColumnSoPhong
            // 
            this.ColumnSoPhong.HeaderText = "Số phòng";
            this.ColumnSoPhong.MinimumWidth = 6;
            this.ColumnSoPhong.Name = "ColumnSoPhong";
            this.ColumnSoPhong.ReadOnly = true;
            // 
            // ColumnSoDien
            // 
            this.ColumnSoDien.HeaderText = "Số điện";
            this.ColumnSoDien.MinimumWidth = 6;
            this.ColumnSoDien.Name = "ColumnSoDien";
            this.ColumnSoDien.ReadOnly = true;
            // 
            // ColumnSoNuoc
            // 
            this.ColumnSoNuoc.HeaderText = "Số nước";
            this.ColumnSoNuoc.MinimumWidth = 6;
            this.ColumnSoNuoc.Name = "ColumnSoNuoc";
            this.ColumnSoNuoc.ReadOnly = true;
            // 
            // ColumnGiaDien
            // 
            this.ColumnGiaDien.HeaderText = "Giá điện";
            this.ColumnGiaDien.MinimumWidth = 6;
            this.ColumnGiaDien.Name = "ColumnGiaDien";
            this.ColumnGiaDien.ReadOnly = true;
            // 
            // ColumnGiaNuoc
            // 
            this.ColumnGiaNuoc.HeaderText = "Giá nước";
            this.ColumnGiaNuoc.MinimumWidth = 6;
            this.ColumnGiaNuoc.Name = "ColumnGiaNuoc";
            this.ColumnGiaNuoc.ReadOnly = true;
            // 
            // ColumnGiaPhong
            // 
            this.ColumnGiaPhong.HeaderText = "Giá Phòng";
            this.ColumnGiaPhong.MinimumWidth = 6;
            this.ColumnGiaPhong.Name = "ColumnGiaPhong";
            this.ColumnGiaPhong.ReadOnly = true;
            // 
            // ColumnTong
            // 
            this.ColumnTong.HeaderText = "Tổng";
            this.ColumnTong.MinimumWidth = 6;
            this.ColumnTong.Name = "ColumnTong";
            this.ColumnTong.ReadOnly = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 28);
            this.label3.TabIndex = 3;
            this.label3.Text = "Thanh toán:";
            // 
            // buttonThanhToan
            // 
            this.buttonThanhToan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonThanhToan.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThanhToan.Location = new System.Drawing.Point(988, 406);
            this.buttonThanhToan.Name = "buttonThanhToan";
            this.buttonThanhToan.Size = new System.Drawing.Size(135, 64);
            this.buttonThanhToan.TabIndex = 4;
            this.buttonThanhToan.Text = "Thanh Toán";
            this.buttonThanhToan.UseVisualStyleBackColor = true;
            this.buttonThanhToan.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 287);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(249, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "Chọn phương thức thanh toán:";
            // 
            // comboBoxPhuongThuc
            // 
            this.comboBoxPhuongThuc.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxPhuongThuc.FormattingEnabled = true;
            this.comboBoxPhuongThuc.Items.AddRange(new object[] {
            "Thanh toán trực tuyến",
            "Thanh toán tiền mặt"});
            this.comboBoxPhuongThuc.Location = new System.Drawing.Point(306, 286);
            this.comboBoxPhuongThuc.Name = "comboBoxPhuongThuc";
            this.comboBoxPhuongThuc.Size = new System.Drawing.Size(270, 31);
            this.comboBoxPhuongThuc.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(186, 23);
            this.label5.TabIndex = 7;
            this.label5.Text = "Tổng số tiền cần đóng:";
            // 
            // labelSoTien
            // 
            this.labelSoTien.AutoSize = true;
            this.labelSoTien.Location = new System.Drawing.Point(222, 199);
            this.labelSoTien.Name = "labelSoTien";
            this.labelSoTien.Size = new System.Drawing.Size(0, 16);
            this.labelSoTien.TabIndex = 8;
            // 
            // FormThanhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 482);
            this.Controls.Add(this.labelSoTien);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxPhuongThuc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonThanhToan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridViewHD);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormThanhToan";
            this.Text = "Hóa đơn và Thanh toán";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormThanhToan_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSoPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSoDien;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSoNuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnGiaDien;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnGiaNuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnGiaPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonThanhToan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxPhuongThuc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelSoTien;
    }
}