namespace HeThongQuanLyKyTucXa
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.button1 = new System.Windows.Forms.Button();
            this.buttonQLTK = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonQuanLyPhong = new System.Windows.Forms.Button();
            this.buttonQLSV = new System.Windows.Forms.Button();
            this.buttonPay = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(11, 596);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(355, 79);
            this.button1.TabIndex = 5;
            this.button1.Text = "Thông tin tài khoản";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonQLTK
            // 
            this.buttonQLTK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonQLTK.BackColor = System.Drawing.SystemColors.Control;
            this.buttonQLTK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonQLTK.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonQLTK.Location = new System.Drawing.Point(11, 485);
            this.buttonQLTK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonQLTK.Name = "buttonQLTK";
            this.buttonQLTK.Size = new System.Drawing.Size(355, 79);
            this.buttonQLTK.TabIndex = 11;
            this.buttonQLTK.Text = "Quản lý tài khoản";
            this.buttonQLTK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonQLTK.UseVisualStyleBackColor = true;
            this.buttonQLTK.Click += new System.EventHandler(this.buttonQLTK_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.buttonQuanLyPhong);
            this.groupBox1.Controls.Add(this.buttonQLSV);
            this.groupBox1.Controls.Add(this.buttonQLTK);
            this.groupBox1.Controls.Add(this.buttonPay);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 74);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(376, 772);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dashboard";
            // 
            // buttonQuanLyPhong
            // 
            this.buttonQuanLyPhong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonQuanLyPhong.BackColor = System.Drawing.SystemColors.Control;
            this.buttonQuanLyPhong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonQuanLyPhong.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonQuanLyPhong.Image = ((System.Drawing.Image)(resources.GetObject("buttonQuanLyPhong.Image")));
            this.buttonQuanLyPhong.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonQuanLyPhong.Location = new System.Drawing.Point(11, 78);
            this.buttonQuanLyPhong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonQuanLyPhong.Name = "buttonQuanLyPhong";
            this.buttonQuanLyPhong.Size = new System.Drawing.Size(355, 79);
            this.buttonQuanLyPhong.TabIndex = 1;
            this.buttonQuanLyPhong.Text = "Quản lý phòng";
            this.buttonQuanLyPhong.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonQuanLyPhong.UseVisualStyleBackColor = true;
            this.buttonQuanLyPhong.Click += new System.EventHandler(this.buttonQuanLyPhong_Click);
            // 
            // buttonQLSV
            // 
            this.buttonQLSV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonQLSV.BackColor = System.Drawing.SystemColors.Control;
            this.buttonQLSV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonQLSV.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonQLSV.Image = ((System.Drawing.Image)(resources.GetObject("buttonQLSV.Image")));
            this.buttonQLSV.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonQLSV.Location = new System.Drawing.Point(11, 172);
            this.buttonQLSV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonQLSV.Name = "buttonQLSV";
            this.buttonQLSV.Size = new System.Drawing.Size(355, 79);
            this.buttonQLSV.TabIndex = 2;
            this.buttonQLSV.Text = "Quản lý sinh viên";
            this.buttonQLSV.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonQLSV.UseVisualStyleBackColor = false;
            this.buttonQLSV.Click += new System.EventHandler(this.buttonQLSV_Click);
            // 
            // buttonPay
            // 
            this.buttonPay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPay.BackColor = System.Drawing.SystemColors.Control;
            this.buttonPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPay.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPay.Image = ((System.Drawing.Image)(resources.GetObject("buttonPay.Image")));
            this.buttonPay.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonPay.Location = new System.Drawing.Point(11, 271);
            this.buttonPay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonPay.Name = "buttonPay";
            this.buttonPay.Size = new System.Drawing.Size(355, 79);
            this.buttonPay.TabIndex = 4;
            this.buttonPay.Text = "Quản lý hóa đơn";
            this.buttonPay.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonPay.UseVisualStyleBackColor = false;
            this.buttonPay.Click += new System.EventHandler(this.buttonPay_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.SystemColors.Control;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.Location = new System.Drawing.Point(11, 374);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(355, 79);
            this.button2.TabIndex = 9;
            this.button2.Text = "Quản lý hợp đồng";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(376, 74);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(765, 772);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // buttonLogout
            // 
            this.buttonLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLogout.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonLogout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonLogout.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogout.Image = ((System.Drawing.Image)(resources.GetObject("buttonLogout.Image")));
            this.buttonLogout.Location = new System.Drawing.Point(956, 2);
            this.buttonLogout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(171, 73);
            this.buttonLogout.TabIndex = 8;
            this.buttonLogout.Text = "Đăng xuất";
            this.buttonLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonLogout.UseVisualStyleBackColor = false;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // label2
            // 
            this.label2.AutoEllipsis = true;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(734, 54);
            this.label2.TabIndex = 7;
            this.label2.Text = "CHƯƠNG TRÌNH QUẢN LÝ KÝ TÚC XÁ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.buttonLogout);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 846);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1141, 76);
            this.panel2.TabIndex = 16;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1141, 74);
            this.panel1.TabIndex = 15;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1141, 922);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(1157, 895);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Dashboard_FormClosed);
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonQuanLyPhong;
        private System.Windows.Forms.Button buttonQLSV;
        private System.Windows.Forms.Button buttonPay;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonQLTK;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
    }
}