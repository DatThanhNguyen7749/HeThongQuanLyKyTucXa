namespace HeThongQuanLyKyTucXa
{
    partial class Login
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
            System.Windows.Forms.Button buttonDangNhap;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.checkBoxHienPass = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxMatKhau = new System.Windows.Forms.TextBox();
            this.textBoxTenDN = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            buttonDangNhap = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonDangNhap
            // 
            buttonDangNhap.BackColor = System.Drawing.Color.White;
            buttonDangNhap.FlatAppearance.BorderSize = 2;
            buttonDangNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonDangNhap.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            buttonDangNhap.Location = new System.Drawing.Point(154, 260);
            buttonDangNhap.Name = "buttonDangNhap";
            buttonDangNhap.Size = new System.Drawing.Size(148, 56);
            buttonDangNhap.TabIndex = 15;
            buttonDangNhap.Text = "Đăng Nhập";
            buttonDangNhap.UseVisualStyleBackColor = false;
            buttonDangNhap.Click += new System.EventHandler(this.buttonDangNhap_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(263, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(518, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hệ Thống Quản Lý Ký Túc Xá";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Controls.Add(this.checkBoxHienPass);
            this.panel2.Controls.Add(buttonDangNhap);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.textBoxMatKhau);
            this.panel2.Controls.Add(this.textBoxTenDN);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(294, 140);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(456, 321);
            this.panel2.TabIndex = 10;
            // 
            // checkBoxHienPass
            // 
            this.checkBoxHienPass.AutoSize = true;
            this.checkBoxHienPass.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxHienPass.Location = new System.Drawing.Point(304, 141);
            this.checkBoxHienPass.Name = "checkBoxHienPass";
            this.checkBoxHienPass.Size = new System.Drawing.Size(131, 21);
            this.checkBoxHienPass.TabIndex = 16;
            this.checkBoxHienPass.Text = "Hiển thị mật khẩu";
            this.checkBoxHienPass.UseVisualStyleBackColor = true;
            this.checkBoxHienPass.CheckedChanged += new System.EventHandler(this.checkBoxHienPass_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(24, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Nhập mật khẩu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(21, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Nhập tên đăng nhập";
            // 
            // textBoxMatKhau
            // 
            this.textBoxMatKhau.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxMatKhau.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMatKhau.Location = new System.Drawing.Point(21, 168);
            this.textBoxMatKhau.Name = "textBoxMatKhau";
            this.textBoxMatKhau.Size = new System.Drawing.Size(414, 38);
            this.textBoxMatKhau.TabIndex = 12;
            this.textBoxMatKhau.UseSystemPasswordChar = true;
            // 
            // textBoxTenDN
            // 
            this.textBoxTenDN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxTenDN.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTenDN.Location = new System.Drawing.Point(21, 80);
            this.textBoxTenDN.Name = "textBoxTenDN";
            this.textBoxTenDN.Size = new System.Drawing.Size(414, 38);
            this.textBoxTenDN.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(159, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 18);
            this.label3.TabIndex = 10;
            this.label3.Text = "*Vui lòng đăng nhập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(142, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 41);
            this.label2.TabIndex = 9;
            this.label2.Text = "Đăng nhập";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1044, 600);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Login_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox checkBoxHienPass;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxMatKhau;
        private System.Windows.Forms.TextBox textBoxTenDN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}

