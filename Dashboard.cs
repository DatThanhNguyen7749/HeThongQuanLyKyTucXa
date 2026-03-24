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
    public partial class Dashboard : Form
    {
        Login Login = new Login();
        string role;
        string currentUser;
        public Dashboard(string chucvu, string userNameLogin)
        {
            InitializeComponent();
            role = chucvu;
            currentUser = userNameLogin;
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        { 
            this.Close();
            Login.Show();
        }

        private void Dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void buttonQLSV_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ThongTinTK thongTinTK = new ThongTinTK(this, currentUser);
            thongTinTK.Show();
        }

        //private void buttonTTPhongVaSV_Click(object sender, EventArgs e)
        //{
        //    FormTrangThaiPhongVaSV formTrangThaiPhongVaSV = new FormTrangThaiPhongVaSV();
        //    formTrangThaiPhongVaSV.Show();
        //    this.Hide();
        //}

        private void buttonPay_Click(object sender, EventArgs e)
        {

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

        //private void button3_Click(object sender, EventArgs e)
        //{
        //    LapHopDong lapHopDong = new LapHopDong(this);
        //    lapHopDong.Show();
        //}

        private void buttonQuanLyPhong_Click(object sender, EventArgs e)
        {
            QuanLyPhong qlp = new QuanLyPhong();
            qlp.Show();
        }


        private void buttonQLTK_Click(object sender, EventArgs e)
        {
            if (role != "Admin")
            {
                MessageBox.Show("Chỉ Admin mới được truy cập chức năng này!", "Cánh báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


        }
    }
}
