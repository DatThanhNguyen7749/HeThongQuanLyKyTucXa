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
    public partial class ChangePassword : Form
    {
        public ChangePassword()
        {
            InitializeComponent();
        }

        private void buttonChangePassword_Click(object sender, EventArgs e)
        {
            if(textBoxPassHienTai.Text == "" || textBoxNewPass.Text == "" || textBoxNhapLaiNewPass.Text == "")
            {
                MessageBox.Show("Bạn phải nhập đầy đủ!","Lỗi",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if(textBoxPassHienTai.Text == textBoxNewPass.Text)
            {
                MessageBox.Show("Mật khẩu mới không được trùng với mật khẩu cũ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if(textBoxNewPass.Text != textBoxNhapLaiNewPass.Text)
            {
                MessageBox.Show("Nhập lại mật khẩu mới sai!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Bạn đã đổi mật khẩu thành công!", "Đổi mật khẩu thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void checkBoxHienPass_CheckedChanged(object sender, EventArgs e)
        {
            textBoxPassHienTai.UseSystemPasswordChar = !checkBoxHienPass.Checked;
            textBoxNewPass.UseSystemPasswordChar = !checkBoxHienPass.Checked;
            textBoxNhapLaiNewPass.UseSystemPasswordChar = !checkBoxHienPass.Checked;
        }

        private void textBoxNhapLaiNewPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxNewPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPassHienTai_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
