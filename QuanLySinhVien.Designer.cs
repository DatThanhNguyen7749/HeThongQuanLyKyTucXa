namespace QuanLySinhVien
{
    partial class QuanLySinhVien
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuanLySinhVien));
            dtpNgaySinh = new DateTimePicker();
            btnClear = new Button();
            btnHienDanhSach = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnCapNhat = new Button();
            btnThem = new Button();
            btnTimKiem = new Button();
            label14 = new Label();
            label7 = new Label();
            rdoNu = new RadioButton();
            rdoNam = new RadioButton();
            txtCCCD = new TextBox();
            txtDiaChi = new TextBox();
            txtEmail = new TextBox();
            txtNganh = new TextBox();
            txtTenSV = new TextBox();
            txtSDT = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label6 = new Label();
            label5 = new Label();
            label1 = new Label();
            label4 = new Label();
            label12 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtMaSV = new TextBox();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.Location = new Point(123, 322);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new Size(250, 27);
            dtpNgaySinh.TabIndex = 98;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(192, 255, 255);
            btnClear.ForeColor = SystemColors.ControlText;
            btnClear.Image = (Image)resources.GetObject("btnClear.Image");
            btnClear.ImageAlign = ContentAlignment.MiddleLeft;
            btnClear.Location = new Point(1752, 150);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(119, 29);
            btnClear.TabIndex = 93;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnHienDanhSach
            // 
            btnHienDanhSach.BackColor = Color.FromArgb(192, 255, 255);
            btnHienDanhSach.ForeColor = SystemColors.ControlText;
            btnHienDanhSach.ImageAlign = ContentAlignment.MiddleLeft;
            btnHienDanhSach.Location = new Point(1574, 149);
            btnHienDanhSach.Name = "btnHienDanhSach";
            btnHienDanhSach.Size = new Size(119, 29);
            btnHienDanhSach.TabIndex = 92;
            btnHienDanhSach.Text = "Hiện danh sách";
            btnHienDanhSach.UseVisualStyleBackColor = false;
            btnHienDanhSach.Click += btnHienThi_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.FromArgb(192, 255, 255);
            btnXoa.ForeColor = SystemColors.ControlText;
            btnXoa.Image = (Image)resources.GetObject("btnXoa.Image");
            btnXoa.ImageAlign = ContentAlignment.MiddleLeft;
            btnXoa.Location = new Point(706, 637);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(119, 29);
            btnXoa.TabIndex = 91;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.FromArgb(192, 255, 255);
            btnSua.ForeColor = SystemColors.ControlText;
            btnSua.Image = (Image)resources.GetObject("btnSua.Image");
            btnSua.ImageAlign = ContentAlignment.MiddleLeft;
            btnSua.Location = new Point(546, 637);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(119, 29);
            btnSua.TabIndex = 90;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnCapNhat
            // 
            btnCapNhat.BackColor = Color.FromArgb(192, 255, 255);
            btnCapNhat.ForeColor = SystemColors.ControlText;
            btnCapNhat.Image = (Image)resources.GetObject("btnCapNhat.Image");
            btnCapNhat.ImageAlign = ContentAlignment.MiddleLeft;
            btnCapNhat.Location = new Point(388, 637);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(119, 29);
            btnCapNhat.TabIndex = 89;
            btnCapNhat.Text = "Cập nhật";
            btnCapNhat.UseVisualStyleBackColor = false;
            btnCapNhat.Click += btnCapNhat_Click;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.FromArgb(192, 255, 255);
            btnThem.ForeColor = SystemColors.ControlText;
            btnThem.Image = (Image)resources.GetObject("btnThem.Image");
            btnThem.ImageAlign = ContentAlignment.MiddleLeft;
            btnThem.Location = new Point(242, 637);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(114, 29);
            btnThem.TabIndex = 88;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // btnTimKiem
            // 
            btnTimKiem.BackColor = Color.FromArgb(192, 255, 255);
            btnTimKiem.ForeColor = SystemColors.ControlText;
            btnTimKiem.Image = (Image)resources.GetObject("btnTimKiem.Image");
            btnTimKiem.ImageAlign = ContentAlignment.MiddleLeft;
            btnTimKiem.Location = new Point(350, 151);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(119, 29);
            btnTimKiem.TabIndex = 87;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = false;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label14.Location = new Point(865, 133);
            label14.Name = "label14";
            label14.Size = new Size(274, 38);
            label14.TabIndex = 86;
            label14.Text = "Danh Sách Sinh Viên";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(18, 322);
            label7.Name = "label7";
            label7.Size = new Size(79, 20);
            label7.TabIndex = 97;
            label7.Text = "Ngày Sinh:";
            // 
            // rdoNu
            // 
            rdoNu.AutoSize = true;
            rdoNu.Location = new Point(215, 281);
            rdoNu.Name = "rdoNu";
            rdoNu.Size = new Size(50, 24);
            rdoNu.TabIndex = 84;
            rdoNu.TabStop = true;
            rdoNu.Text = "Nữ";
            rdoNu.UseVisualStyleBackColor = true;
            // 
            // rdoNam
            // 
            rdoNam.AutoSize = true;
            rdoNam.Location = new Point(127, 279);
            rdoNam.Name = "rdoNam";
            rdoNam.Size = new Size(62, 24);
            rdoNam.TabIndex = 83;
            rdoNam.TabStop = true;
            rdoNam.Text = "Nam";
            rdoNam.UseVisualStyleBackColor = true;
            // 
            // txtCCCD
            // 
            txtCCCD.Location = new Point(149, 519);
            txtCCCD.Name = "txtCCCD";
            txtCCCD.Size = new Size(342, 27);
            txtCCCD.TabIndex = 82;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(149, 461);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(342, 27);
            txtDiaChi.TabIndex = 81;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(127, 419);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(342, 27);
            txtEmail.TabIndex = 80;
            // 
            // txtNganh
            // 
            txtNganh.Location = new Point(127, 370);
            txtNganh.Name = "txtNganh";
            txtNganh.Size = new Size(342, 27);
            txtNganh.TabIndex = 79;
            // 
            // txtTenSV
            // 
            txtTenSV.Location = new Point(123, 239);
            txtTenSV.Name = "txtTenSV";
            txtTenSV.Size = new Size(342, 27);
            txtTenSV.TabIndex = 78;
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(123, 195);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(342, 27);
            txtSDT.TabIndex = 77;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(17, 510);
            label9.Name = "label9";
            label9.Size = new Size(50, 20);
            label9.TabIndex = 75;
            label9.Text = "CCCD:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(11, 464);
            label8.Name = "label8";
            label8.Size = new Size(132, 20);
            label8.TabIndex = 74;
            label8.Text = "Địa chỉ thường trú:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(18, 426);
            label6.Name = "label6";
            label6.Size = new Size(49, 20);
            label6.TabIndex = 73;
            label6.Text = "Email:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(18, 373);
            label5.Name = "label5";
            label5.Size = new Size(83, 20);
            label5.TabIndex = 72;
            label5.Text = "Tên Ngành:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(113, 87);
            label1.Name = "label1";
            label1.Size = new Size(243, 38);
            label1.TabIndex = 71;
            label1.Text = "Quản Lý Sinh Viên";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 281);
            label4.Name = "label4";
            label4.Size = new Size(68, 20);
            label4.TabIndex = 70;
            label4.Text = "Giới tính:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(17, 239);
            label12.Name = "label12";
            label12.Size = new Size(96, 20);
            label12.TabIndex = 69;
            label12.Text = "Tên sinh viên:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 195);
            label3.Name = "label3";
            label3.Size = new Size(100, 20);
            label3.TabIndex = 68;
            label3.Text = "Số điện thoại:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 151);
            label2.Name = "label2";
            label2.Size = new Size(94, 20);
            label2.TabIndex = 67;
            label2.Text = "Mã sinh viên:";
            // 
            // txtMaSV
            // 
            txtMaSV.Location = new Point(117, 149);
            txtMaSV.Name = "txtMaSV";
            txtMaSV.Size = new Size(208, 27);
            txtMaSV.TabIndex = 99;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(546, 195);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1303, 353);
            dataGridView1.TabIndex = 85;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1882, 753);
            Controls.Add(txtMaSV);
            Controls.Add(dtpNgaySinh);
            Controls.Add(btnClear);
            Controls.Add(btnHienDanhSach);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnCapNhat);
            Controls.Add(btnThem);
            Controls.Add(btnTimKiem);
            Controls.Add(label14);
            Controls.Add(label7);
            Controls.Add(dataGridView1);
            Controls.Add(rdoNu);
            Controls.Add(rdoNam);
            Controls.Add(txtCCCD);
            Controls.Add(txtDiaChi);
            Controls.Add(txtEmail);
            Controls.Add(txtNganh);
            Controls.Add(txtTenSV);
            Controls.Add(txtSDT);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label1);
            Controls.Add(label4);
            Controls.Add(label12);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DateTimePicker dtpNgaySinh;
        private Button btnClear;
        private Button btnHienDanhSach;
        private Button btnXoa;
        private Button btnSua;
        private Button btnCapNhat;
        private Button btnThem;
        private Button btnTimKiem;
        private Label label14;
        private Label label7;
        private RadioButton rdoNu;
        private RadioButton rdoNam;
        private TextBox txtCCCD;
        private TextBox txtDiaChi;
        private TextBox txtEmail;
        private TextBox txtNganh;
        private TextBox txtTenSV;
        private TextBox txtSDT;
        private Label label9;
        private Label label8;
        private Label label6;
        private Label label5;
        private Label label1;
        private Label label4;
        private Label label12;
        private Label label3;
        private Label label2;
        private TextBox txtMaSV;
        private DataGridView dataGridView1;
    }
}
