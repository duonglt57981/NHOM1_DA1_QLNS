namespace NHOM1_DA1_QUANLINHANSU.GUI.UC
{
    partial class UC_QLBaoHiem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_QLBaoHiem));
            groupBox1 = new GroupBox();
            pictureBox1 = new PictureBox();
            dataGridView1 = new DataGridView();
            cboLoaiBH = new ComboBox();
            cboTrangThai = new ComboBox();
            dtpNgayCap = new DateTimePicker();
            dtpNgayBatDau = new DateTimePicker();
            dtpNgayHetHan = new DateTimePicker();
            txtNoiDK = new TextBox();
            txtNoiCap = new TextBox();
            txtIDBH = new TextBox();
            txtIDNV = new TextBox();
            txtSoBH = new TextBox();
            label10 = new Label();
            label7 = new Label();
            label8 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label9 = new Label();
            label1 = new Label();
            textBox1 = new TextBox();
            btnLamMoi = new Button();
            button2 = new Button();
            panel1 = new Panel();
            btnXoa = new Button();
            btnSua = new Button();
            button_QLNV_Them = new Button();
            txtTimKiem = new TextBox();
            panel3 = new Panel();
            txtTK = new TextBox();
            btnTimKiem = new Button();
            button_QLNV_TimKiem = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.DeepSkyBlue;
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Controls.Add(cboLoaiBH);
            groupBox1.Controls.Add(cboTrangThai);
            groupBox1.Controls.Add(dtpNgayCap);
            groupBox1.Controls.Add(dtpNgayBatDau);
            groupBox1.Controls.Add(dtpNgayHetHan);
            groupBox1.Controls.Add(txtNoiDK);
            groupBox1.Controls.Add(txtNoiCap);
            groupBox1.Controls.Add(txtIDBH);
            groupBox1.Controls.Add(txtIDNV);
            groupBox1.Controls.Add(txtSoBH);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.FromArgb(255, 128, 0);
            groupBox1.Location = new Point(3, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1506, 634);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin bảo hiểm";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(6, 35);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(427, 265);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.Location = new Point(3, 303);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1500, 328);
            dataGridView1.TabIndex = 10;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // cboLoaiBH
            // 
            cboLoaiBH.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            cboLoaiBH.FormattingEnabled = true;
            cboLoaiBH.Location = new Point(650, 91);
            cboLoaiBH.Name = "cboLoaiBH";
            cboLoaiBH.Size = new Size(262, 33);
            cboLoaiBH.TabIndex = 9;
            // 
            // cboTrangThai
            // 
            cboTrangThai.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            cboTrangThai.FormattingEnabled = true;
            cboTrangThai.Location = new Point(650, 266);
            cboTrangThai.Name = "cboTrangThai";
            cboTrangThai.Size = new Size(262, 33);
            cboTrangThai.TabIndex = 9;
            // 
            // dtpNgayCap
            // 
            dtpNgayCap.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dtpNgayCap.Location = new Point(650, 208);
            dtpNgayCap.Name = "dtpNgayCap";
            dtpNgayCap.Size = new Size(331, 31);
            dtpNgayCap.TabIndex = 8;
            // 
            // dtpNgayBatDau
            // 
            dtpNgayBatDau.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dtpNgayBatDau.Location = new Point(1153, 147);
            dtpNgayBatDau.Name = "dtpNgayBatDau";
            dtpNgayBatDau.Size = new Size(337, 31);
            dtpNgayBatDau.TabIndex = 8;
            // 
            // dtpNgayHetHan
            // 
            dtpNgayHetHan.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dtpNgayHetHan.Location = new Point(1153, 208);
            dtpNgayHetHan.Name = "dtpNgayHetHan";
            dtpNgayHetHan.Size = new Size(337, 31);
            dtpNgayHetHan.TabIndex = 8;
            // 
            // txtNoiDK
            // 
            txtNoiDK.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtNoiDK.Location = new Point(1153, 89);
            txtNoiDK.Name = "txtNoiDK";
            txtNoiDK.Size = new Size(254, 31);
            txtNoiDK.TabIndex = 7;
            // 
            // txtNoiCap
            // 
            txtNoiCap.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtNoiCap.Location = new Point(1153, 35);
            txtNoiCap.Name = "txtNoiCap";
            txtNoiCap.Size = new Size(254, 31);
            txtNoiCap.TabIndex = 7;
            // 
            // txtIDBH
            // 
            txtIDBH.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtIDBH.Location = new Point(650, 38);
            txtIDBH.Name = "txtIDBH";
            txtIDBH.Size = new Size(262, 31);
            txtIDBH.TabIndex = 7;
            // 
            // txtIDNV
            // 
            txtIDNV.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtIDNV.Location = new Point(1153, 264);
            txtIDNV.Name = "txtIDNV";
            txtIDNV.Size = new Size(254, 31);
            txtIDNV.TabIndex = 7;
            // 
            // txtSoBH
            // 
            txtSoBH.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtSoBH.Location = new Point(650, 152);
            txtSoBH.Name = "txtSoBH";
            txtSoBH.Size = new Size(262, 31);
            txtSoBH.TabIndex = 7;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = Color.Teal;
            label10.Location = new Point(995, 263);
            label10.Name = "label10";
            label10.Size = new Size(68, 30);
            label10.TabIndex = 6;
            label10.Text = "IDNV";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.Teal;
            label7.Location = new Point(489, 151);
            label7.Name = "label7";
            label7.Size = new Size(140, 30);
            label7.TabIndex = 6;
            label7.Text = "Số bảo hiểm";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.Teal;
            label8.Location = new Point(995, 152);
            label8.Name = "label8";
            label8.Size = new Size(154, 30);
            label8.TabIndex = 5;
            label8.Text = "Ngày bắt đầu";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.Teal;
            label6.Location = new Point(995, 213);
            label6.Name = "label6";
            label6.Size = new Size(152, 30);
            label6.TabIndex = 5;
            label6.Text = "Ngày hết hạn";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Teal;
            label5.Location = new Point(995, 92);
            label5.Name = "label5";
            label5.Size = new Size(133, 30);
            label5.TabIndex = 4;
            label5.Text = "Nơi đăng kí";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Teal;
            label4.Location = new Point(995, 41);
            label4.Name = "label4";
            label4.Size = new Size(93, 30);
            label4.TabIndex = 3;
            label4.Text = "Nơi cấp";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Teal;
            label3.Location = new Point(489, 208);
            label3.Name = "label3";
            label3.Size = new Size(111, 30);
            label3.TabIndex = 2;
            label3.Text = "Ngày cấp";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Teal;
            label2.Location = new Point(489, 42);
            label2.Name = "label2";
            label2.Size = new Size(138, 30);
            label2.TabIndex = 1;
            label2.Text = "ID Bảo hiểm";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.Teal;
            label9.Location = new Point(489, 95);
            label9.Name = "label9";
            label9.Size = new Size(157, 30);
            label9.TabIndex = 0;
            label9.Text = "Loại bảo hiểm";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Teal;
            label1.Location = new Point(489, 270);
            label1.Name = "label1";
            label1.Size = new Size(118, 30);
            label1.TabIndex = 0;
            label1.Text = "Trạng thái";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.None;
            textBox1.Location = new Point(1690, 31);
            textBox1.Margin = new Padding(4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(289, 31);
            textBox1.TabIndex = 71;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Anchor = AnchorStyles.None;
            btnLamMoi.BackColor = Color.DeepSkyBlue;
            btnLamMoi.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnLamMoi.ForeColor = Color.Red;
            btnLamMoi.Image = (Image)resources.GetObject("btnLamMoi.Image");
            btnLamMoi.Location = new Point(781, 25);
            btnLamMoi.Margin = new Padding(4);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(124, 95);
            btnLamMoi.TabIndex = 67;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.TextAlign = ContentAlignment.MiddleRight;
            btnLamMoi.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLamMoi.UseVisualStyleBackColor = false;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.BackColor = Color.DeepSkyBlue;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(1689, 72);
            button2.Margin = new Padding(4);
            button2.Name = "button2";
            button2.Size = new Size(290, 54);
            button2.TabIndex = 70;
            button2.Text = "Tìm kiếm";
            button2.TextAlign = ContentAlignment.MiddleRight;
            button2.TextImageRelation = TextImageRelation.ImageBeforeText;
            button2.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(groupBox1);
            panel1.Location = new Point(-16, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1595, 634);
            panel1.TabIndex = 8;
            // 
            // btnXoa
            // 
            btnXoa.Anchor = AnchorStyles.None;
            btnXoa.BackColor = Color.DeepSkyBlue;
            btnXoa.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnXoa.ForeColor = Color.Red;
            btnXoa.Image = (Image)resources.GetObject("btnXoa.Image");
            btnXoa.Location = new Point(563, 25);
            btnXoa.Margin = new Padding(4);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(124, 95);
            btnXoa.TabIndex = 67;
            btnXoa.Text = "Xóa";
            btnXoa.TextAlign = ContentAlignment.MiddleRight;
            btnXoa.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Anchor = AnchorStyles.None;
            btnSua.BackColor = Color.DeepSkyBlue;
            btnSua.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSua.ForeColor = Color.Red;
            btnSua.Image = (Image)resources.GetObject("btnSua.Image");
            btnSua.Location = new Point(351, 25);
            btnSua.Margin = new Padding(4);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(119, 95);
            btnSua.TabIndex = 66;
            btnSua.Text = "Sửa";
            btnSua.TextAlign = ContentAlignment.MiddleRight;
            btnSua.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // button_QLNV_Them
            // 
            button_QLNV_Them.Anchor = AnchorStyles.None;
            button_QLNV_Them.BackColor = Color.DeepSkyBlue;
            button_QLNV_Them.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button_QLNV_Them.ForeColor = Color.Red;
            button_QLNV_Them.Image = (Image)resources.GetObject("button_QLNV_Them.Image");
            button_QLNV_Them.Location = new Point(134, 25);
            button_QLNV_Them.Margin = new Padding(4);
            button_QLNV_Them.Name = "button_QLNV_Them";
            button_QLNV_Them.Size = new Size(118, 95);
            button_QLNV_Them.TabIndex = 65;
            button_QLNV_Them.Text = "Thêm";
            button_QLNV_Them.TextAlign = ContentAlignment.MiddleRight;
            button_QLNV_Them.TextImageRelation = TextImageRelation.ImageBeforeText;
            button_QLNV_Them.UseVisualStyleBackColor = false;
            button_QLNV_Them.Click += button_QLBH_Them_Click;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Anchor = AnchorStyles.None;
            txtTimKiem.Location = new Point(2293, 45);
            txtTimKiem.Margin = new Padding(4);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(289, 31);
            txtTimKiem.TabIndex = 69;
            // 
            // panel3
            // 
            panel3.BackColor = Color.SkyBlue;
            panel3.Controls.Add(txtTK);
            panel3.Controls.Add(btnTimKiem);
            panel3.Controls.Add(textBox1);
            panel3.Controls.Add(button2);
            panel3.Controls.Add(txtTimKiem);
            panel3.Controls.Add(button_QLNV_TimKiem);
            panel3.Controls.Add(btnSua);
            panel3.Controls.Add(button_QLNV_Them);
            panel3.Controls.Add(btnXoa);
            panel3.Controls.Add(btnLamMoi);
            panel3.Location = new Point(-10, 634);
            panel3.Name = "panel3";
            panel3.Size = new Size(1503, 142);
            panel3.TabIndex = 9;
            // 
            // txtTK
            // 
            txtTK.Anchor = AnchorStyles.None;
            txtTK.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtTK.ForeColor = Color.Red;
            txtTK.Location = new Point(1057, 25);
            txtTK.Margin = new Padding(4);
            txtTK.Name = "txtTK";
            txtTK.Size = new Size(289, 31);
            txtTK.TabIndex = 73;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Anchor = AnchorStyles.None;
            btnTimKiem.BackColor = Color.DeepSkyBlue;
            btnTimKiem.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnTimKiem.ForeColor = Color.Red;
            btnTimKiem.Image = (Image)resources.GetObject("btnTimKiem.Image");
            btnTimKiem.Location = new Point(1056, 66);
            btnTimKiem.Margin = new Padding(4);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(290, 54);
            btnTimKiem.TabIndex = 72;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.TextAlign = ContentAlignment.MiddleRight;
            btnTimKiem.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnTimKiem.UseVisualStyleBackColor = false;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // button_QLNV_TimKiem
            // 
            button_QLNV_TimKiem.Anchor = AnchorStyles.None;
            button_QLNV_TimKiem.BackColor = Color.DeepSkyBlue;
            button_QLNV_TimKiem.Image = (Image)resources.GetObject("button_QLNV_TimKiem.Image");
            button_QLNV_TimKiem.Location = new Point(2292, 86);
            button_QLNV_TimKiem.Margin = new Padding(4);
            button_QLNV_TimKiem.Name = "button_QLNV_TimKiem";
            button_QLNV_TimKiem.Size = new Size(290, 54);
            button_QLNV_TimKiem.TabIndex = 68;
            button_QLNV_TimKiem.Text = "Tìm kiếm";
            button_QLNV_TimKiem.TextAlign = ContentAlignment.MiddleRight;
            button_QLNV_TimKiem.TextImageRelation = TextImageRelation.ImageBeforeText;
            button_QLNV_TimKiem.UseVisualStyleBackColor = false;
            // 
            // UC_QLBaoHiem
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(panel3);
            Name = "UC_QLBaoHiem";
            Size = new Size(1493, 776);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private PictureBox pictureBox1;
        private DataGridView dataGridView1;
        private ComboBox cboLoaiBH;
        private ComboBox cboTrangThai;
        private DateTimePicker dtpNgayCap;
        private DateTimePicker dtpNgayBatDau;
        private DateTimePicker dtpNgayHetHan;
        private TextBox txtNoiDK;
        private TextBox txtNoiCap;
        private TextBox txtIDBH;
        private TextBox txtIDNV;
        private TextBox txtSoBH;
        private Label label10;
        private Label label7;
        private Label label8;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label9;
        private Label label1;
        private TextBox textBox1;
        private Button btnLamMoi;
        private Button button2;
        private Panel panel1;
        private Button btnXoa;
        private Button btnSua;
        private Button button_QLNV_Them;
        private TextBox txtTimKiem;
        private Panel panel3;
        private TextBox txtTK;
        private Button btnTimKiem;
        private Button button_QLNV_TimKiem;
    }
}
