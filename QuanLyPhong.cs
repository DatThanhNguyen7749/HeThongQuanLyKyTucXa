using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HeThongQuanLyKyTucXa
{
    public partial class QuanLyPhong : Form
    {
        string connStr = @"Data Source=.;Initial Catalog=QLKTX234;Integrated Security=True";

        public QuanLyPhong()
        {
            InitializeComponent();

            this.Load += QuanLyPhong_Load;
            dataGridView1.CellClick += dataGridView1_CellClick;
        }

        // ================= LOAD FORM =================
        private void QuanLyPhong_Load(object sender, EventArgs e)
        {
            TrangThai.Items.Clear();
            TrangThai.Items.Add("Kích hoạt");
            TrangThai.Items.Add("Hủy kích hoạt");

            LoaiPhong.Items.Clear();
            LoaiPhong.Items.Add("Nam");
            LoaiPhong.Items.Add("Nữ");

            CapNhatSoLuongSinhVien();
            LoadData();
        }

        // ================= CẬP NHẬT SỐ LƯỢNG SV =================
        void CapNhatSoLuongSinhVien()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();

                    string query = @"
                    UPDATE phong
                    SET so_luong_sv = (
                        SELECT COUNT(*)
                        FROM hop_dong
                        WHERE hop_dong.phong_id = phong.id
                    )";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi cập nhật số lượng sinh viên: " + ex.Message);
            }
        }

        // ================= LOAD DATA =================
        void LoadData()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();

                    string query = @"SELECT 
                                    ma_phong,
                                    trang_thai,
                                    loai_phong,
                                    so_dien,
                                    so_nuoc,
                                    so_luong_sv,
                                    suc_chua
                                    FROM phong";

                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dataGridView1.DataSource = dt;
                    FormatDGV();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi load: " + ex.Message);
            }
        }

        // ================= FORMAT =================
        void FormatDGV()
        {
            if (dataGridView1.Columns.Count == 0) return;

            dataGridView1.Columns["ma_phong"].HeaderText = "Mã phòng";
            dataGridView1.Columns["trang_thai"].HeaderText = "Trạng thái";
            dataGridView1.Columns["loai_phong"].HeaderText = "Loại phòng";
            dataGridView1.Columns["so_dien"].HeaderText = "Số điện";
            dataGridView1.Columns["so_nuoc"].HeaderText = "Số nước";
            dataGridView1.Columns["so_luong_sv"].HeaderText = "Số lượng SV";
            dataGridView1.Columns["suc_chua"].HeaderText = "Sức chứa";

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        // ================= CLICK =================
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn dòng hợp lệ!");
                return;
            }

            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

            if (row.IsNewRow || row.Cells["ma_phong"].Value == null)
            {
                MessageBox.Show("Dòng không hợp lệ!");
                return;
            }

            MaPhong.Text = row.Cells["ma_phong"].Value.ToString();
            TrangThai.Text = row.Cells["trang_thai"].Value.ToString();
            LoaiPhong.Text = row.Cells["loai_phong"].Value.ToString();
        }

        // ================= VALIDATE =================
        bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(MaPhong.Text) ||
                string.IsNullOrWhiteSpace(TrangThai.Text) ||
                string.IsNullOrWhiteSpace(LoaiPhong.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return false;
            }

            if (!int.TryParse(MaPhong.Text, out _))
            {
                MessageBox.Show("Mã phòng phải là số!");
                return false;
            }

            return true;
        }

        // ================= CLEAR =================
        void ClearForm()
        {
            MaPhong.Clear();
            TrangThai.SelectedIndex = -1;
            LoaiPhong.SelectedIndex = -1;
        }

        // ================= THÊM =================
        private void buttonThem_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;

            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();

                    string check = "SELECT COUNT(*) FROM phong WHERE ma_phong=@ma";
                    SqlCommand cmdCheck = new SqlCommand(check, conn);
                    cmdCheck.Parameters.AddWithValue("@ma", MaPhong.Text);

                    int count = (int)cmdCheck.ExecuteScalar();
                    if (count > 0)
                    {
                        MessageBox.Show("Mã phòng đã tồn tại!");
                        return;
                    }

                    string query = @"INSERT INTO phong
                    (ma_phong, so_dien, loai_phong, so_nuoc, trang_thai, so_luong_sv, suc_chua)
                    VALUES (@ma, 0, @loai, 0, @trangthai, 0, 8)";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ma", MaPhong.Text);
                    cmd.Parameters.AddWithValue("@loai", LoaiPhong.Text);
                    cmd.Parameters.AddWithValue("@trangthai", TrangThai.Text);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Thêm thành công!");
                CapNhatSoLuongSinhVien();
                LoadData();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm: " + ex.Message);
            }
        }

        // ================= SỬA =================
        private void buttonSua_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null || dataGridView1.CurrentRow.IsNewRow)
            {
                MessageBox.Show("Chọn dòng hợp lệ!");
                return;
            }

            if (!ValidateInput()) return;

            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();

                    string query = @"UPDATE phong 
                                     SET loai_phong=@loai,
                                         trang_thai=@trangthai
                                     WHERE ma_phong=@ma";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ma", MaPhong.Text);
                    cmd.Parameters.AddWithValue("@loai", LoaiPhong.Text);
                    cmd.Parameters.AddWithValue("@trangthai", TrangThai.Text);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Cập nhật thành công!");
                CapNhatSoLuongSinhVien();
                LoadData();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi sửa: " + ex.Message);
            }
        }

        // ================= XÓA =================
        private void buttonXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null || dataGridView1.CurrentRow.IsNewRow)
            {
                MessageBox.Show("Chọn dòng hợp lệ!");
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();

                    // lấy id phòng
                    string getId = "SELECT id FROM phong WHERE ma_phong=@ma";
                    SqlCommand cmdGet = new SqlCommand(getId, conn);
                    cmdGet.Parameters.AddWithValue("@ma", MaPhong.Text.Trim());

                    object result = cmdGet.ExecuteScalar();

                    if (result == null)
                    {
                        MessageBox.Show("Không tìm thấy phòng!");
                        return;
                    }

                    int phongId = Convert.ToInt32(result);

                    // kiểm tra có hợp đồng không
                    string checkHopDong = "SELECT COUNT(*) FROM hop_dong WHERE phong_id=@id";
                    SqlCommand cmdCheck = new SqlCommand(checkHopDong, conn);
                    cmdCheck.Parameters.AddWithValue("@id", phongId);

                    int count = (int)cmdCheck.ExecuteScalar();

                    if (count > 0)
                    {
                        MessageBox.Show("Phải xóa hợp đồng trước!");
                        return;
                    }

                    // nếu không có hợp đồng thì hỏi xác nhận
                    DialogResult r = MessageBox.Show("Bạn có chắc muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo);

                    if (r == DialogResult.No) return;

                    // xóa phòng
                    string deletePhong = "DELETE FROM phong WHERE id=@id";
                    SqlCommand cmdPhong = new SqlCommand(deletePhong, conn);
                    cmdPhong.Parameters.AddWithValue("@id", phongId);

                    cmdPhong.ExecuteNonQuery();
                }

                MessageBox.Show("Xóa thành công!");
                CapNhatSoLuongSinhVien();
                LoadData();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xóa: " + ex.Message);
            }
        }
        // ================= TÌM KIẾM =================
        private void buttonTimKiem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(MaPhong.Text) &&
                string.IsNullOrWhiteSpace(LoaiPhong.Text) &&
                string.IsNullOrWhiteSpace(TrangThai.Text))
            {
                MessageBox.Show("Nhập ít nhất 1 điều kiện tìm kiếm!");
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();

                    string query = @"SELECT 
                                    ma_phong,
                                    trang_thai,
                                    loai_phong,
                                    so_dien,
                                    so_nuoc,
                                    so_luong_sv,
                                    suc_chua
                                    FROM phong WHERE 
                                    (@ma = '' OR ma_phong = @ma)
                                    AND (@loai = '' OR loai_phong = @loai)
                                    AND (@trangthai = '' OR trang_thai = @trangthai)";

                    SqlCommand cmd = new SqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@ma", MaPhong.Text.Trim());
                    cmd.Parameters.AddWithValue("@loai", LoaiPhong.Text.Trim());
                    cmd.Parameters.AddWithValue("@trangthai", TrangThai.Text.Trim());

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("Không tìm thấy dữ liệu!");
                        dataGridView1.DataSource = null;
                        return;
                    }

                    dataGridView1.DataSource = dt;
                    FormatDGV();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tìm kiếm: " + ex.Message);
            }
        }

        // ================= RELOAD =================
        private void buttonReload_Click(object sender, EventArgs e)
        {
            CapNhatSoLuongSinhVien();
            LoadData();
            ClearForm();
        }
    }
}