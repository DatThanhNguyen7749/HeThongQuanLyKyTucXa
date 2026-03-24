using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeThongQuanLyKyTucXa
{
    public partial class ThongTinTK : Form
    {
        Form formTruoc;
        string username;
        string connStr = @"Data Source=DELL\SQLEXPRESS;Initial Catalog=QuanLyKTX;Integrated Security=True";
        SqlConnection conn = null;
        public ThongTinTK(Form formBefore, string userNameDB)
        {
            InitializeComponent();
            formTruoc = formBefore;
            username = userNameDB;
        }

        private void buttonDoiMK_Click(object sender, EventArgs e)
        {
            ChangePassword changePassword   = new ChangePassword();
            changePassword.Show();
        }

        private void ThongTinTK_FormClosed(object sender, FormClosedEventArgs e)
        {
            formTruoc.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void ThongTinTK_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(connStr);
            conn.Open();
            string gioitinh;

            string query = "SELECT * FROM tai_khoan WHERE ten_dang_nhap = @user";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@user", username);

            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                textBoxHoTen.Text = reader["ho_ten"].ToString();
                textBoxSDT.Text = reader["so_dien_thoai"].ToString();
                textBoxDiaChi.Text = reader["dia_chi"].ToString();
                textBoxUsername.Text = reader["ten_dang_nhap"].ToString();
                textBoxEmail.Text = reader["email"].ToString();
                if (reader["role_id"].ToString() == "1")
                {
                    textBoxRole.Text = "Admin";
                }
                else
                {
                    textBoxRole.Text = "Nhân Viên";
                }

                gioitinh = reader["gioi_tinh"].ToString();
                if(gioitinh == "Nam")
                {
                    radioButtonNam.Checked = true;
                }
                else if(gioitinh == "Nữ")
                {
                    radioButtonNu.Checked = true;
                }

                if (reader["ngay_sinh"] != DBNull.Value)
                    dateTimePickerBirthday.Value = Convert.ToDateTime(reader["ngay_sinh"]);
            }

            reader.Close();
        }

        private void buttonChangePassword_Click(object sender, EventArgs e)
        {
            if (textBoxPassHienTai.Text == "" || textBoxNewPass.Text == "" || textBoxNhapLaiNewPass.Text == "")
            {
                MessageBox.Show("Bạn phải nhập đầy đủ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (textBoxPassHienTai.Text == textBoxNewPass.Text)
            {
                MessageBox.Show("Mật khẩu mới không được trùng với mật khẩu cũ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (textBoxNewPass.Text != textBoxNhapLaiNewPass.Text)
            {
                MessageBox.Show("Nhập lại mật khẩu mới sai!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string query = "SELECT mat_khau FROM tai_khoan WHERE ten_dang_nhap = '" + username + "'";
            SqlCommand cmd = new SqlCommand(query, conn);

            string dbPass = cmd.ExecuteScalar().ToString();

            if (dbPass != textBoxPassHienTai.Text)
            {
                MessageBox.Show("Sai mật khẩu hiện tại!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                DialogResult result = MessageBox.Show("Xác nhận đổi mật khẩu!", "Confirm", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if(result == DialogResult.Yes)
                {
                    string sqlDoiMK = "UPDATE tai_khoan SET mat_khau = '" + textBoxNewPass.Text + "' WHERE ten_dang_nhap = '" + username + "'";
                    SqlCommand sqlCommand = new SqlCommand(sqlDoiMK, conn);
                    sqlCommand.ExecuteNonQuery();
                    textBoxPassHienTai.Clear();
                    textBoxNewPass.Clear();
                    textBoxNhapLaiNewPass.Clear();
                    MessageBox.Show("Bạn đã đổi mật khẩu thành công!", "Đổi mật khẩu thành công",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void checkBoxHienPass_CheckedChanged(object sender, EventArgs e)
        {
            textBoxPassHienTai.UseSystemPasswordChar = !checkBoxHienPass.Checked;
            textBoxNewPass.UseSystemPasswordChar = !checkBoxHienPass.Checked;
            textBoxNhapLaiNewPass.UseSystemPasswordChar = !checkBoxHienPass.Checked;
        }
    }
}
