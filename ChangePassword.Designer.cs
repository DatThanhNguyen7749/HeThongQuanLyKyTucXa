namespace HeThongQuanLyKyTucXa
{
    partial class ChangePassword
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxPassHienTai = new System.Windows.Forms.TextBox();
            this.textBoxNewPass = new System.Windows.Forms.TextBox();
            this.textBoxNhapLaiNewPass = new System.Windows.Forms.TextBox();
            this.buttonChangePassword = new System.Windows.Forms.Button();
            this.checkBoxHienPass = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập mật khẩu hiện tại:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhập mật khẩu mới:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(214, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nhập lại mật khẩu mới:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBoxPassHienTai
            // 
            this.textBoxPassHienTai.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPassHienTai.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassHienTai.Location = new System.Drawing.Point(279, 19);
            this.textBoxPassHienTai.Name = "textBoxPassHienTai";
            this.textBoxPassHienTai.Size = new System.Drawing.Size(299, 34);
            this.textBoxPassHienTai.TabIndex = 3;
            this.textBoxPassHienTai.UseSystemPasswordChar = true;
            this.textBoxPassHienTai.TextChanged += new System.EventHandler(this.textBoxPassHienTai_TextChanged);
            // 
            // textBoxNewPass
            // 
            this.textBoxNewPass.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxNewPass.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNewPass.Location = new System.Drawing.Point(279, 64);
            this.textBoxNewPass.Name = "textBoxNewPass";
            this.textBoxNewPass.Size = new System.Drawing.Size(299, 34);
            this.textBoxNewPass.TabIndex = 4;
            this.textBoxNewPass.UseSystemPasswordChar = true;
            this.textBoxNewPass.TextChanged += new System.EventHandler(this.textBoxNewPass_TextChanged);
            // 
            // textBoxNhapLaiNewPass
            // 
            this.textBoxNhapLaiNewPass.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxNhapLaiNewPass.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNhapLaiNewPass.Location = new System.Drawing.Point(279, 108);
            this.textBoxNhapLaiNewPass.Name = "textBoxNhapLaiNewPass";
            this.textBoxNhapLaiNewPass.Size = new System.Drawing.Size(299, 34);
            this.textBoxNhapLaiNewPass.TabIndex = 5;
            this.textBoxNhapLaiNewPass.UseSystemPasswordChar = true;
            this.textBoxNhapLaiNewPass.TextChanged += new System.EventHandler(this.textBoxNhapLaiNewPass_TextChanged);
            // 
            // buttonChangePassword
            // 
            this.buttonChangePassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonChangePassword.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonChangePassword.Location = new System.Drawing.Point(435, 211);
            this.buttonChangePassword.Name = "buttonChangePassword";
            this.buttonChangePassword.Size = new System.Drawing.Size(143, 51);
            this.buttonChangePassword.TabIndex = 6;
            this.buttonChangePassword.Text = "Đổi mật khẩu";
            this.buttonChangePassword.UseVisualStyleBackColor = true;
            this.buttonChangePassword.Click += new System.EventHandler(this.buttonChangePassword_Click);
            // 
            // checkBoxHienPass
            // 
            this.checkBoxHienPass.AutoSize = true;
            this.checkBoxHienPass.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxHienPass.Location = new System.Drawing.Point(435, 162);
            this.checkBoxHienPass.Name = "checkBoxHienPass";
            this.checkBoxHienPass.Size = new System.Drawing.Size(131, 21);
            this.checkBoxHienPass.TabIndex = 7;
            this.checkBoxHienPass.Text = "Hiển thị mật khẩu";
            this.checkBoxHienPass.UseVisualStyleBackColor = true;
            this.checkBoxHienPass.CheckedChanged += new System.EventHandler(this.checkBoxHienPass_CheckedChanged);
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 303);
            this.Controls.Add(this.checkBoxHienPass);
            this.Controls.Add(this.buttonChangePassword);
            this.Controls.Add(this.textBoxNhapLaiNewPass);
            this.Controls.Add(this.textBoxNewPass);
            this.Controls.Add(this.textBoxPassHienTai);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(667, 350);
            this.Name = "ChangePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đổi Mật Khẩu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxPassHienTai;
        private System.Windows.Forms.TextBox textBoxNewPass;
        private System.Windows.Forms.TextBox textBoxNhapLaiNewPass;
        private System.Windows.Forms.Button buttonChangePassword;
        private System.Windows.Forms.CheckBox checkBoxHienPass;
    }
}