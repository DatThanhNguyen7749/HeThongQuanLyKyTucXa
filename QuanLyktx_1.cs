using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace HeThongQuanLyKyTucXa
{
    public partial class QuanLyktx_1 : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = "Data Source=.;Initial Catalog=QLKTX234;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        void loaddata()
        {
           
            command = connection.CreateCommand();
            command.CommandText =  @"SELECT hd.*, p.ma_phong 
                                FROM hoa_don_dich_vu hd
                                INNER JOIN phong p ON hd.phong_id = p.id";

            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgvHoaDon.AutoGenerateColumns = false;
            dgvHoaDon.DataSource = table;

        }
        public QuanLyktx_1()
        {
            InitializeComponent();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnInHoaDon_Click(object sender, EventArgs e)
        {



        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtDienMoi_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtDienCu_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtDonGiaDien_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDienMoi_TextChanged_1(object sender, EventArgs e)
        {

        }
        private void btnCapNhatDichVu_Click(object sender, EventArgs e)
        {
            // Khởi tạo đối tượng Form mới
            frmCapNhatDichVu f = new frmCapNhatDichVu();

            // Hiển thị Form dưới dạng hội thoại (người dùng phải đóng mới quay lại được form cũ)
            f.ShowDialog();
            LayDonGiaDichVu(); // ...thì cập nhật lại giá mới ở đây
        }

        private void QuanLyktx_1_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loaddata();
            LayDonGiaDichVu();
            LoadComboBoxPhong();
        }
        void LayDonGiaDichVu()
        {
            try
            {
                if (connection.State == ConnectionState.Closed) connection.Open();

                // Lấy toàn bộ bảng dịch vụ
                string sql = "SELECT ma_dich_vu, don_gia FROM dich_vu";
                SqlCommand cmd = new SqlCommand(sql, connection);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int ma = Convert.ToInt32(reader["ma_dich_vu"]);
                    string gia = reader["don_gia"].ToString();

                    // Điền vào các TextBox tương ứng dựa trên mã dịch vụ đã tạo
                    if (ma == 101) txtDonGiaDien.Text = gia;      // Tiền điện
                    if (ma == 102) txtDonGiaNuoc.Text = gia;      // Tiền nước
                    if (ma == 103) txtTienDVChung.Text = gia;     // Tiền dịch vụ chung
                    if (ma == 104) txtTienPhatSinh.Text = gia;    // Chi phí phát sinh
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi lấy đơn giá: " + ex.Message);
            }
            finally { connection.Close(); }
        }

        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
        }
        private void LoadComboBoxPhong()
        {
            string sql = "SELECT id, ma_phong FROM phong";
            SqlDataAdapter da = new SqlDataAdapter(sql, connection); // connection là chuỗi kết nối của bạn
            DataTable dt = new DataTable();
            da.Fill(dt);

            cboMaPhong.DataSource = dt;
            cboMaPhong.DisplayMember = "ma_phong"; // Hiển thị số 101, 102...
            cboMaPhong.ValueMember = "id";         // Giá trị thực tế là 1, 2...

            // Để trống lúc mới load form (tùy chọn)
            cboMaPhong.SelectedIndex = -1;
        }
        private void cboMaPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Kiểm tra: 1. Có chọn gì không? 2. Có phải đang lúc load dữ liệu tạm (DataRowView) không?
            if (cboMaPhong.SelectedValue != null && !(cboMaPhong.SelectedValue is DataRowView))
            {
                try
                {
                    // Bây giờ SelectedValue chắc chắn là ID (số 1, 2...)
                    string phongId = cboMaPhong.SelectedValue.ToString();

                    if (connection.State == ConnectionState.Closed) connection.Open();

                    string sql = "SELECT so_dien, so_nuoc FROM phong WHERE id = @id";
                    SqlCommand cmd = new SqlCommand(sql, connection);
                    cmd.Parameters.AddWithValue("@id", phongId);

                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        // Điền số điện/nước cũ vào TextBox
                        txtDienCu.Text = reader["so_dien"].ToString();
                        txtNuocCu.Text = reader["so_nuoc"].ToString();
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi đối chiếu dữ liệu: " + ex.Message);
                }
                finally { connection.Close(); }
            }
        }
        private void TinhToanTongTien()
        {
            try
            {
                // 1. Tính tiền điện
                double dienCu = 0, dienMoi = 0, dgDien = 0;
                double.TryParse(txtDienCu.Text, out dienCu);
                double.TryParse(txtDienMoi_1.Text, out dienMoi); // Kiểm tra lại tên TextBox điện mới của bạn
                double.TryParse(txtDonGiaDien.Text, out dgDien);

                double tieuThuDien = dienMoi - dienCu;
                if (tieuThuDien < 0) tieuThuDien = 0;

                txtSoDien1.Text = tieuThuDien.ToString(); // Ô hiển thị "Tiêu thụ" điện
                double thanhTienDien = tieuThuDien * dgDien;
                txtTienDien.Text = thanhTienDien.ToString();

                // 2. Tính tiền nước
                double nuocCu = 0, nuocMoi = 0, dgNuoc = 0;
                double.TryParse(txtNuocCu.Text, out nuocCu);
                double.TryParse(txtNuocMoi.Text, out nuocMoi);
                double.TryParse(txtDonGiaNuoc.Text, out dgNuoc);

                double tieuThuNuoc = nuocMoi - nuocCu;
                if (tieuThuNuoc < 0) tieuThuNuoc = 0;

                txtSoNuoc.Text = tieuThuNuoc.ToString(); // Ô hiển thị "Tiêu thụ" nước
                double thanhTienNuoc = tieuThuNuoc * dgNuoc;
                txtTienNuoc.Text = thanhTienNuoc.ToString();

                // 3. Cộng tổng tất cả
                double tienDVChung = 0, tienPhatSinh = 0;
                double.TryParse(txtTienDVChung.Text, out tienDVChung);
                double.TryParse(txtTienPhatSinh.Text, out tienPhatSinh);

                double tongCong = thanhTienDien + thanhTienNuoc + tienDVChung + tienPhatSinh;
                txtTongTien.Text = tongCong.ToString(); // Ô "Tổng tiền dịch vụ"
            }
            catch
            {
                // Tránh crash nếu người dùng nhập chữ thay vì số
            }
        }

        private void txtDienMoi_1_TextChanged(object sender, EventArgs e)
        {
            TinhToanTongTien();
        }

        private void txtNuocMoi_TextChanged(object sender, EventArgs e)
        {
            TinhToanTongTien();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (connection.State == ConnectionState.Closed) connection.Open();

                // 1. Ép kiểu để bắt lỗi nhập chữ (FormatException)
                int dienMoi = int.Parse(txtDienMoi_1.Text);
                int nuocMoi = int.Parse(txtNuocMoi.Text);

                // 2. Lệnh Thêm hóa đơn (Đã bổ sung đầy đủ các cột còn thiếu)
                string sqlIn = @"INSERT INTO hoa_don_dich_vu 
                        (ma_hoa_don, phong_id, ngay_tao, thang_thu, tien_dien, tien_nuoc, tien_dv, chi_phi_phat_sinh, tong_tien, trang_thai) 
                        VALUES (@ma, @id, @ngay, @thang, @tdien, @tnuoc, @tdv, @cpps, @tong, @tt)";

                SqlCommand cmd1 = new SqlCommand(sqlIn, connection);
                cmd1.Parameters.AddWithValue("@ma", txtMaHD.Text);
                cmd1.Parameters.AddWithValue("@id", cboMaPhong.SelectedValue);
                cmd1.Parameters.AddWithValue("@ngay", dtpNgayTao.Value); // Dùng DateTimePicker
                cmd1.Parameters.AddWithValue("@thang", txtThangThu.Text);
                cmd1.Parameters.AddWithValue("@tdien", txtTienDien.Text);
                cmd1.Parameters.AddWithValue("@tnuoc", txtTienNuoc.Text);
                cmd1.Parameters.AddWithValue("@tdv", txtTienDVChung.Text);
                cmd1.Parameters.AddWithValue("@cpps", txtTienPhatSinh.Text);
                cmd1.Parameters.AddWithValue("@tong", txtTongTien.Text);

                // Lấy trạng thái từ RadioButton
                string trangThai = radDaThanhToan.Checked ? "Đã thanh toán" : "Chưa thanh toán";
                cmd1.Parameters.AddWithValue("@tt", trangThai);

                cmd1.ExecuteNonQuery();

                // 3. Lệnh Cập nhật chỉ số mới vào bảng phòng
                string sqlUp = "UPDATE phong SET so_dien = @d, so_nuoc = @n WHERE id = @id";
                SqlCommand cmd2 = new SqlCommand(sqlUp, connection);
                cmd2.Parameters.AddWithValue("@d", dienMoi);
                cmd2.Parameters.AddWithValue("@n", nuocMoi);
                cmd2.Parameters.AddWithValue("@id", cboMaPhong.SelectedValue);
                cmd2.ExecuteNonQuery();

                MessageBox.Show("Thêm hóa đơn thành công!");
                loaddata();

                // --- CÂU LỆNH CLEAR SAU KHI THÊM ---
                txtMaHD.Clear();
                txtThangThu.Clear();
                txtDienMoi_1.Clear();
                txtNuocMoi.Clear();
                cboMaPhong.SelectedIndex = -1;
                txtDienCu.Text = "Cũ";
                txtNuocCu.Text = "Cũ";
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627 || ex.Number == 2601) MessageBox.Show("Lỗi: Mã hóa đơn đã tồn tại!");
                else MessageBox.Show("Lỗi SQL: " + ex.Message);
            }
            catch (FormatException)
            {
                MessageBox.Show("Lỗi: Kiểm tra lại các ô nhập số (Điện/Nước mới)!");
            }
            finally { connection.Close(); }
        }

        private void dgvHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // 1. Kiểm tra nếu click vào dòng tiêu đề (Index -1) hoặc dòng trống thì bỏ qua
            if (e.RowIndex < 0) return;

            // 2. Lấy dòng dữ liệu hiện tại
            DataGridViewRow row = dgvHoaDon.Rows[e.RowIndex];

            try
            {
                // --- THÔNG TIN HÓA ĐƠN ---
                // Column 1: Mã HĐ
                txtMaHD.Text = Convert.ToString(row.Cells[1].Value);

                // Column 4: Ngày tạo (Đổ vào DateTimePicker)
              
                
                    dtpNgayTao.Value = Convert.ToDateTime(row.Cells[3].Value);
                

                // Column 5: Tháng thu
                txtThangThu.Text = Convert.ToString(row.Cells[4].Value);

                // Column 11: Trạng thái (Xử lý RadioButton)
                string trangThai = Convert.ToString(row.Cells[10].Value);
                if (trangThai == "Đã thanh toán")
                {
                    radDaThanhToan.Checked = true;
                }
                else
                {
                    radChuaThanhToan.Checked = true;
                }

                // --- THÔNG TIN PHÒNG ---
                // Column 3: Mã phòng (Ví dụ: 101, 102...) đổ vào ComboBox
                cboMaPhong.Text = Convert.ToString(row.Cells[2].Value);

                // --- THÔNG TIN TIỀN DỊCH VỤ ---
                // Column 6: Tiền điện
                txtTienDien.Text = Convert.ToString(row.Cells[5].Value);

                // Column 7: Tiền nước
                txtTienNuoc.Text = Convert.ToString(row.Cells[6].Value);

                // Column 8: Tiền DV
                txtTienDVChung.Text = Convert.ToString(row.Cells[7].Value);

                // Column 9: CPPS (Chi phí phát sinh)
                txtTienPhatSinh.Text = Convert.ToString(row.Cells[8].Value);

                // Column 10: Tổng tiền
                txtTongTien.Text = Convert.ToString(row.Cells[9].Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lấy dữ liệu: " + ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvHoaDon.CurrentRow == null) return;

            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa hóa đơn này?", "Xác nhận", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                try
                {
                    if (connection.State == ConnectionState.Closed) connection.Open();
                    // Lấy ID hóa đơn từ dòng đang chọn (Cột 0)
                    string idHD = dgvHoaDon.CurrentRow.Cells[0].Value.ToString();

                    string sql = "DELETE FROM hoa_don_dich_vu WHERE id = @id";
                    SqlCommand cmd = new SqlCommand(sql, connection);
                    cmd.Parameters.AddWithValue("@id", idHD);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Xóa thành công!");
                    loaddata(); // Tải lại bảng
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
                finally { connection.Close(); }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // 1. Xóa các thông tin định danh và thời gian
            txtMaHD.Clear();
            txtThangThu.Clear();

            // 2. Xóa các chỉ số điện nước (Mới và Tiêu thụ)
            txtDienMoi_1.Clear();
            txtNuocMoi.Clear();
            txtSoDien1.Clear();
            txtSoNuoc.Clear();

            // 3. Reset các ô chỉ số Cũ về trạng thái mặc định
            txtDienCu.Text = "Cũ";
            txtNuocCu.Text = "Cũ";
            txtSoDien1.Text= "Tiêu thụ";
            txtSoNuoc.Text = "Tiêu thụ";


            // 4. Xóa các ô thành tiền và tổng tiền
            txtTienDien.Clear();
            txtTienNuoc.Clear();
            txtTongTien.Clear();

            // 5. Reset ComboBox phòng và Trạng thái
            cboMaPhong.SelectedIndex = -1;
            radChuaThanhToan.Checked = true; // Mặc định là chưa thanh toán khi tạo mới

            // 6. Đưa con trỏ chuột về ô Mã hóa đơn để bắt đầu nhập tiếp
            txtMaHD.Focus();

            // LƯU Ý: Các ô dtpNgayTao, txtDonGiaDien, txtDonGiaNuoc, 
            // txtTienDVChung, txtTienPhatSinh được GIỮ NGUYÊN như bạn yêu cầu.
        }
        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (connection.State == ConnectionState.Closed) connection.Open();

                // Câu lệnh SELECT rút gọn: Lọc theo Mã HĐ hoặc Mã phòng
                string sql = @"SELECT hd.*, p.ma_phong 
                        FROM hoa_don_dich_vu hd
                        INNER JOIN phong p ON hd.phong_id = p.id
                        WHERE hd.ma_hoa_don LIKE @key OR p.ma_phong LIKE @key";

                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@key", "%" + txtTimKiem.Text + "%");

                DataTable dt = new DataTable();
                new SqlDataAdapter(cmd).Fill(dt);
                dgvHoaDon.DataSource = dt;
            }
            catch { }
            finally { connection.Close(); }
        }
    }
}
 

