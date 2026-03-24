namespace HeThongQuanLyKyTucXa
{
    partial class QuanLySinhVien
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnHienDanhSach = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.rdoNu = new System.Windows.Forms.RadioButton();
            this.rdoNam = new System.Windows.Forms.RadioButton();
            this.txtCCCD = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtNganh = new System.Windows.Forms.TextBox();
            this.txtTenSV = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();

            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();

            // dtpNgaySinh
            this.dtpNgaySinh.Location = new System.Drawing.Point(123, 322);
            this.dtpNgaySinh.Size = new System.Drawing.Size(250, 27);

            // txtMaSV
            this.txtMaSV.Location = new System.Drawing.Point(117, 149);
            this.txtMaSV.Size = new System.Drawing.Size(208, 27);

            // txtSDT
            this.txtSDT.Location = new System.Drawing.Point(123, 195);
            this.txtSDT.Size = new System.Drawing.Size(342, 27);

            // txtTenSV
            this.txtTenSV.Location = new System.Drawing.Point(123, 239);
            this.txtTenSV.Size = new System.Drawing.Size(342, 27);

            // rdoNam
            this.rdoNam.Location = new System.Drawing.Point(127, 279);
            this.rdoNam.Text = "Nam";

            // rdoNu
            this.rdoNu.Location = new System.Drawing.Point(215, 279);
            this.rdoNu.Text = "Nữ";

            // txtNganh
            this.txtNganh.Location = new System.Drawing.Point(127, 370);
            this.txtNganh.Size = new System.Drawing.Size(342, 27);

            // txtEmail
            this.txtEmail.Location = new System.Drawing.Point(127, 419);
            this.txtEmail.Size = new System.Drawing.Size(342, 27);

            // txtDiaChi
            this.txtDiaChi.Location = new System.Drawing.Point(149, 461);
            this.txtDiaChi.Size = new System.Drawing.Size(342, 27);

            // txtCCCD
            this.txtCCCD.Location = new System.Drawing.Point(149, 519);
            this.txtCCCD.Size = new System.Drawing.Size(342, 27);

            // Buttons
            this.btnThem.Location = new System.Drawing.Point(242, 637);
            this.btnThem.Size = new System.Drawing.Size(114, 29);
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);

            this.btnCapNhat.Location = new System.Drawing.Point(388, 637);
            this.btnCapNhat.Size = new System.Drawing.Size(119, 29);
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);

            this.btnSua.Location = new System.Drawing.Point(546, 637);
            this.btnSua.Size = new System.Drawing.Size(119, 29);
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);

            this.btnXoa.Location = new System.Drawing.Point(706, 637);
            this.btnXoa.Size = new System.Drawing.Size(119, 29);
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);

            this.btnTimKiem.Location = new System.Drawing.Point(350, 151);
            this.btnTimKiem.Size = new System.Drawing.Size(119, 29);
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);

            this.btnHienDanhSach.Location = new System.Drawing.Point(1574, 149);
            this.btnHienDanhSach.Size = new System.Drawing.Size(119, 29);
            this.btnHienDanhSach.Text = "Hiện danh sách";
            this.btnHienDanhSach.Click += new System.EventHandler(this.btnHienThi_Click);

            this.btnClear.Location = new System.Drawing.Point(1752, 150);
            this.btnClear.Size = new System.Drawing.Size(119, 29);
            this.btnClear.Text = "Clear";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);

            // Labels
            this.label1.Location = new System.Drawing.Point(113, 87);
            this.label1.Text = "Quản Lý Sinh Viên";

            this.label2.Location = new System.Drawing.Point(17, 151);
            this.label2.Text = "Mã sinh viên:";

            this.label3.Location = new System.Drawing.Point(17, 195);
            this.label3.Text = "Số điện thoại:";

            this.label12.Location = new System.Drawing.Point(17, 239);
            this.label12.Text = "Tên sinh viên:";

            this.label4.Location = new System.Drawing.Point(17, 281);
            this.label4.Text = "Giới tính:";

            this.label5.Location = new System.Drawing.Point(18, 373);
            this.label5.Text = "Tên Ngành:";

            this.label6.Location = new System.Drawing.Point(18, 426);
            this.label6.Text = "Email:";

            this.label8.Location = new System.Drawing.Point(11, 464);
            this.label8.Text = "Địa chỉ thường trú:";

            this.label9.Location = new System.Drawing.Point(17, 510);
            this.label9.Text = "CCCD:";

            this.label7.Location = new System.Drawing.Point(18, 322);
            this.label7.Text = "Ngày Sinh:";

            this.label14.Location = new System.Drawing.Point(865, 133);
            this.label14.Text = "Danh Sách Sinh Viên";

            // DataGridView
            this.dataGridView1.Location = new System.Drawing.Point(546, 195);
            this.dataGridView1.Size = new System.Drawing.Size(1303, 353);
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);

            // Form
            this.ClientSize = new System.Drawing.Size(1882, 753);
            this.Controls.Add(this.txtMaSV);
            this.Controls.Add(this.dtpNgaySinh);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnHienDanhSach);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.rdoNu);
            this.Controls.Add(this.rdoNam);
            this.Controls.Add(this.txtCCCD);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtNganh);
            this.Controls.Add(this.txtTenSV);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);

            this.Name = "QuanLySinhVien";
            this.Text = "Quản lý sinh viên";

            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnHienDanhSach;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton rdoNu;
        private System.Windows.Forms.RadioButton rdoNam;
        private System.Windows.Forms.TextBox txtCCCD;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtNganh;
        private System.Windows.Forms.TextBox txtTenSV;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}