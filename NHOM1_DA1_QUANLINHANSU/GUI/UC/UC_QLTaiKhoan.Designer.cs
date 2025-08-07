using System.ComponentModel;

namespace NHOM1_DA1_QUANLINHANSU.GUI.UC
{
    partial class UC_QLTaiKhoan
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
        private void InitializeComponent()
        {
            ComponentResourceManager resources = new ComponentResourceManager(typeof(UC_QLTaiKhoan));
            groupBox1 = new GroupBox();
            cmbVaiTro = new ComboBox();
            cmbTrangThai = new ComboBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            tbMK = new TextBox();
            tbTenTK = new TextBox();
            label2 = new Label();
            tbTenNV = new TextBox();
            label8 = new Label();
            label1 = new Label();
            tbID = new TextBox();
            dataGridView1 = new DataGridView();
            groupBox2 = new GroupBox();
            textBox_TimKiem = new TextBox();
            button_TimKiem = new Button();
            button_QLNV_Xoa = new Button();
            button_QLNV_Sua = new Button();
            button_QLNV_Them = new Button();
            groupBox1.SuspendLayout();
            ((ISupportInitialize)dataGridView1).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(cmbVaiTro);
            groupBox1.Controls.Add(cmbTrangThai);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(tbMK);
            groupBox1.Controls.Add(tbTenTK);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(tbTenNV);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(tbID);
            groupBox1.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold);
            groupBox1.Location = new Point(12, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1159, 207);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông Tin Tài Khoản";
            // 
            // cmbVaiTro
            // 
            cmbVaiTro.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            cmbVaiTro.FormattingEnabled = true;
            cmbVaiTro.Location = new Point(663, 141);
            cmbVaiTro.Margin = new Padding(4);
            cmbVaiTro.Name = "cmbVaiTro";
            cmbVaiTro.Size = new Size(217, 33);
            cmbVaiTro.TabIndex = 79;
            // 
            // cmbTrangThai
            // 
            cmbTrangThai.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            cmbTrangThai.FormattingEnabled = true;
            cmbTrangThai.Location = new Point(663, 92);
            cmbTrangThai.Margin = new Padding(4);
            cmbTrangThai.Name = "cmbTrangThai";
            cmbTrangThai.Size = new Size(114, 33);
            cmbTrangThai.TabIndex = 78;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold);
            label5.ForeColor = SystemColors.HotTrack;
            label5.Location = new Point(528, 147);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.RightToLeft = RightToLeft.No;
            label5.Size = new Size(81, 24);
            label5.TabIndex = 77;
            label5.Text = "Vai Trò:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold);
            label4.ForeColor = SystemColors.HotTrack;
            label4.Location = new Point(528, 98);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(114, 24);
            label4.TabIndex = 76;
            label4.Text = "Trạng Thái:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold);
            label3.ForeColor = SystemColors.HotTrack;
            label3.Location = new Point(528, 46);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(109, 24);
            label3.TabIndex = 75;
            label3.Text = "Mật Khẩu:";
            // 
            // tbMK
            // 
            tbMK.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            tbMK.Location = new Point(663, 41);
            tbMK.Margin = new Padding(4);
            tbMK.Name = "tbMK";
            tbMK.Size = new Size(306, 32);
            tbMK.TabIndex = 74;
            // 
            // tbTenTK
            // 
            tbTenTK.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            tbTenTK.Location = new Point(166, 142);
            tbTenTK.Margin = new Padding(4);
            tbTenTK.Name = "tbTenTK";
            tbTenTK.Size = new Size(306, 32);
            tbTenTK.TabIndex = 73;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold);
            label2.ForeColor = SystemColors.HotTrack;
            label2.Location = new Point(7, 147);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(151, 24);
            label2.TabIndex = 72;
            label2.Text = "Tên Tài Khoản:";
            // 
            // tbTenNV
            // 
            tbTenNV.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            tbTenNV.Location = new Point(166, 93);
            tbTenNV.Margin = new Padding(4);
            tbTenNV.Name = "tbTenNV";
            tbTenNV.Size = new Size(306, 32);
            tbTenNV.TabIndex = 71;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold);
            label8.ForeColor = SystemColors.HotTrack;
            label8.Location = new Point(7, 98);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(132, 24);
            label8.TabIndex = 70;
            label8.Text = "Tên Hiển Thị:";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(7, 46);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(39, 24);
            label1.TabIndex = 63;
            label1.Text = "ID:";
            // 
            // tbID
            // 
            tbID.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            tbID.Location = new Point(166, 41);
            tbID.Margin = new Padding(4);
            tbID.Name = "tbID";
            tbID.ReadOnly = true;
            tbID.Size = new Size(306, 32);
            tbID.TabIndex = 56;
            tbID.TextChanged += textBox_QLNV_ID_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 216);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1159, 252);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.Controls.Add(textBox_TimKiem);
            groupBox2.Controls.Add(button_TimKiem);
            groupBox2.Controls.Add(button_QLNV_Xoa);
            groupBox2.Controls.Add(button_QLNV_Sua);
            groupBox2.Controls.Add(button_QLNV_Them);
            groupBox2.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold);
            groupBox2.Location = new Point(12, 474);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1159, 140);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chức Năng";
            // 
            // textBox_TimKiem
            // 
            textBox_TimKiem.Anchor = AnchorStyles.None;
            textBox_TimKiem.Location = new Point(757, 38);
            textBox_TimKiem.Margin = new Padding(4);
            textBox_TimKiem.Name = "textBox_TimKiem";
            textBox_TimKiem.Size = new Size(212, 32);
            textBox_TimKiem.TabIndex = 75;
            // 
            // button_TimKiem
            // 
            button_TimKiem.Anchor = AnchorStyles.None;
            button_TimKiem.BackColor = Color.WhiteSmoke;
            button_TimKiem.FlatAppearance.BorderSize = 2;
            button_TimKiem.FlatAppearance.CheckedBackColor = Color.Transparent;
            button_TimKiem.FlatAppearance.MouseDownBackColor = Color.PaleTurquoise;
            button_TimKiem.FlatAppearance.MouseOverBackColor = Color.PaleTurquoise;
            button_TimKiem.FlatStyle = FlatStyle.Flat;
            button_TimKiem.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold);
            button_TimKiem.ForeColor = Color.SteelBlue;
            button_TimKiem.Image = (Image)resources.GetObject("button_TimKiem.Image");
            button_TimKiem.Location = new Point(757, 81);
            button_TimKiem.Margin = new Padding(4);
            button_TimKiem.Name = "button_TimKiem";
            button_TimKiem.Size = new Size(212, 52);
            button_TimKiem.TabIndex = 74;
            button_TimKiem.Text = "Tìm kiếm";
            button_TimKiem.TextAlign = ContentAlignment.MiddleRight;
            button_TimKiem.TextImageRelation = TextImageRelation.ImageBeforeText;
            button_TimKiem.UseVisualStyleBackColor = false;
            button_TimKiem.Click += button_TimKiem_Click;
            // 
            // button_QLNV_Xoa
            // 
            button_QLNV_Xoa.Anchor = AnchorStyles.None;
            button_QLNV_Xoa.BackColor = Color.WhiteSmoke;
            button_QLNV_Xoa.FlatAppearance.BorderSize = 2;
            button_QLNV_Xoa.FlatAppearance.CheckedBackColor = Color.Transparent;
            button_QLNV_Xoa.FlatAppearance.MouseDownBackColor = Color.PaleTurquoise;
            button_QLNV_Xoa.FlatAppearance.MouseOverBackColor = Color.PaleTurquoise;
            button_QLNV_Xoa.FlatStyle = FlatStyle.Flat;
            button_QLNV_Xoa.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold);
            button_QLNV_Xoa.ForeColor = Color.SteelBlue;
            button_QLNV_Xoa.Image = (Image)resources.GetObject("button_QLNV_Xoa.Image");
            button_QLNV_Xoa.Location = new Point(560, 38);
            button_QLNV_Xoa.Margin = new Padding(4);
            button_QLNV_Xoa.Name = "button_QLNV_Xoa";
            button_QLNV_Xoa.Size = new Size(120, 95);
            button_QLNV_Xoa.TabIndex = 69;
            button_QLNV_Xoa.Text = "Xóa";
            button_QLNV_Xoa.TextAlign = ContentAlignment.MiddleRight;
            button_QLNV_Xoa.TextImageRelation = TextImageRelation.ImageBeforeText;
            button_QLNV_Xoa.UseVisualStyleBackColor = false;
            button_QLNV_Xoa.Click += button_QLNV_Xoa_Click;
            // 
            // button_QLNV_Sua
            // 
            button_QLNV_Sua.Anchor = AnchorStyles.None;
            button_QLNV_Sua.BackColor = Color.WhiteSmoke;
            button_QLNV_Sua.FlatAppearance.BorderSize = 2;
            button_QLNV_Sua.FlatAppearance.CheckedBackColor = Color.Transparent;
            button_QLNV_Sua.FlatAppearance.MouseDownBackColor = Color.PaleTurquoise;
            button_QLNV_Sua.FlatAppearance.MouseOverBackColor = Color.PaleTurquoise;
            button_QLNV_Sua.FlatStyle = FlatStyle.Flat;
            button_QLNV_Sua.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold);
            button_QLNV_Sua.ForeColor = Color.SteelBlue;
            button_QLNV_Sua.Image = (Image)resources.GetObject("button_QLNV_Sua.Image");
            button_QLNV_Sua.Location = new Point(367, 38);
            button_QLNV_Sua.Margin = new Padding(4);
            button_QLNV_Sua.Name = "button_QLNV_Sua";
            button_QLNV_Sua.Size = new Size(120, 95);
            button_QLNV_Sua.TabIndex = 69;
            button_QLNV_Sua.Text = "Sửa";
            button_QLNV_Sua.TextAlign = ContentAlignment.MiddleRight;
            button_QLNV_Sua.TextImageRelation = TextImageRelation.ImageBeforeText;
            button_QLNV_Sua.UseVisualStyleBackColor = false;
            button_QLNV_Sua.Click += button_QLNV_Sua_Click;
            // 
            // button_QLNV_Them
            // 
            button_QLNV_Them.Anchor = AnchorStyles.None;
            button_QLNV_Them.BackColor = Color.WhiteSmoke;
            button_QLNV_Them.FlatAppearance.BorderSize = 2;
            button_QLNV_Them.FlatAppearance.CheckedBackColor = Color.Transparent;
            button_QLNV_Them.FlatAppearance.MouseDownBackColor = Color.PaleTurquoise;
            button_QLNV_Them.FlatAppearance.MouseOverBackColor = Color.PaleTurquoise;
            button_QLNV_Them.FlatStyle = FlatStyle.Flat;
            button_QLNV_Them.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold);
            button_QLNV_Them.ForeColor = Color.SteelBlue;
            button_QLNV_Them.Image = (Image)resources.GetObject("button_QLNV_Them.Image");
            button_QLNV_Them.Location = new Point(171, 38);
            button_QLNV_Them.Margin = new Padding(4);
            button_QLNV_Them.Name = "button_QLNV_Them";
            button_QLNV_Them.Size = new Size(124, 95);
            button_QLNV_Them.TabIndex = 68;
            button_QLNV_Them.Text = "Thêm";
            button_QLNV_Them.TextAlign = ContentAlignment.MiddleRight;
            button_QLNV_Them.TextImageRelation = TextImageRelation.ImageBeforeText;
            button_QLNV_Them.UseVisualStyleBackColor = false;
            button_QLNV_Them.Click += button_QLNV_Them_Click;
            // 
            // UC_QLTaiKhoan
            // 
            Controls.Add(groupBox2);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Name = "UC_QLTaiKhoan";
            Size = new Size(1177, 617);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((ISupportInitialize)dataGridView1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);

        }
        private GroupBox groupBox1;
        private TextBox tbID;
        private Label label1;
        private Label label8;
        private TextBox tbTenNV;
        private TextBox tbTenTK;
        private Label label2;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox tbMK;
        private ComboBox cmbVaiTro;
        private ComboBox cmbTrangThai;
        private DataGridView dataGridView1;
        private GroupBox groupBox2;
        private Button button_QLNV_Them;
        private Button button_QLNV_Sua;
        private Button button_QLNV_Xoa;
        private Button button_TimKiem;
        private TextBox textBox_TimKiem;
    }
}
