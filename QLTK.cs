using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLTK
{
    public partial class QLTK : Form
    {
        string connStr = @"Data Source=.;Initial Catalog=QLKTX234;Integrated Security=True";

        public QLTK()
        {
            InitializeComponent();
            this.Load += QLTK_Load;
            dataGridView1.CellClick += Cell_Click;
        }

        private void QLTK_Load(object sender, EventArgs e)
        {
            ChucVu.Items.Clear();
            ChucVu.Items.Add("Admin");
            ChucVu.Items.Add("NhanVien");

            GioiTinh.Items.Clear();
            GioiTinh.Items.Add("Nam");
            GioiTinh.Items.Add("Nữ");

            LoadData();
        }

        void LoadData()
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string query = @"
                SELECT tai_khoan.id,
                       ho_ten,
                       ngay_sinh,
                       gioi_tinh,
                       role.name AS chuc_vu,
                       so_dien_thoai,
                       dia_chi,
                       email,
                       ten_dang_nhap,
                       mat_khau
                FROM tai_khoan
                JOIN role ON tai_khoan.role_id = role.id";

                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;

                if (dataGridView1.Columns.Count > 0)
                {
                    dataGridView1.Columns["id"].HeaderText = "Mã";
                    dataGridView1.Columns["ho_ten"].HeaderText = "Họ tên";
                    dataGridView1.Columns["ngay_sinh"].HeaderText = "Ngày sinh";
                    dataGridView1.Columns["gioi_tinh"].HeaderText = "Giới tính";
                    dataGridView1.Columns["chuc_vu"].HeaderText = "Chức vụ";
                    dataGridView1.Columns["so_dien_thoai"].HeaderText = "Số điện thoại";
                    dataGridView1.Columns["dia_chi"].HeaderText = "Địa chỉ";
                    dataGridView1.Columns["email"].HeaderText = "Email";
                    dataGridView1.Columns["ten_dang_nhap"].HeaderText = "Tên đăng nhập";
                    dataGridView1.Columns["mat_khau"].HeaderText = "Mật khẩu";
                }

                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }

        int GetRoleId(string roleName)
        {
            if (roleName == "Admin")
                return 1;
            return 2;
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            if (textBoxHoten.Text.Trim() == "" ||
                GioiTinh.Text.Trim() == "" ||
                ChucVu.Text.Trim() == "" ||
                textBoxSDT.Text.Trim() == "" ||
                DiaChi.Text.Trim() == "" ||
                Email.Text.Trim() == "" ||
                Username.Text.Trim() == "" ||
                Password.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();

                string check = @"
        SELECT COUNT(*) 
        FROM tai_khoan 
        WHERE ten_dang_nhap COLLATE SQL_Latin1_General_CP1_CS_AS = @username";

                SqlCommand checkCmd = new SqlCommand(check, conn);
                checkCmd.Parameters.AddWithValue("@username", Username.Text.Trim());

                int count = (int)checkCmd.ExecuteScalar();

                if (count > 0)
                {
                    MessageBox.Show("Tên đăng nhập đã tồn tại");
                    return;
                }

                string query = @"
        INSERT INTO tai_khoan
        (ten_dang_nhap, mat_khau, role_id, ho_ten, email, ngay_sinh, gioi_tinh, so_dien_thoai, dia_chi)
        VALUES
        (@username, @password, @role, @hoten, @email, @ngaysinh, @gioitinh, @sdt, @diachi)";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@username", Username.Text.Trim());
                cmd.Parameters.AddWithValue("@password", Password.Text.Trim());
                cmd.Parameters.AddWithValue("@role", GetRoleId(ChucVu.Text));
                cmd.Parameters.AddWithValue("@hoten", textBoxHoten.Text.Trim());
                cmd.Parameters.AddWithValue("@email", Email.Text.Trim());
                cmd.Parameters.AddWithValue("@ngaysinh", dateTimePicker1.Value.Date);
                cmd.Parameters.AddWithValue("@gioitinh", GioiTinh.Text.Trim());
                cmd.Parameters.AddWithValue("@sdt", textBoxSDT.Text.Trim());
                cmd.Parameters.AddWithValue("@diachi", DiaChi.Text.Trim());

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thêm thành công");
                    LoadData();
                }
                catch (SqlException)
                {
                    MessageBox.Show("Tên đăng nhập đã tồn tại");
                    return;
                }
            }
        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null || dataGridView1.CurrentRow.IsNewRow)
            {
                MessageBox.Show("Vui lòng chọn dòng cần sửa!");
                return;
            }

            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id"].Value);

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();

                string query = @"
                UPDATE tai_khoan
                SET ho_ten=@hoten,
                    email=@email,
                    ngay_sinh=@ngaysinh,
                    gioi_tinh=@gioitinh,
                    role_id=@role,
                    so_dien_thoai=@sdt,
                    dia_chi=@diachi,
                    ten_dang_nhap=@username,
                    mat_khau=@password
                WHERE id=@id";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@hoten", textBoxHoten.Text.Trim());
                cmd.Parameters.AddWithValue("@email", Email.Text.Trim());
                cmd.Parameters.AddWithValue("@ngaysinh", dateTimePicker1.Value.Date);
                cmd.Parameters.AddWithValue("@gioitinh", GioiTinh.Text.Trim());
                cmd.Parameters.AddWithValue("@role", GetRoleId(ChucVu.Text));
                cmd.Parameters.AddWithValue("@sdt", textBoxSDT.Text.Trim());
                cmd.Parameters.AddWithValue("@diachi", DiaChi.Text.Trim());
                cmd.Parameters.AddWithValue("@username", Username.Text.Trim());
                cmd.Parameters.AddWithValue("@password", Password.Text.Trim());

                cmd.ExecuteNonQuery();

                MessageBox.Show("Sửa thành công");
                LoadData();
            }
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null || dataGridView1.CurrentRow.IsNewRow)
            {
                MessageBox.Show("Vui lòng chọn dòng cần xóa!");
                return;
            }

            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id"].Value);

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();

                string query = "DELETE FROM tai_khoan WHERE id=@id";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Xóa thành công");
                LoadData();
            }
        }

        private void Cell_Click(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || dataGridView1.CurrentRow == null || dataGridView1.CurrentRow.IsNewRow)
            {
                MessageBox.Show("Không hiển thị được dòng không có thông tin");
                return;
            }

            textBoxHoten.Text = dataGridView1.CurrentRow.Cells["ho_ten"].Value?.ToString();
            GioiTinh.Text = dataGridView1.CurrentRow.Cells["gioi_tinh"].Value?.ToString();
            ChucVu.Text = dataGridView1.CurrentRow.Cells["chuc_vu"].Value?.ToString();
            textBoxSDT.Text = dataGridView1.CurrentRow.Cells["so_dien_thoai"].Value?.ToString();
            DiaChi.Text = dataGridView1.CurrentRow.Cells["dia_chi"].Value?.ToString();
            Email.Text = dataGridView1.CurrentRow.Cells["email"].Value?.ToString();
            Username.Text = dataGridView1.CurrentRow.Cells["ten_dang_nhap"].Value?.ToString();
            Password.Text = dataGridView1.CurrentRow.Cells["mat_khau"].Value?.ToString();

            if (dataGridView1.CurrentRow.Cells["ngay_sinh"].Value != DBNull.Value)
            {
                dateTimePicker1.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells["ngay_sinh"].Value);
            }
        }

        private void ButtonTimKiem_Click(object sender, EventArgs e)
        {
            if (Username.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập cần tìm");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string query = @"
        SELECT tai_khoan.id,
               ho_ten,
               ngay_sinh,
               gioi_tinh,
               role.name AS chuc_vu,
               so_dien_thoai,
               dia_chi,
               email,
               ten_dang_nhap,
               mat_khau
        FROM tai_khoan
        JOIN role ON tai_khoan.role_id = role.id
        WHERE ten_dang_nhap COLLATE SQL_Latin1_General_CP1_CS_AS = @username";

                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.SelectCommand.Parameters.AddWithValue("@username", Username.Text.Trim());

                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy");
                    return;
                }

                dataGridView1.DataSource = dt;
            }
        }

        private void ButtonReload_Click(object sender, EventArgs e)
        {
            textBoxHoten.Clear();
            textBoxSDT.Clear();
            DiaChi.Clear();
            Email.Clear();
            Username.Clear();
            Password.Clear();

            GioiTinh.SelectedIndex = -1;
            ChucVu.SelectedIndex = -1;

            dateTimePicker1.Value = DateTime.Now;
            LoadData();
        }
    }
}