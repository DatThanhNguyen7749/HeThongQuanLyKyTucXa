namespace HeThongQuanLyKyTucXa
{
    partial class SinhVien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SinhVien));
            this.buttonDangKyKTX = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonHD = new System.Windows.Forms.Button();
            this.buttonChangePassword = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonDangKyKTX
            // 
            this.buttonDangKyKTX.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDangKyKTX.Image = ((System.Drawing.Image)(resources.GetObject("buttonDangKyKTX.Image")));
            this.buttonDangKyKTX.Location = new System.Drawing.Point(12, 111);
            this.buttonDangKyKTX.Name = "buttonDangKyKTX";
            this.buttonDangKyKTX.Size = new System.Drawing.Size(179, 89);
            this.buttonDangKyKTX.TabIndex = 0;
            this.buttonDangKyKTX.Text = "Đăng Ký Ở Ký Túc Xá";
            this.buttonDangKyKTX.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonDangKyKTX.UseVisualStyleBackColor = true;
            this.buttonDangKyKTX.Click += new System.EventHandler(this.buttonDangKyKTX_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoEllipsis = true;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(207, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(455, 45);
            this.label2.TabIndex = 9;
            this.label2.Text = "CHƯƠNG TRÌNH KÝ TÚC XÁ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 45);
            this.label1.TabIndex = 8;
            this.label1.Text = "Dashboard";
            // 
            // buttonHD
            // 
            this.buttonHD.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHD.Image = ((System.Drawing.Image)(resources.GetObject("buttonHD.Image")));
            this.buttonHD.Location = new System.Drawing.Point(12, 224);
            this.buttonHD.Name = "buttonHD";
            this.buttonHD.Size = new System.Drawing.Size(179, 89);
            this.buttonHD.TabIndex = 11;
            this.buttonHD.Text = "Hóa Đơn và Thanh Toán";
            this.buttonHD.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonHD.UseVisualStyleBackColor = true;
            this.buttonHD.Click += new System.EventHandler(this.buttonHD_Click);
            // 
            // buttonChangePassword
            // 
            this.buttonChangePassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonChangePassword.BackColor = System.Drawing.SystemColors.Control;
            this.buttonChangePassword.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonChangePassword.Location = new System.Drawing.Point(486, 425);
            this.buttonChangePassword.Name = "buttonChangePassword";
            this.buttonChangePassword.Size = new System.Drawing.Size(171, 73);
            this.buttonChangePassword.TabIndex = 13;
            this.buttonChangePassword.Text = "Đổi mật khẩu";
            this.buttonChangePassword.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonChangePassword.UseVisualStyleBackColor = true;
            this.buttonChangePassword.Click += new System.EventHandler(this.buttonChangePassword_Click);
            // 
            // buttonLogout
            // 
            this.buttonLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLogout.BackColor = System.Drawing.SystemColors.Control;
            this.buttonLogout.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogout.Image = ((System.Drawing.Image)(resources.GetObject("buttonLogout.Image")));
            this.buttonLogout.Location = new System.Drawing.Point(686, 425);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(171, 73);
            this.buttonLogout.TabIndex = 12;
            this.buttonLogout.Text = "Đăng xuất";
            this.buttonLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // SinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 510);
            this.Controls.Add(this.buttonChangePassword);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.buttonHD);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonDangKyKTX);
            this.Name = "SinhVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard Sinh Viên";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SinhVien_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDangKyKTX;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonHD;
        private System.Windows.Forms.Button buttonChangePassword;
        private System.Windows.Forms.Button buttonLogout;
    }
}