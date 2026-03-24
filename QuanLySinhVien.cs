using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;
using System.Drawing;

namespace QuanLySinhVien
{
    public partial class QuanLySinhVien : Form
    {
        string connStr = @"Data Source=DESKTOP-3LV16NF;Initial Catalog=KTX;Integrated Security=True;Encrypt=False;TrustServerCertificate=True";

        int currentID = -1;

        public QuanLySinhVien()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SetReadOnly(true);

           

            dataGridView1.DataSource = null; // không load lúc đầu
        }

        // ================= LOAD =================
        void LoadData()
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                string query = "SELECT * FROM sinh_vien";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;

                if (dataGridView1.Columns.Contains("id"))
                    dataGridView1.Columns["id"].Visible = false;
            }

            SetHeader();
        }

        // ================= HEADER =================
        void SetHeader()
        {
            if (dataGridView1.Columns.Count == 0) return;

            dataGridView1.Columns["ma_sinh_vien"].HeaderText = "Mã SV";
            dataGridView1.Columns["ten_sinh_vien"].HeaderText = "Tên sinh viên";
            dataGridView1.Columns["gioi_tinh"].HeaderText = "Giới tính";
            dataGridView1.Columns["ngay_sinh"].HeaderText = "Ngày sinh";
            dataGridView1.Columns["ten_nganh"].HeaderText = "Ngành học";
            dataGridView1.Columns["so_dien_thoai"].HeaderText = "SĐT";
            dataGridView1.Columns["email"].HeaderText = "Email";
            dataGridView1.Columns["dia_chi_thuong_tru"].HeaderText = "Địa chỉ";
            dataGridView1.Columns["cccd"].HeaderText = "CCCD";

           
            

            dataGridView1.RowTemplate.Height = 30;
        }

        // ================= READONLY =================
        void SetReadOnly(bool status)
        {
            txtTenSV.ReadOnly = status;
            txtSDT.ReadOnly = status;
            txtEmail.ReadOnly = status;
            txtDiaChi.ReadOnly = status;
            txtCCCD.ReadOnly = status;
            txtNganh.ReadOnly = status;
        }

        void ClearInput()
        {
            txtMaSV.Clear();
            txtTenSV.Clear();
            txtSDT.Clear();
            txtEmail.Clear();
            txtDiaChi.Clear();
            txtCCCD.Clear();
            txtNganh.Clear();
            currentID = -1;
        }

        // ================= VALIDATE =================
        bool KiemTraNhap()
        {
            if (string.IsNullOrWhiteSpace(txtMaSV.Text) ||
                string.IsNullOrWhiteSpace(txtTenSV.Text) ||
                string.IsNullOrWhiteSpace(txtSDT.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtDiaChi.Text) ||
                string.IsNullOrWhiteSpace(txtCCCD.Text) ||
                string.IsNullOrWhiteSpace(txtNganh.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!",
                                "Lỗi",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        string GetGioiTinh()
        {
            return rdoNam.Checked ? "Nam" : "Nữ";
        }

        // ================= CELL CLICK =================
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = dataGridView1.Rows[e.RowIndex];

            if (row.Cells["id"].Value == null || row.Cells["id"].Value.ToString() == "")
            {
                MessageBox.Show("Vui lòng nhập thông tin!",
                                "Lỗi",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);

                LoadData();
                ClearInput();
                return;
            }

            currentID = Convert.ToInt32(row.Cells["id"].Value);

            txtMaSV.Text = row.Cells["ma_sinh_vien"].Value?.ToString() ?? "";
            txtTenSV.Text = row.Cells["ten_sinh_vien"].Value?.ToString() ?? "";
            txtSDT.Text = row.Cells["so_dien_thoai"].Value?.ToString() ?? "";
            txtEmail.Text = row.Cells["email"].Value?.ToString() ?? "";
            txtDiaChi.Text = row.Cells["dia_chi_thuong_tru"].Value?.ToString() ?? "";
            txtCCCD.Text = row.Cells["cccd"].Value?.ToString() ?? "";
            txtNganh.Text = row.Cells["ten_nganh"].Value?.ToString() ?? "";

            if (row.Cells["ngay_sinh"].Value != null)
                dtpNgaySinh.Value = Convert.ToDateTime(row.Cells["ngay_sinh"].Value);

            string gt = row.Cells["gioi_tinh"].Value?.ToString();
            if (gt == "Nam") rdoNam.Checked = true;
            else rdoNu.Checked = true;

            SetReadOnly(true);
        }

        // ================= THÊM =================
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!KiemTraNhap()) return;

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();

                string check = "SELECT COUNT(*) FROM sinh_vien WHERE ma_sinh_vien=@Ma";
                SqlCommand cmdCheck = new SqlCommand(check, conn);
                cmdCheck.Parameters.AddWithValue("@Ma", txtMaSV.Text);

                if ((int)cmdCheck.ExecuteScalar() > 0)
                {
                    MessageBox.Show("Mã sinh viên đã tồn tại!",
                                    "Lỗi",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                    return;
                }

                string query = @"INSERT INTO sinh_vien
                (ma_sinh_vien, ten_sinh_vien, gioi_tinh, ngay_sinh, ten_nganh, so_dien_thoai, email, dia_chi_thuong_tru, cccd)
                VALUES (@Ma,@Ten,@GT,@NS,@Nganh,@SDT,@Email,@DC,@CCCD)";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Ma", txtMaSV.Text);
                cmd.Parameters.AddWithValue("@Ten", txtTenSV.Text);
                cmd.Parameters.AddWithValue("@GT", GetGioiTinh());
                cmd.Parameters.AddWithValue("@NS", dtpNgaySinh.Value);
                cmd.Parameters.AddWithValue("@Nganh", txtNganh.Text);
                cmd.Parameters.AddWithValue("@SDT", txtSDT.Text);
                cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@DC", txtDiaChi.Text);
                cmd.Parameters.AddWithValue("@CCCD", txtCCCD.Text);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Thêm thành công!", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadData();
                ClearInput();
            }
        }

        // ================= TÌM KIẾM =================
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaSV.Text))
            {
                MessageBox.Show("Vui lòng nhập mã sinh viên!",
                                "Lỗi",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();

                string query = "SELECT * FROM sinh_vien WHERE ma_sinh_vien=@Ma";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.SelectCommand.Parameters.AddWithValue("@Ma", txtMaSV.Text);

                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Mã sinh viên không tồn tại!",
                                    "Lỗi",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                    currentID = -1;
                    return;
                }

                dataGridView1.DataSource = dt;
                SetHeader();
            }
        }

        // ================= SỬA =================
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (currentID == -1)
            {
                MessageBox.Show("Vui lòng chọn sinh viên!",
                                "Cảnh báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            SetReadOnly(false);
        }

        // ================= CẬP NHẬT =================
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (currentID == -1)
            {
                MessageBox.Show("Vui lòng chọn sinh viên!",
                                "Cảnh báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            if (!KiemTraNhap()) return;

            if (MessageBox.Show("Bạn có chắc muốn sửa không?",
                                "Xác nhận",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question) == DialogResult.No)
                return;

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();

                string query = @"UPDATE sinh_vien SET
                ten_sinh_vien=@Ten,
                gioi_tinh=@GT,
                ngay_sinh=@NS,
                ten_nganh=@Nganh,
                so_dien_thoai=@SDT,
                email=@Email,
                dia_chi_thuong_tru=@DC,
                cccd=@CCCD
                WHERE id=@ID";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ID", currentID);
                cmd.Parameters.AddWithValue("@Ten", txtTenSV.Text);
                cmd.Parameters.AddWithValue("@GT", GetGioiTinh());
                cmd.Parameters.AddWithValue("@NS", dtpNgaySinh.Value);
                cmd.Parameters.AddWithValue("@Nganh", txtNganh.Text);
                cmd.Parameters.AddWithValue("@SDT", txtSDT.Text);
                cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@DC", txtDiaChi.Text);
                cmd.Parameters.AddWithValue("@CCCD", txtCCCD.Text);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Cập nhật thành công!", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadData();
                ClearInput();
            }
        }

        // ================= XÓA =================
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (currentID == -1)
            {
                MessageBox.Show("Vui lòng chọn sinh viên!",
                                "Cảnh báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Bạn có chắc muốn xóa không?",
                                "Xác nhận",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question) == DialogResult.No)
                return;

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
            // ===== CHECK HỢP ĐỒNG =====
                string checkHD = "SELECT COUNT(*) FROM hop_dong WHERE sinh_vien_id=@ID";
                SqlCommand cmdCheck = new SqlCommand(checkHD, conn);
                cmdCheck.Parameters.AddWithValue("@ID", currentID);

                int count = (int)cmdCheck.ExecuteScalar();

                if (count > 0)
                {
                    MessageBox.Show("Sinh viên này đang có hợp đồng, không thể xóa!",
                    "Cảnh báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                    return;
                }

// ===== XÓA =====
string query = "DELETE FROM sinh_vien WHERE id=@ID";
SqlCommand cmd = new SqlCommand(query, conn);
cmd.Parameters.AddWithValue("@ID", currentID);

cmd.ExecuteNonQuery();

MessageBox.Show("Xóa thành công!",
                "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

                LoadData();
                ClearInput();
            }
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            ClearInput();
        }
    }
}
