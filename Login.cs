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
    public partial class Login : Form
    {
        string connStr = @"Data Source=DESKTOP-3IIN6J5;Initial Catalog=QLKTX;Integrated Security=True";
        SqlConnection conn = null;
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(connStr);
            conn.Open();
        }

        private void buttonDangNhap_Click(object sender, EventArgs e)
        {

            string username = textBoxTenDN.Text.Trim();
            string password = textBoxMatKhau.Text.Trim();

            // kiểm tra rỗng
            if (username == "")
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxTenDN.Focus();
                return;
            }

            if (password == "")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu!");
                textBoxMatKhau.Focus();
                return;
            }

            // Kiểm tra username
            string queryUser = "SELECT mat_khau FROM tai_khoan WHERE ten_dang_nhap = @user COLLATE SQL_Latin1_General_CP1_CS_AS";
            SqlCommand cmdUser = new SqlCommand(queryUser, conn);
            cmdUser.Parameters.AddWithValue("@user", username);

            object result = cmdUser.ExecuteScalar();

            if (result == null)
            {
                MessageBox.Show("Sai tên đăng nhập!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string dbPassword = result.ToString();

            // kiểm tra password
            if (dbPassword != password)
            {
                MessageBox.Show("Sai mật khẩu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Lấy role
            string queryRole = @"
                        SELECT r.name 
                        FROM tai_khoan tk
                        JOIN role r ON tk.role_id = r.id
                        WHERE tk.ten_dang_nhap = @user";

            SqlCommand cmdRole = new SqlCommand(queryRole, conn);
            cmdRole.Parameters.AddWithValue("@user", username);

            string role = cmdRole.ExecuteScalar()?.ToString();

            //hiện form dashboard
            Dashboard db = new Dashboard(this, role,username);
            db.Show();
            this.Hide();
            //Hiện thông báo đăng nhập thành công
            MessageBox.Show("Đăng nhập thành công!\nQuyền: " + role,
                            "Thông báo",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void checkBoxHienPass_CheckedChanged(object sender, EventArgs e)
        {
            textBoxMatKhau.UseSystemPasswordChar = !checkBoxHienPass.Checked;
        }
    }
}
