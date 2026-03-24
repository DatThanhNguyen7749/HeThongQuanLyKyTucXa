using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp3
{
    public partial class frmCapNhatDichVu : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = "Data Source=LAPTOP-SK2PBLD2;Initial Catalog=KTX_22;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        void loaddata()
        {
            command = connection.CreateCommand();
            command.CommandText = " select * from dich_vu ";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgvDichVu.DataSource = table;


        }
        public frmCapNhatDichVu()
        {
            InitializeComponent();
        }

        private void frmCapNhatDichVu_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loaddata();
        }

        private void dgvDichVu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dgvDichVu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // 1. Kiểm tra xem người dùng có nhấn vào dòng dữ liệu không (tránh nhấn vào tiêu đề cột)
            if (e.RowIndex >= 0)
            {
                // 2. Lấy ra dòng hiện tại đang được nhấn
                DataGridViewRow row = dgvDichVu.Rows[e.RowIndex];

                // 3. Đổ dữ liệu từ các cột (Cells) vào các TextBox tương ứng
                // Lưu ý: Tên trong ngoặc ["..."] phải khớp chính xác với tên cột trong SQL hoặc tên cột của DGV
                txtMaDV.Text = row.Cells["ma_dich_vu"].Value.ToString();
                txtTenDV.Text = row.Cells["ten_dich_vu"].Value.ToString();
                txtDonGia.Text = row.Cells["don_gia"].Value.ToString();
                txtDonViTinh.Text = row.Cells["don_vi_tinh"].Value.ToString();

                // 4. (Tùy chọn) Khóa ô Mã dịch vụ vì mã thường không nên cho sửa thủ công
                txtMaDV.ReadOnly = true;
            }
        }

        private void txtTenDV_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDonGia_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMaDV_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDonViTinh_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            double giaMoi;
            if (string.IsNullOrWhiteSpace(txtDonGia.Text) || !double.TryParse(txtDonGia.Text, out giaMoi))
            {
                MessageBox.Show("Dữ liệu không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDonGia.Focus(); // Đưa con trỏ về ô giá để nhập lại
                return;
            }
            // 1. Khởi tạo command từ connection hiện tại
            command = connection.CreateCommand();

            // 2. Viết câu lệnh SQL dùng tham số @ cực kỳ gọn gàng
            command.CommandText = "UPDATE dich_vu SET ten_dich_vu=@ten, don_gia=@gia, don_vi_tinh=@dvt WHERE ma_dich_vu=@ma";

            // 3. Gán giá trị từ TextBox vào các tham số @ tương ứng
            // Lưu ý: @ma dùng để tìm đúng dòng cần sửa trong WHERE
            command.Parameters.AddWithValue("@ma", txtMaDV.Text);
            command.Parameters.AddWithValue("@ten", txtTenDV.Text);
            command.Parameters.AddWithValue("@gia", giaMoi);
            command.Parameters.AddWithValue("@dvt", txtDonViTinh.Text);

            // 4. Thực thi và làm mới dữ liệu
            command.ExecuteNonQuery();
            loaddata();
            MessageBox.Show("Cập nhật dịch vụ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
