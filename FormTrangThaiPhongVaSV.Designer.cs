namespace HeThongQuanLyKyTucXa
{
    partial class FormTrangThaiPhongVaSV
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Columnstt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSoPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSoSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnHoten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnBirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCCCD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSoPhongSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTTThanhToan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonSearchRoom = new System.Windows.Forms.Button();
            this.buttonSearchSV = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1047, 519);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buttonSearchRoom);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1039, 486);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Trạng thái phòng";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Columnstt,
            this.ColumnSoPhong,
            this.ColumnSoSV,
            this.ColumnTT});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1033, 377);
            this.dataGridView1.TabIndex = 0;
            // 
            // Columnstt
            // 
            this.Columnstt.HeaderText = "STT";
            this.Columnstt.MinimumWidth = 6;
            this.Columnstt.Name = "Columnstt";
            // 
            // ColumnSoPhong
            // 
            this.ColumnSoPhong.HeaderText = "Số Phòng";
            this.ColumnSoPhong.MinimumWidth = 6;
            this.ColumnSoPhong.Name = "ColumnSoPhong";
            // 
            // ColumnSoSV
            // 
            this.ColumnSoSV.HeaderText = "Số sinh viên";
            this.ColumnSoSV.MinimumWidth = 6;
            this.ColumnSoSV.Name = "ColumnSoSV";
            // 
            // ColumnTT
            // 
            this.ColumnTT.HeaderText = "Trạng thái";
            this.ColumnTT.MinimumWidth = 6;
            this.ColumnTT.Name = "ColumnTT";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.buttonSearchSV);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1039, 486);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Trạng thái sinh viên";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.ColumnHoten,
            this.ColumnBirth,
            this.ColumnEmail,
            this.ColumnDiaChi,
            this.ColumnCCCD,
            this.ColumnSoPhongSV,
            this.ColumnTTThanhToan});
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView2.Location = new System.Drawing.Point(3, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(1033, 377);
            this.dataGridView2.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "STT";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // ColumnHoten
            // 
            this.ColumnHoten.HeaderText = "Họ và tên";
            this.ColumnHoten.MinimumWidth = 6;
            this.ColumnHoten.Name = "ColumnHoten";
            // 
            // ColumnBirth
            // 
            this.ColumnBirth.HeaderText = "Ngày sinh";
            this.ColumnBirth.MinimumWidth = 6;
            this.ColumnBirth.Name = "ColumnBirth";
            // 
            // ColumnEmail
            // 
            this.ColumnEmail.HeaderText = "Email";
            this.ColumnEmail.MinimumWidth = 6;
            this.ColumnEmail.Name = "ColumnEmail";
            // 
            // ColumnDiaChi
            // 
            this.ColumnDiaChi.HeaderText = "Địa chỉ";
            this.ColumnDiaChi.MinimumWidth = 6;
            this.ColumnDiaChi.Name = "ColumnDiaChi";
            // 
            // ColumnCCCD
            // 
            this.ColumnCCCD.HeaderText = "CCCD";
            this.ColumnCCCD.MinimumWidth = 6;
            this.ColumnCCCD.Name = "ColumnCCCD";
            // 
            // ColumnSoPhongSV
            // 
            this.ColumnSoPhongSV.HeaderText = "Số phòng";
            this.ColumnSoPhongSV.MinimumWidth = 6;
            this.ColumnSoPhongSV.Name = "ColumnSoPhongSV";
            // 
            // ColumnTTThanhToan
            // 
            this.ColumnTTThanhToan.HeaderText = "Trạng thái thanh toán";
            this.ColumnTTThanhToan.MinimumWidth = 6;
            this.ColumnTTThanhToan.Name = "ColumnTTThanhToan";
            // 
            // buttonSearchRoom
            // 
            this.buttonSearchRoom.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearchRoom.Location = new System.Drawing.Point(867, 401);
            this.buttonSearchRoom.Name = "buttonSearchRoom";
            this.buttonSearchRoom.Size = new System.Drawing.Size(148, 67);
            this.buttonSearchRoom.TabIndex = 1;
            this.buttonSearchRoom.Text = "Tìm kiếm";
            this.buttonSearchRoom.UseVisualStyleBackColor = true;
            // 
            // buttonSearchSV
            // 
            this.buttonSearchSV.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearchSV.Location = new System.Drawing.Point(866, 398);
            this.buttonSearchSV.Name = "buttonSearchSV";
            this.buttonSearchSV.Size = new System.Drawing.Size(148, 67);
            this.buttonSearchSV.TabIndex = 2;
            this.buttonSearchSV.Text = "Tìm kiếm";
            this.buttonSearchSV.UseVisualStyleBackColor = true;
            // 
            // FormTrangThaiPhongVaSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 519);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormTrangThaiPhongVaSV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormTrangThaiPhongVaSV";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Columnstt;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSoPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSoSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTT;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnHoten;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnBirth;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCCCD;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSoPhongSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTTThanhToan;
        private System.Windows.Forms.Button buttonSearchRoom;
        private System.Windows.Forms.Button buttonSearchSV;
    }
}