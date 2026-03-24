using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace HeThongQuanLyKyTucXa
{
    public partial class HopDong : Form
    {
        Form formTruoc;
        string connStr = @"Data Source=DELL\SQLEXPRESS;Initial Catalog=QuanLyKTX;Integrated Security=True";
        SqlConnection conn = null;
        public HopDong(Form formBefore)
        {
            InitializeComponent();
            formTruoc = formBefore;
        }

        private bool checkNgayHetHan()
        {
            DateTime ngayLap = dateTimePickerNgayLap.Value;
            DateTime ngayHet = dateTimePickerNgayHetHan.Value;

            DateTime minNgayHetHan = ngayLap.AddMonths(6);

            if (ngayHet < minNgayHetHan)
            {

                return false;
            }

            return true;
        }

        void CapNhatHopDongHetHan()
        {
            string sql = @"
            UPDATE phong
            SET so_luong_sv = so_luong_sv - 1
            WHERE id IN (
                SELECT phong_id FROM hop_dong
                WHERE ngay_ket_thuc < GETDATE()
                AND tinh_trang_hieu_luc = N'Còn hiệu lực'
            )";

            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();

            // cập nhật trạng thái hợp đồng
            string updateHD = @"
            UPDATE hop_dong
            SET tinh_trang_hieu_luc = N'Hết hạn'
            WHERE ngay_ket_thuc < GETDATE()";

            SqlCommand cmd2 = new SqlCommand(updateHD, conn);
            cmd2.ExecuteNonQuery();
        }

        void ClearControls()
        {
            textBoxHoten.Clear();
            textBoxCCCD.Clear();
            textBoxDiachi.Clear();
            textBoxGia.Clear();
            textBoxMaHD.Clear();
            textBoxMsv.Clear();
            textBoxSDT.Clear();
            textBoxSoLuongSV.Clear();
            comboBoxLoaiPhong.ResetText();
            comboBoxSoPhong.ResetText();
            dateTimePickerNgayLap.ResetText();
            dateTimePickerNgayHetHan.Value = dateTimePickerNgayLap.Value.AddMonths(6);
            radioButtonChuaPay.Checked = false;
            radioButtonDaPay.Checked = false;
            radioButtonConHieuLuc.Checked = false;
            radioButtonHetHan.Checked = false;
            radioButtonNam_QLHD.Checked = false;
            radioButtonNu_QLHD.Checked = false;
        }

        //Bảng data hop dong
        void LoadHopDong()
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();

                string query = @"
                SELECT hd.id, hd.ma_hop_dong, sv.ma_sinh_vien, sv.ten_sinh_vien,
               sv.so_dien_thoai, sv.cccd,
               p.ma_phong,
               hd.ngay_bat_dau, hd.ngay_ket_thuc,
               hd.tinh_trang_hieu_luc, hd.tinh_trang_thanh_toan
               FROM hop_dong hd
               JOIN sinh_vien sv ON hd.sinh_vien_id = sv.id
               JOIN phong p ON hd.phong_id = p.id";

               SqlDataAdapter da = new SqlDataAdapter(query, conn);
               DataTable dt = new DataTable();
               da.Fill(dt);

               dataGridView1.DataSource = dt;
               dataGridView1.Columns["id"].Visible = false;
               dataGridView1.Columns["ma_hop_dong"].HeaderText = "Mã hợp đồng";
               dataGridView1.Columns["ma_sinh_vien"].HeaderText = "Mã sinh viên";
               dataGridView1.Columns["ten_sinh_vien"].HeaderText = "Họ và tên";
               dataGridView1.Columns["so_dien_thoai"].HeaderText = "SĐT";
               dataGridView1.Columns["cccd"].HeaderText = "CCCD";
               dataGridView1.Columns["ma_phong"].HeaderText = "Số phòng";
               dataGridView1.Columns["ngay_bat_dau"].HeaderText = "Ngày lập";
               dataGridView1.Columns["ngay_ket_thuc"].HeaderText = "Ngày hết hạn";
               dataGridView1.Columns["tinh_trang_hieu_luc"].HeaderText = "Tình trạng hiệu lực";
               dataGridView1.Columns["tinh_trang_thanh_toan"].HeaderText = "Tình trạng thanh toán";
            }
        }

        //Du lieu bang data Phong
        void LoadPhong()
        {
            string query = "Select id, ma_phong,loai_phong ,so_luong_sv from phong WHERE so_luong_sv < suc_chua;";

            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            comboBoxSoPhong.DataSource = dt;
            comboBoxSoPhong.DisplayMember = "ma_phong"; // hiển thị
            comboBoxSoPhong.ValueMember = "id";         // giá trị thật

            dataGridViewPhong.DataSource = dt;
            dataGridViewPhong.Columns["id"].Visible = false;
            dataGridViewPhong.Columns["ma_phong"].HeaderText = "Số phòng";
            dataGridViewPhong.Columns["loai_phong"].HeaderText = "Loại phòng";
            dataGridViewPhong.Columns["so_luong_sv"].HeaderText = "Số lượng (Tối đa 8 sv)";
        }

        void layDLFromDTGV(DataGridViewRow row)// lấy dữ liệu từ dòng được chọn hoặc có cùng dữ liệu cần tìm ở bảng dgv rồi đẩy lên controls
        {
            textBoxMaHD.Text = row.Cells["ma_hop_dong"].Value.ToString();
            textBoxMsv.Text = row.Cells["ma_sinh_vien"].Value.ToString();
            comboBoxSoPhong.Text = row.Cells["ma_phong"].Value.ToString();
            string queryPhong = "Select loai_phong ,so_luong_sv from phong where ma_phong = " + comboBoxSoPhong.Text;
            SqlDataAdapter daPhong = new SqlDataAdapter(queryPhong, conn);
            DataTable dtPhong = new DataTable();
            daPhong.Fill(dtPhong);
            if (dtPhong.Rows.Count > 0)
            {
                DataRow rowPhong = dtPhong.Rows[0];

                textBoxSoLuongSV.Text = rowPhong["so_luong_sv"].ToString();
                comboBoxLoaiPhong.Text = rowPhong["loai_phong"].ToString();
            }

            string query = "SELECT * FROM sinh_vien WHERE ma_sinh_vien = " + row.Cells["ma_sinh_vien"].Value.ToString();
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                DataRow rowSV = dt.Rows[0];

                textBoxHoten.Text = rowSV["ten_sinh_vien"].ToString();
                textBoxCCCD.Text = rowSV["cccd"].ToString();
                textBoxSDT.Text = rowSV["so_dien_thoai"].ToString();
                textBoxDiachi.Text = rowSV["dia_chi_thuong_tru"].ToString();

                if (rowSV["gioi_tinh"].ToString() == "Nam")
                    radioButtonNam_QLHD.Checked = true;
                else
                    radioButtonNu_QLHD.Checked = true;
            }

            dateTimePickerNgayLap.Value = Convert.ToDateTime(row.Cells["ngay_bat_dau"].Value);
            dateTimePickerNgayHetHan.Value = Convert.ToDateTime(row.Cells["ngay_ket_thuc"].Value);
            if (row.Cells["tinh_trang_hieu_luc"].Value.ToString() == "Còn hiệu lực")
            {
                radioButtonConHieuLuc.Checked = true;
            }
            else
            {
                radioButtonHetHan.Checked = true;
            }

            if (row.Cells["tinh_trang_thanh_toan"].Value.ToString() == "Đã thanh toán")
            {
                radioButtonDaPay.Checked = true;
            }
            else
            {
                radioButtonChuaPay.Checked = true;
            }
        }

        void TimDLFromDGVHD()
        {
            string maHD = textBoxMaHD.Text.Trim();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (!row.IsNewRow)
                {
                    if (row.Cells["ma_hop_dong"].Value.ToString() == maHD)
                    {
                        layDLFromDTGV(row);
                        row.Selected = true;
                        dataGridView1.CurrentCell = row.Cells[0];
                        dataGridView1.FirstDisplayedScrollingRowIndex = row.Index;
                        return;
                    }
                }
            }
            MessageBox.Show("Không tìm thấy hợp đồng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void HopDong_Load(object sender, EventArgs e)
        {
            dateTimePickerNgayHetHan.Value = dateTimePickerNgayLap.Value.AddMonths(6);
            conn = new SqlConnection(connStr);
            conn.Open();

            LoadHopDong();

            LoadPhong();

            CapNhatHopDongHetHan();
        }

        private void LapHopDong_FormClosed(object sender, FormClosedEventArgs e)
        {
            formTruoc.Show();
        }

        private void textBoxGiaDV_TextChanged(object sender, EventArgs e)
        {
            int tienDV;
            try
            {
                if(textBoxGia.Text != "")
                {
                    tienDV = int.Parse(textBoxGia.Text);
                }
            }
            catch
            {
                MessageBox.Show("Giá chỉ được phép nhập số nguyên", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonLapHopDong_Click(object sender, EventArgs e)
        {
            if (textBoxMsv.Text == "" || textBoxHoten.Text == "" || textBoxCCCD.Text == ""
                || textBoxDiachi.Text == "" || textBoxSDT.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin cần thiết!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (checkNgayHetHan() != true)
            {
                MessageBox.Show("Ngày hết hạn phải ít nhất sau ngày lập 6 tháng!",
                                "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Xác nhận lập hợp đồng mới!", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                // Lấy ID sinh viên
                string sqlSV = "SELECT id FROM sinh_vien WHERE ma_sinh_vien = @msv";
                SqlCommand cmdSV = new SqlCommand(sqlSV, conn);
                cmdSV.Parameters.AddWithValue("@msv", textBoxMsv.Text);
                object svID = cmdSV.ExecuteScalar();

                // Lấy ID phòng
                int phongID = Convert.ToInt32(comboBoxSoPhong.SelectedValue);

                string sqlInsert = @"
                INSERT INTO hop_dong
                (ma_hop_dong, sinh_vien_id, phong_id, ngay_bat_dau, ngay_ket_thuc,
                tinh_trang_hieu_luc, gia_phong, thanh_tien, tinh_trang_thanh_toan)
                VALUES
                (@ma, @sv, @phong, @bd, @kt, @tt, @gia, @tong, @tttt)";

                SqlCommand cmd = new SqlCommand(sqlInsert, conn);

                string getMa = "SELECT ISNULL(MAX(ma_hop_dong),0) + 1 FROM hop_dong";
                SqlCommand cmdGetMa = new SqlCommand(getMa, conn);

                int newMaHD = (int)cmdGetMa.ExecuteScalar();

                cmd.Parameters.AddWithValue("@ma", newMaHD);
                cmd.Parameters.AddWithValue("@sv", svID);
                cmd.Parameters.AddWithValue("@phong", phongID);
                cmd.Parameters.AddWithValue("@bd", dateTimePickerNgayLap.Value);
                cmd.Parameters.AddWithValue("@kt", dateTimePickerNgayHetHan.Value = dateTimePickerNgayLap.Value.AddMonths(6));
                cmd.Parameters.AddWithValue("@tt", "Còn hiệu lực");
                cmd.Parameters.AddWithValue("@gia", 30000);
                cmd.Parameters.AddWithValue("@tong", 30000);
                cmd.Parameters.AddWithValue("@tttt", "Chưa thanh toán");

                cmd.ExecuteNonQuery();

                string updatePhongSql = "UPDATE phong SET so_luong_sv = so_luong_sv + 1 WHERE id = " + phongID;
                SqlCommand cmdUpdatePhong = new SqlCommand(updatePhongSql, conn);
                cmdUpdatePhong.ExecuteNonQuery();

                LoadHopDong();
                ClearControls();
                MessageBox.Show("Lập hợp đồng mới thành công!", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                return;
            }

        }

        private void buttonTimKiem_Click(object sender, EventArgs e)
        {
            if (textBoxMaHD.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã hợp đồng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (dataGridView1.Rows.Count <= 1 || dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Hiện không có hợp đồng nào!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            TimDLFromDGVHD();
        }

        //nút sửa hợp đồng
        private void buttonSua_Click(object sender, EventArgs e)
        {
            if (textBoxMaHD.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã hợp đồng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (dataGridView1.Rows.Count <= 1 || dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Hiện không có hợp đồng nào!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (textBoxHoten.Text == "" || textBoxSoLuongSV.Text == "")
            {
                return;
            }
            string checkTTHL = @"
            SELECT tinh_trang_hieu_luc 
            FROM hop_dong 
            WHERE ma_hop_dong = @ma";

            SqlCommand cmdTrangThai = new SqlCommand(checkTTHL, conn);
            cmdTrangThai.Parameters.AddWithValue("@ma", textBoxMaHD.Text);

            string trangThai = cmdTrangThai.ExecuteScalar()?.ToString();

            if (trangThai == "Hết hạn")
            {
                //chi cho sua thanh toan voi hop dong het han
                string sql = @"
                UPDATE hop_dong
                SET tinh_trang_thanh_toan = @tttt
                WHERE ma_hop_dong = @ma";
                string thanhtoan;

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ma", textBoxMaHD.Text);
                if (radioButtonDaPay.Checked == true)//cap nhat duy nhat voi trang thai thanh toan
                {
                    thanhtoan = "Đã thanh toán";
                }
                else
                {
                    thanhtoan = "Chưa thanh toán";
                }
                cmd.Parameters.AddWithValue("@tttt",thanhtoan);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Chỉ được cập nhật trạng thái thanh toán cho hợp đồng đã hết hạn!");
                LoadHopDong();
                TimDLFromDGVHD();
                ClearControls();
                return;
            }

            DialogResult result = MessageBox.Show("Xác nhận sửa thông tin hợp đồng!", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                string sql = @"
                UPDATE hop_dong
                SET ngay_bat_dau = @bd,
                    ngay_ket_thuc = @kt,
                    tinh_trang_hieu_luc = @tt,
                    tinh_trang_thanh_toan = @tttt
                WHERE ma_hop_dong = @ma";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@ma", textBoxMaHD.Text);
                cmd.Parameters.AddWithValue("@bd", dateTimePickerNgayLap.Value);
                cmd.Parameters.AddWithValue("@kt", dateTimePickerNgayHetHan.Value);
                cmd.Parameters.AddWithValue("@tt",
                    radioButtonConHieuLuc.Checked ? "Còn hiệu lực" : "Hết hạn");
                cmd.Parameters.AddWithValue("@tttt",
                    radioButtonDaPay.Checked ? "Đã thanh toán" : "Chưa thanh toán");

                cmd.ExecuteNonQuery();

                LoadHopDong();
                ClearControls();
                MessageBox.Show("Cập nhật dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                return;
            }
        }

        //nut xóa hợp đồng
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxMaHD.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã hợp đồng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (dataGridView1.Rows.Count <= 1 || dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Hiện không có hợp đồng nào!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            TimDLFromDGVHD();
            string check = @"
            SELECT tinh_trang_hieu_luc 
            FROM hop_dong 
            WHERE ma_hop_dong = @ma";

            SqlCommand cmdCheck = new SqlCommand(check, conn);
            cmdCheck.Parameters.AddWithValue("@ma", textBoxMaHD.Text);

            string trangThai = cmdCheck.ExecuteScalar()?.ToString();

            if (trangThai != "Hết hạn")
            {
                MessageBox.Show("Chỉ được xóa hợp đồng đã hết hạn!",
                                "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult result = MessageBox.Show("Xác nhận muốn xóa hợp đồng!", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                string delete = "DELETE FROM hop_dong WHERE ma_hop_dong = @ma";
                SqlCommand cmd = new SqlCommand(delete, conn);
                cmd.Parameters.AddWithValue("@ma", textBoxMaHD.Text);

                cmd.ExecuteNonQuery();
                LoadHopDong();
            }
            else
            {
                return;
            }
        }

        //Chọn dòng trong dataGridViewPhong
        private void dataGridViewPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewPhong.Rows.Count <= 1 || dataGridViewPhong.CurrentRow == null)
            {
                MessageBox.Show("Hiện không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            comboBoxSoPhong.Text = dataGridViewPhong.CurrentRow.Cells["ma_phong"].Value.ToString();
            textBoxSoLuongSV.Text = dataGridViewPhong.CurrentRow.Cells["so_luong_sv"].Value.ToString();
            comboBoxLoaiPhong.Text = dataGridViewPhong.CurrentRow.Cells["loai_phong"].Value.ToString();
        }

        //nút tìm kiếm sinh viên trong thông tin sinh viên
        private void buttonFindSV_Click(object sender, EventArgs e)
        {
            if(textBoxMsv.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã sinh viên trước!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string query = "SELECT * FROM sinh_vien WHERE ma_sinh_vien = @msv";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            da.SelectCommand.Parameters.AddWithValue("@msv", textBoxMsv.Text);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];

                textBoxHoten.Text = row["ten_sinh_vien"].ToString();
                textBoxCCCD.Text = row["cccd"].ToString();
                textBoxSDT.Text = row["so_dien_thoai"].ToString();
                textBoxDiachi.Text = row["dia_chi_thuong_tru"].ToString();

                if (row["gioi_tinh"].ToString() == "Nam")
                {
                    radioButtonNam_QLHD.Checked = true;
                    comboBoxLoaiPhong.Text = "Nam";
                }    
                else
                {
                    radioButtonNu_QLHD.Checked = true;
                    comboBoxLoaiPhong.Text = "Nữ";
                }   
            }
            else
            {
                MessageBox.Show("Không tìm thấy sinh viên!");
            }
        }

        //Stt của dataGridView Hop Dong
        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dataGridView1.Rows[e.RowIndex].Cells["ColumnSTT"].Value = (e.RowIndex + 1).ToString();
        }

        //Cập nhật màu chữ
        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "tinh_trang_hieu_luc")
            {
                if (e.Value != null)
                {
                    string value = e.Value.ToString();

                    if (value == "Còn hiệu lực")
                    {
                        e.CellStyle.ForeColor = Color.Green;
                    }
                    else if (value == "Hết hạn")
                    {
                        e.CellStyle.ForeColor = Color.Red;
                    }
                }
            }

            if (dataGridView1.Columns[e.ColumnIndex].Name == "tinh_trang_thanh_toan")
            {
                if (e.Value != null)
                {
                    string value = e.Value.ToString();

                    if (value == "Đã thanh toán")
                    {
                        e.CellStyle.ForeColor = Color.Green;
                    }
                    else if (value == "Chưa thanh toán")
                    {
                        e.CellStyle.ForeColor = Color.Red;
                    }
                }
            }
        }

        //nút tải lại
        private void buttonReload_Click(object sender, EventArgs e)
        {
            ClearControls();
            CapNhatHopDongHetHan();
            LoadHopDong();
            LoadPhong();
        }

        //khi giá trị của ngay lap thay doi thi ngay het han cung thay doi
        private void dateTimePickerNgayLap_Leave(object sender, EventArgs e)
        {
            dateTimePickerNgayHetHan.Value = dateTimePickerNgayLap.Value.AddMonths(6);
        }

        //chon comboBox so phong
        private void comboBoxSoPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxSoPhong.SelectedValue == null) return;
            if (comboBoxSoPhong.SelectedValue is DataRowView) return;
            if (comboBoxSoPhong.Text == "")
            {
                return;
            }

            int phongID = Convert.ToInt32(comboBoxSoPhong.SelectedValue);
            string sqlFindPhong = "SELECT loai_phong, so_luong_sv FROM phong WHERE id = @id";
            SqlCommand cmdFindPhong = new SqlCommand(sqlFindPhong, conn);
            cmdFindPhong.Parameters.AddWithValue("@id", phongID);
            SqlDataReader reader = cmdFindPhong.ExecuteReader();

            if(reader.Read())
            {
                comboBoxLoaiPhong.Text = reader["loai_phong"].ToString();
                textBoxSoLuongSV.Text = reader["so_luong_sv"].ToString();
            }
            reader.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.CurrentRow;
            layDLFromDTGV(row);
        }
    }   
}
