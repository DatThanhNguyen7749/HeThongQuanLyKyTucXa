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
    public partial class QuanLyHopDong : Form
    {
        Form formTruoc;
        public QuanLyHopDong(Form formBefore)
        {
            InitializeComponent();
            formTruoc = formBefore;
        }

        private bool checkNgayHetHan()
        {
            DateTime ngayLap = dateTimePickerNgayLap_LHD.Value;
            DateTime ngayHet = dateTimePickerNgayHetHan_LHD.Value;

            DateTime minNgayHetHan = ngayLap.AddMonths(6);

            if (ngayHet < minNgayHetHan)
            {
                
                return false;
            }

            return true;
        }

        private void QuanLyHopDong_Load(object sender, EventArgs e)
        {
            dateTimePickerNgayHetHan_LHD.Value = dateTimePickerNgayLap_LHD.Value.AddMonths(6);
        }

        private void QuanLyHopDong_FormClosed(object sender, FormClosedEventArgs e)
        {
            formTruoc.Show();
        }

        private void buttonTimKiem_Click(object sender, EventArgs e)
        {
            bool timThay = false;
            string tim = textBoxTim.Text;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["MaHopDong"].Value != null && row.Cells["MaHopDong"].Value.ToString() == tim)
                {
                    timThay = true;
                    row.Selected = true;
                    dataGridView1.CurrentCell = row.Cells[0];
                    dataGridView1.FirstDisplayedScrollingRowIndex = row.Index;
                    return;
                }
            }
            if (!timThay)
            {
                MessageBox.Show("Không tìm thấy!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void buttonLap_Click(object sender, EventArgs e)
        {

            if (textBoxMsv_LHD.Text == "" || textBoxHoten_LHD.Text == "" || textBoxCCCD_LHD.Text == ""
                || textBoxDiaChi_LHD.Text == "" || textBoxEmail_LHD.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin cần thiết!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (checkNgayHetHan() != true)
            {
                MessageBox.Show("Ngày hết hạn phải ít nhất sau ngày lập 1 năm!",
                                "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonHuy_Click(object sender, EventArgs e)
        {
            this.Close();
            formTruoc.Show();
        }
    }
}
