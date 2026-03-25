using System;
using System.Windows.Forms;

namespace HeThongQuanLyKyTucXa
{
    public partial class Dashboard : Form
    {
        Login loginForm; 
        string role;
        string currentUser;

        public Dashboard(Login login, string chucvu, string userNameLogin)
        {
            InitializeComponent();
            loginForm = login; 
            role = chucvu;
            currentUser = userNameLogin;
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            foreach (Control c in loginForm.Controls)
            {
                if (c is TextBox txt)
                    txt.Clear();
            }

            loginForm.Show(); 
            this.Close();
        }

        private void Dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Login login = new Login();
            login.Show();
        }

        private void buttonQLSV_Click(object sender, EventArgs e)
        {
            QuanLySinhVien qlsv = new QuanLySinhVien();
            qlsv.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ThongTinTK thongTinTK = new ThongTinTK(this, currentUser);
            thongTinTK.Show();
        }

        private void buttonPay_Click(object sender, EventArgs e)
        {
            QuanLyktx_1 qlhd = new QuanLyktx_1();
            qlhd.Show();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            HopDong quanLyHopDong = new HopDong(this);
            quanLyHopDong.Show();
            this.Hide();
        }

        private void buttonQuanLyPhong_Click(object sender, EventArgs e)
        {
            QuanLyPhong qlp = new QuanLyPhong();
            qlp.Show();
        }

        private void buttonQLTK_Click(object sender, EventArgs e)
        {
            if (role != "Admin")
            {
                MessageBox.Show("Chỉ Admin mới được truy cập chức năng này!", "Cảnh báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            QLTK qltk = new QLTK();
            qltk.Show();
        }
    }
}