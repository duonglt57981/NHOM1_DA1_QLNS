namespace NHOM1_DA1_QUANLINHANSU.GUI
{
    partial class TrangChu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrangChu));
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            button_DangXuat = new Button();
            button_QLTaiKhoan = new Button();
            button_QLKT_KL = new Button();
            button_QLBaoHiem = new Button();
            button_QLChamCong = new Button();
            button_QLHopDong = new Button();
            button_QLNhanVien = new Button();
            panel_TrangChu = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(287, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(999, 40);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(382, 9);
            label1.Name = "label1";
            label1.Size = new Size(245, 23);
            label1.TabIndex = 0;
            label1.Text = "Hệ Thống Quản Lí Nhân Sự";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel2.BackColor = Color.SteelBlue;
            panel2.Controls.Add(button_DangXuat);
            panel2.Controls.Add(button_QLTaiKhoan);
            panel2.Controls.Add(button_QLKT_KL);
            panel2.Controls.Add(button_QLBaoHiem);
            panel2.Controls.Add(button_QLChamCong);
            panel2.Controls.Add(button_QLHopDong);
            panel2.Controls.Add(button_QLNhanVien);
            panel2.Location = new Point(1, 42);
            panel2.Name = "panel2";
            panel2.Size = new Size(287, 577);
            panel2.TabIndex = 1;
            // 
            // button_DangXuat
            // 
            button_DangXuat.BackColor = Color.DeepSkyBlue;
            button_DangXuat.FlatAppearance.BorderColor = Color.White;
            button_DangXuat.FlatAppearance.BorderSize = 2;
            button_DangXuat.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 128, 255);
            button_DangXuat.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 192, 255);
            button_DangXuat.FlatStyle = FlatStyle.Flat;
            button_DangXuat.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            button_DangXuat.Image = (Image)resources.GetObject("button_DangXuat.Image");
            button_DangXuat.Location = new Point(11, 478);
            button_DangXuat.Name = "button_DangXuat";
            button_DangXuat.Size = new Size(265, 60);
            button_DangXuat.TabIndex = 8;
            button_DangXuat.Text = "ĐĂNG XUẤT";
            button_DangXuat.TextAlign = ContentAlignment.MiddleRight;
            button_DangXuat.TextImageRelation = TextImageRelation.ImageBeforeText;
            button_DangXuat.UseVisualStyleBackColor = false;
            button_DangXuat.Click += button_DangXuat_Click;
            // 
            // button_QLTaiKhoan
            // 
            button_QLTaiKhoan.BackColor = Color.DeepSkyBlue;
            button_QLTaiKhoan.FlatAppearance.BorderColor = Color.White;
            button_QLTaiKhoan.FlatAppearance.BorderSize = 2;
            button_QLTaiKhoan.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 128, 255);
            button_QLTaiKhoan.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 192, 255);
            button_QLTaiKhoan.FlatStyle = FlatStyle.Flat;
            button_QLTaiKhoan.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            button_QLTaiKhoan.Image = (Image)resources.GetObject("button_QLTaiKhoan.Image");
            button_QLTaiKhoan.Location = new Point(11, 397);
            button_QLTaiKhoan.Name = "button_QLTaiKhoan";
            button_QLTaiKhoan.Size = new Size(265, 60);
            button_QLTaiKhoan.TabIndex = 7;
            button_QLTaiKhoan.Text = "QUẢN LÍ TÀI KHOẢN";
            button_QLTaiKhoan.TextAlign = ContentAlignment.MiddleRight;
            button_QLTaiKhoan.TextImageRelation = TextImageRelation.ImageBeforeText;
            button_QLTaiKhoan.UseVisualStyleBackColor = false;
            button_QLTaiKhoan.Click += button_QLTaiKhoan_Click;
            // 
            // button_QLKT_KL
            // 
            button_QLKT_KL.BackColor = Color.DeepSkyBlue;
            button_QLKT_KL.FlatAppearance.BorderColor = Color.White;
            button_QLKT_KL.FlatAppearance.BorderSize = 2;
            button_QLKT_KL.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 128, 255);
            button_QLKT_KL.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 192, 255);
            button_QLKT_KL.FlatStyle = FlatStyle.Flat;
            button_QLKT_KL.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            button_QLKT_KL.Image = (Image)resources.GetObject("button_QLKT_KL.Image");
            button_QLKT_KL.Location = new Point(11, 320);
            button_QLKT_KL.Name = "button_QLKT_KL";
            button_QLKT_KL.Size = new Size(265, 60);
            button_QLKT_KL.TabIndex = 6;
            button_QLKT_KL.Text = "KHEN THƯỞNG_KỈ LUẬT";
            button_QLKT_KL.TextAlign = ContentAlignment.MiddleRight;
            button_QLKT_KL.TextImageRelation = TextImageRelation.ImageBeforeText;
            button_QLKT_KL.UseVisualStyleBackColor = false;
            button_QLKT_KL.Click += button_QLKT_KL_Click;
            // 
            // button_QLBaoHiem
            // 
            button_QLBaoHiem.BackColor = Color.DeepSkyBlue;
            button_QLBaoHiem.FlatAppearance.BorderColor = Color.White;
            button_QLBaoHiem.FlatAppearance.BorderSize = 2;
            button_QLBaoHiem.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 128, 255);
            button_QLBaoHiem.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 192, 255);
            button_QLBaoHiem.FlatStyle = FlatStyle.Flat;
            button_QLBaoHiem.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            button_QLBaoHiem.Image = (Image)resources.GetObject("button_QLBaoHiem.Image");
            button_QLBaoHiem.Location = new Point(11, 244);
            button_QLBaoHiem.Name = "button_QLBaoHiem";
            button_QLBaoHiem.Size = new Size(265, 60);
            button_QLBaoHiem.TabIndex = 5;
            button_QLBaoHiem.Text = "QUẢN LÍ BẢO HIỂM";
            button_QLBaoHiem.TextAlign = ContentAlignment.MiddleRight;
            button_QLBaoHiem.TextImageRelation = TextImageRelation.ImageBeforeText;
            button_QLBaoHiem.UseVisualStyleBackColor = false;
            button_QLBaoHiem.Click += button_QLBaoHiem_Click;
            // 
            // button_QLChamCong
            // 
            button_QLChamCong.BackColor = Color.DeepSkyBlue;
            button_QLChamCong.FlatAppearance.BorderColor = Color.White;
            button_QLChamCong.FlatAppearance.BorderSize = 2;
            button_QLChamCong.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 128, 255);
            button_QLChamCong.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 192, 255);
            button_QLChamCong.FlatStyle = FlatStyle.Flat;
            button_QLChamCong.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            button_QLChamCong.Image = (Image)resources.GetObject("button_QLChamCong.Image");
            button_QLChamCong.Location = new Point(11, 169);
            button_QLChamCong.Name = "button_QLChamCong";
            button_QLChamCong.Size = new Size(265, 60);
            button_QLChamCong.TabIndex = 4;
            button_QLChamCong.Text = "QUẢN LÍ CHẤM CÔNG";
            button_QLChamCong.TextAlign = ContentAlignment.MiddleRight;
            button_QLChamCong.TextImageRelation = TextImageRelation.ImageBeforeText;
            button_QLChamCong.UseVisualStyleBackColor = false;
            button_QLChamCong.Click += button_QLChamCong_Click;
            // 
            // button_QLHopDong
            // 
            button_QLHopDong.BackColor = Color.DeepSkyBlue;
            button_QLHopDong.FlatAppearance.BorderColor = Color.White;
            button_QLHopDong.FlatAppearance.BorderSize = 2;
            button_QLHopDong.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 128, 255);
            button_QLHopDong.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 192, 255);
            button_QLHopDong.FlatStyle = FlatStyle.Flat;
            button_QLHopDong.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            button_QLHopDong.Image = (Image)resources.GetObject("button_QLHopDong.Image");
            button_QLHopDong.Location = new Point(11, 95);
            button_QLHopDong.Name = "button_QLHopDong";
            button_QLHopDong.Size = new Size(265, 60);
            button_QLHopDong.TabIndex = 3;
            button_QLHopDong.Text = "QUẢN LÍ HỢP ĐỒNG";
            button_QLHopDong.TextAlign = ContentAlignment.MiddleRight;
            button_QLHopDong.TextImageRelation = TextImageRelation.ImageBeforeText;
            button_QLHopDong.UseVisualStyleBackColor = false;
            button_QLHopDong.Click += button_QLHopDong_Click;
            // 
            // button_QLNhanVien
            // 
            button_QLNhanVien.BackColor = Color.DeepSkyBlue;
            button_QLNhanVien.FlatAppearance.BorderColor = Color.White;
            button_QLNhanVien.FlatAppearance.BorderSize = 2;
            button_QLNhanVien.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 128, 255);
            button_QLNhanVien.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 192, 255);
            button_QLNhanVien.FlatStyle = FlatStyle.Flat;
            button_QLNhanVien.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            button_QLNhanVien.Image = (Image)resources.GetObject("button_QLNhanVien.Image");
            button_QLNhanVien.Location = new Point(11, 23);
            button_QLNhanVien.Name = "button_QLNhanVien";
            button_QLNhanVien.Size = new Size(265, 60);
            button_QLNhanVien.TabIndex = 2;
            button_QLNhanVien.Text = "QUẢN LÍ NHÂN SỰ";
            button_QLNhanVien.TextAlign = ContentAlignment.MiddleRight;
            button_QLNhanVien.TextImageRelation = TextImageRelation.ImageBeforeText;
            button_QLNhanVien.UseVisualStyleBackColor = false;
            button_QLNhanVien.Click += button_QLNhanVien_Click;
            // 
            // panel_TrangChu
            // 
            panel_TrangChu.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel_TrangChu.Location = new Point(292, 42);
            panel_TrangChu.Name = "panel_TrangChu";
            panel_TrangChu.Size = new Size(992, 587);
            panel_TrangChu.TabIndex = 2;
            // 
            // TrangChu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SkyBlue;
            ClientSize = new Size(1283, 628);
            Controls.Add(panel_TrangChu);
            Controls.Add(panel2);
            Controls.Add(panel1);
            ForeColor = Color.Black;
            Name = "TrangChu";
            Text = "TrangChu";
            WindowState = FormWindowState.Maximized;
            Load += TrangChu_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Button button_QLNhanVien;
        private Button button_DangXuat;
        private Button button_QLTaiKhoan;
        private Button button_QLKT_KL;
        private Button button_QLBaoHiem;
        private Button button_QLChamCong;
        private Button button_QLHopDong;
        private Panel panel_TrangChu;
    }
}