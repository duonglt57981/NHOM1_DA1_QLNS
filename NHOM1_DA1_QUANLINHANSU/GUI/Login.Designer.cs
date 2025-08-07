namespace NHOM1_DA1_QUANLINHANSU.GUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            label1 = new Label();
            btnDangNhap = new Button();
            linkLabel1 = new LinkLabel();
            tbMatKhau = new TextBox();
            tbTaiKhoan = new TextBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            checkBox1 = new CheckBox();
            pictureBox4 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(173, 9);
            label1.Name = "label1";
            label1.Size = new Size(415, 32);
            label1.TabIndex = 40;
            label1.Text = "Chương Trình Quản Lý Nhân Sự";
            label1.Click += label1_Click;
            // 
            // btnDangNhap
            // 
            btnDangNhap.BackColor = SystemColors.Control;
            btnDangNhap.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDangNhap.ForeColor = Color.Red;
            btnDangNhap.Location = new Point(309, 513);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(146, 44);
            btnDangNhap.TabIndex = 39;
            btnDangNhap.Text = "Đăng Nhập";
            btnDangNhap.UseVisualStyleBackColor = false;
            btnDangNhap.Click += btnDangNhap_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = SystemColors.Control;
            linkLabel1.Location = new Point(229, 457);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(119, 25);
            linkLabel1.TabIndex = 38;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Đổi mật khẩu";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // tbMatKhau
            // 
            tbMatKhau.Location = new Point(280, 406);
            tbMatKhau.Name = "tbMatKhau";
            tbMatKhau.Size = new Size(275, 31);
            tbMatKhau.TabIndex = 37;
            tbMatKhau.UseSystemPasswordChar = true;
            // 
            // tbTaiKhoan
            // 
            tbTaiKhoan.Location = new Point(280, 356);
            tbTaiKhoan.Name = "tbTaiKhoan";
            tbTaiKhoan.Size = new Size(275, 31);
            tbTaiKhoan.TabIndex = 36;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = SystemColors.Control;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(229, 393);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(45, 44);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 35;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = SystemColors.Control;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(229, 343);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(45, 44);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 34;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(229, 61);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(326, 263);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 33;
            pictureBox1.TabStop = false;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.BackColor = SystemColors.Control;
            checkBox1.Location = new Point(373, 457);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(182, 29);
            checkBox1.TabIndex = 58;
            checkBox1.Text = "Hiển Thị Mật Khẩu";
            checkBox1.UseVisualStyleBackColor = false;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.pngtree_sky_blue_gradient_background_download_image_210615;
            pictureBox4.Location = new Point(0, 2);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(803, 555);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 59;
            pictureBox4.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.SkyBlue;
            ClientSize = new Size(800, 555);
            Controls.Add(checkBox1);
            Controls.Add(label1);
            Controls.Add(btnDangNhap);
            Controls.Add(linkLabel1);
            Controls.Add(tbMatKhau);
            Controls.Add(tbTaiKhoan);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox4);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Login";
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnDangNhap;
        private LinkLabel linkLabel1;
        private TextBox tbMatKhau;
        private TextBox tbTaiKhoan;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private CheckBox checkBox1;
        private PictureBox pictureBox4;
    }
}