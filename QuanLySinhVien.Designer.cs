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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuanLySinhVien));
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
            this.buttonReload = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Location = new System.Drawing.Point(149, 268);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(289, 28);
            this.dtpNgaySinh.TabIndex = 1;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(1752, 150);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(119, 29);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Clear";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnHienDanhSach
            // 
            this.btnHienDanhSach.Location = new System.Drawing.Point(1574, 149);
            this.btnHienDanhSach.Name = "btnHienDanhSach";
            this.btnHienDanhSach.Size = new System.Drawing.Size(119, 29);
            this.btnHienDanhSach.TabIndex = 3;
            this.btnHienDanhSach.Text = "Hiện danh sách";
            this.btnHienDanhSach.Click += new System.EventHandler(this.btnHienThi_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(1112, 443);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(141, 38);
            this.btnXoa.TabIndex = 4;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(899, 443);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(145, 38);
            this.btnSua.TabIndex = 5;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Image = ((System.Drawing.Image)(resources.GetObject("btnCapNhat.Image")));
            this.btnCapNhat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCapNhat.Location = new System.Drawing.Point(691, 443);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(148, 38);
            this.btnCapNhat.TabIndex = 6;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnThem
            // 
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(460, 443);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(150, 38);
            this.btnThem.TabIndex = 7;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKiem.Image")));
            this.btnTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiem.Location = new System.Drawing.Point(312, 81);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(126, 29);
            this.btnTimKiem.TabIndex = 8;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(759, 20);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(356, 35);
            this.label14.TabIndex = 9;
            this.label14.Text = "Danh Sách Sinh Viên";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(12, 268);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 23);
            this.label7.TabIndex = 10;
            this.label7.Text = "Ngày Sinh:";
            // 
            // rdoNu
            // 
            this.rdoNu.Location = new System.Drawing.Point(372, 195);
            this.rdoNu.Name = "rdoNu";
            this.rdoNu.Size = new System.Drawing.Size(66, 24);
            this.rdoNu.TabIndex = 12;
            this.rdoNu.Text = "Nữ";
            // 
            // rdoNam
            // 
            this.rdoNam.Location = new System.Drawing.Point(149, 196);
            this.rdoNam.Name = "rdoNam";
            this.rdoNam.Size = new System.Drawing.Size(104, 24);
            this.rdoNam.TabIndex = 13;
            this.rdoNam.Text = "Nam";
            // 
            // txtCCCD
            // 
            this.txtCCCD.Location = new System.Drawing.Point(149, 396);
            this.txtCCCD.Name = "txtCCCD";
            this.txtCCCD.Size = new System.Drawing.Size(289, 28);
            this.txtCCCD.TabIndex = 14;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(149, 352);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(289, 28);
            this.txtDiaChi.TabIndex = 15;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(149, 311);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(289, 28);
            this.txtEmail.TabIndex = 16;
            // 
            // txtNganh
            // 
            this.txtNganh.Location = new System.Drawing.Point(149, 229);
            this.txtNganh.Name = "txtNganh";
            this.txtNganh.Size = new System.Drawing.Size(289, 28);
            this.txtNganh.TabIndex = 17;
            // 
            // txtTenSV
            // 
            this.txtTenSV.Location = new System.Drawing.Point(149, 160);
            this.txtTenSV.Name = "txtTenSV";
            this.txtTenSV.Size = new System.Drawing.Size(289, 28);
            this.txtTenSV.TabIndex = 18;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(149, 84);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(151, 28);
            this.txtSDT.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(12, 396);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 23);
            this.label9.TabIndex = 20;
            this.label9.Text = "CCCD:";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(12, 357);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(159, 23);
            this.label8.TabIndex = 21;
            this.label8.Text = "Địa chỉ:";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(12, 311);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 23);
            this.label6.TabIndex = 22;
            this.label6.Text = "Email:";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(12, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 23);
            this.label5.TabIndex = 23;
            this.label5.Text = "Tên Ngành:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 38);
            this.label1.TabIndex = 24;
            this.label1.Text = "Quản Lý Sinh Viên";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(12, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 25;
            this.label4.Text = "Giới tính:";
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(12, 160);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(126, 23);
            this.label12.TabIndex = 26;
            this.label12.Text = "Tên sinh viên:";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(12, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 23);
            this.label3.TabIndex = 27;
            this.label3.Text = "Số điện thoại:";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 23);
            this.label2.TabIndex = 28;
            this.label2.Text = "Mã sinh viên:";
            // 
            // txtMaSV
            // 
            this.txtMaSV.Location = new System.Drawing.Point(149, 123);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(289, 28);
            this.txtMaSV.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeight = 29;
            this.dataGridView1.Location = new System.Drawing.Point(460, 81);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(987, 343);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // buttonReload
            // 
            this.buttonReload.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonReload.Location = new System.Drawing.Point(1299, 443);
            this.buttonReload.Name = "buttonReload";
            this.buttonReload.Size = new System.Drawing.Size(148, 38);
            this.buttonReload.TabIndex = 29;
            this.buttonReload.Text = "Tải lại";
            this.buttonReload.Click += new System.EventHandler(this.buttonReload_Click);
            // 
            // QuanLySinhVien
            // 
            this.ClientSize = new System.Drawing.Size(1459, 511);
            this.Controls.Add(this.buttonReload);
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
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1477, 558);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1477, 558);
            this.Name = "QuanLySinhVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý sinh viên";
            this.Load += new System.EventHandler(this.QuanLySinhVien_Load);
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
        private System.Windows.Forms.Button buttonReload;
    }
}