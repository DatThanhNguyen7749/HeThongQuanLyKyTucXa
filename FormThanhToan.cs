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
    public partial class FormThanhToan : Form
    {
        public FormThanhToan()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(comboBoxPhuongThuc.Text == "Thanh toán trực tuyến")
            {
                ThanhToanTrucTuyen thanhToanTrucTuyen = new ThanhToanTrucTuyen();
                thanhToanTrucTuyen.Show();
            }
            else if(comboBoxPhuongThuc.Text == "Thanh toán tiền mặt")
            {
                MessageBox.Show("Bạn vui lòng đến văn phòng để đóng tiền!","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void FormThanhToan_FormClosed(object sender, FormClosedEventArgs e)
        {
            SinhVien form2 = new SinhVien();
            form2.Show();
        }
    }
}
