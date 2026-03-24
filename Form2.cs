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
    public partial class SinhVien : Form
    {
        Login form1 = new Login();
        public SinhVien()
        {
            InitializeComponent();
        }

        private void buttonChangePassword_Click(object sender, EventArgs e)
        {
            ChangePassword doimk = new ChangePassword();
            doimk.Show();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            form1.Show();
        }

        private void SinhVien_FormClosed(object sender, FormClosedEventArgs e)
        {
            form1.Show();
        }

        private void buttonHD_Click(object sender, EventArgs e)
        {
            FormThanhToan tt = new FormThanhToan();
            tt.Show();
            this.Hide();
        }

        private void buttonDangKyKTX_Click(object sender, EventArgs e)
        {
            FormDangKyOKTX dangKyOKTX = new FormDangKyOKTX();
            dangKyOKTX.Show();
        }
    }
}
