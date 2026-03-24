using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeThongQuanLyKyTucXa
{
    public partial class QuanLyPhong : Form
    {
        Form formTruoc;
        public QuanLyPhong(Form formBefore)
        {
            InitializeComponent();
            formTruoc = formBefore;
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (dataGridView1.CurrentRow == null || dataGridView1.CurrentRow.IsNewRow)
            {
                MessageBox.Show("Vui lòng chọn dòng cần xóa!");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Bạn có chắc muốn xóa không?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Mã phòng không được để trống!",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                textBox1.Focus();
                return;
            }

            // Kiểm tra Tình trạng
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn tình trạng!",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                comboBox1.Focus();
                return;
            }

            bool tinhTrang = comboBox1.Text == "Kích hoạt";
            dataGridView1.Rows.Add(
            textBox1.Text,
            tinhTrang,1 ,8);
            textBox1.Clear();
            comboBox1.SelectedIndex = -1;
        }

        bool KiemTraMaPhong(string maPhong)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["Column1"].Value != null &&
                    row.Cells["Column1"].Value.ToString() == maPhong)
                {
                    return true;
                }
            }
            return false;
        }

        private void Cell_Click(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

            string maPhong = row.Cells["Column1"].Value?.ToString();

            if (!KiemTraMaPhong(maPhong))
            {
                MessageBox.Show("Mã phòng không tồn tại!",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            if (row.Cells["Column1"].Value != null)
                textBox1.Text = row.Cells["Column1"].Value.ToString();
            else
                textBox1.Clear();

            // Tình trạng
            bool tinhTrang = false;

            if (row.Cells["Column2"].Value != null &&
                row.Cells["Column2"].Value != DBNull.Value)
            {
                bool.TryParse(row.Cells["Column2"].Value.ToString(), out tinhTrang);
            }

            comboBox1.SelectedIndex = tinhTrang ? 0 : 1;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            formTruoc.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string maPhong = textBox1.Text.Trim();
            int trangThaiIndex = comboBox1.SelectedIndex;

            if (string.IsNullOrEmpty(maPhong) && trangThaiIndex == -1)
            {
                MessageBox.Show("Vui lòng nhập Mã phòng hoặc chọn Tình trạng!");
                return;
            }

            bool timThay = false;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.IsNewRow) continue;

                string ma = row.Cells["Column1"].Value?.ToString() ?? "";

                bool tinhTrang = false;
                if (row.Cells["Column2"].Value != null)
                    tinhTrang = Convert.ToBoolean(row.Cells["Column2"].Value);

                bool match = true;

                // kiểm tra mã phòng
                if (!string.IsNullOrEmpty(maPhong))
                    match = match && ma == maPhong;

                // kiểm tra tình trạng
                if (trangThaiIndex != -1)
                {
                    bool trangThaiCanTim = trangThaiIndex == 0; // 0 = kích hoạt, 1 = hủy
                    match = match && tinhTrang == trangThaiCanTim;
                }

                row.Visible = match;

                if (match) timThay = true;
            }

            if (!timThay)
                MessageBox.Show("Không tìm thấy dữ liệu!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn dòng cần sửa!");
                return;
            }

            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Mã phòng không được để trống!");
                textBox1.Focus();
                return;
            }

            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn tình trạng!");
                comboBox1.Focus();
                return;
            }

            DataGridViewRow row = dataGridView1.CurrentRow;

            bool tinhTrang = comboBox1.SelectedIndex == 0;

            row.Cells["Column1"].Value = textBox1.Text;
            row.Cells["Column2"].Value = tinhTrang;

            MessageBox.Show("Cập nhật thành công!");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // Hiện lại tất cả rows
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (!row.IsNewRow)
                    row.Visible = true;
            }

            // Clear ô nhập
            textBox1.Clear();
            comboBox1.SelectedIndex = -1;

            // Bỏ chọn dòng
            dataGridView1.ClearSelection();
        }
    }
    }
