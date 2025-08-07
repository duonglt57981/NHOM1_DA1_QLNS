namespace NHOM1_DA1_QUANLINHANSU.GUI.UC
{
    partial class UC_QLKhenThuong_KiLuat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_QLKhenThuong_KiLuat));
            txtTK = new TextBox();
            btnTimKiem = new Button();
            dtpNgayRa = new DateTimePicker();
            txtTimKiem = new TextBox();
            btnTK = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnThem = new Button();
            btnLM = new Button();
            cboLoai = new ComboBox();
            label5 = new Label();
            dataGridView1 = new DataGridView();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            txtNoiDung = new TextBox();
            label3 = new Label();
            label2 = new Label();
            txtSoKTKL = new TextBox();
            label1 = new Label();
            txtIDKTKL = new TextBox();
            groupBox1 = new GroupBox();
            txtIDNV = new TextBox();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // txtTK
            // 
            txtTK.Anchor = AnchorStyles.None;
            txtTK.Location = new Point(598, 244);
            txtTK.Margin = new Padding(4);
            txtTK.Name = "txtTK";
            txtTK.Size = new Size(289, 37);
            txtTK.TabIndex = 72;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Anchor = AnchorStyles.None;
            btnTimKiem.BackColor = Color.DeepSkyBlue;
            btnTimKiem.Image = (Image)resources.GetObject("btnTimKiem.Image");
            btnTimKiem.Location = new Point(598, 285);
            btnTimKiem.Margin = new Padding(4);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(290, 54);
            btnTimKiem.TabIndex = 71;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.TextAlign = ContentAlignment.MiddleRight;
            btnTimKiem.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnTimKiem.UseVisualStyleBackColor = false;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // dtpNgayRa
            // 
            dtpNgayRa.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpNgayRa.Location = new Point(235, 251);
            dtpNgayRa.Name = "dtpNgayRa";
            dtpNgayRa.Size = new Size(319, 31);
            dtpNgayRa.TabIndex = 70;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Anchor = AnchorStyles.None;
            txtTimKiem.Location = new Point(1244, 538);
            txtTimKiem.Margin = new Padding(4);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(289, 37);
            txtTimKiem.TabIndex = 69;
            // 
            // btnTK
            // 
            btnTK.Anchor = AnchorStyles.None;
            btnTK.BackColor = Color.DeepSkyBlue;
            btnTK.Image = (Image)resources.GetObject("btnTK.Image");
            btnTK.Location = new Point(1244, 579);
            btnTK.Margin = new Padding(4);
            btnTK.Name = "btnTK";
            btnTK.Size = new Size(290, 54);
            btnTK.TabIndex = 68;
            btnTK.Text = "Tìm kiếm";
            btnTK.TextAlign = ContentAlignment.MiddleRight;
            btnTK.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnTK.UseVisualStyleBackColor = false;
            // 
            // btnSua
            // 
            btnSua.Anchor = AnchorStyles.None;
            btnSua.BackColor = Color.DeepSkyBlue;
            btnSua.Image = (Image)resources.GetObject("btnSua.Image");
            btnSua.Location = new Point(556, 141);
            btnSua.Margin = new Padding(4);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(149, 95);
            btnSua.TabIndex = 66;
            btnSua.Text = "Sửa";
            btnSua.TextAlign = ContentAlignment.MiddleRight;
            btnSua.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Anchor = AnchorStyles.None;
            btnXoa.BackColor = Color.DeepSkyBlue;
            btnXoa.Image = (Image)resources.GetObject("btnXoa.Image");
            btnXoa.Location = new Point(740, 21);
            btnXoa.Margin = new Padding(4);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(147, 95);
            btnXoa.TabIndex = 65;
            btnXoa.Text = "Xóa";
            btnXoa.TextAlign = ContentAlignment.MiddleRight;
            btnXoa.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThem
            // 
            btnThem.Anchor = AnchorStyles.None;
            btnThem.BackColor = Color.DeepSkyBlue;
            btnThem.Image = (Image)resources.GetObject("btnThem.Image");
            btnThem.Location = new Point(556, 21);
            btnThem.Margin = new Padding(4);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(149, 95);
            btnThem.TabIndex = 65;
            btnThem.Text = "Thêm";
            btnThem.TextAlign = ContentAlignment.MiddleRight;
            btnThem.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // btnLM
            // 
            btnLM.Anchor = AnchorStyles.None;
            btnLM.BackColor = Color.DeepSkyBlue;
            btnLM.Image = (Image)resources.GetObject("btnLM.Image");
            btnLM.Location = new Point(740, 145);
            btnLM.Margin = new Padding(4);
            btnLM.Name = "btnLM";
            btnLM.Size = new Size(147, 95);
            btnLM.TabIndex = 67;
            btnLM.Text = "Làm mới";
            btnLM.TextAlign = ContentAlignment.MiddleRight;
            btnLM.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLM.UseVisualStyleBackColor = false;
            btnLM.Click += btnLM_Click;
            // 
            // cboLoai
            // 
            cboLoai.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold);
            cboLoai.FormattingEnabled = true;
            cboLoai.Location = new Point(128, 157);
            cboLoai.Name = "cboLoai";
            cboLoai.Size = new Size(228, 34);
            cboLoai.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(255, 128, 0);
            label5.Location = new Point(8, 255);
            label5.Name = "label5";
            label5.Size = new Size(212, 26);
            label5.TabIndex = 1;
            label5.Text = "Ngày ra quyết định";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 372);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1498, 364);
            dataGridView1.TabIndex = 7;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(586, 372);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(255, 128, 0);
            label4.Location = new Point(8, 210);
            label4.Name = "label4";
            label4.Size = new Size(107, 26);
            label4.TabIndex = 1;
            label4.Text = "Nội dung";
            // 
            // txtNoiDung
            // 
            txtNoiDung.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold);
            txtNoiDung.Location = new Point(128, 210);
            txtNoiDung.Name = "txtNoiDung";
            txtNoiDung.Size = new Size(228, 32);
            txtNoiDung.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(255, 128, 0);
            label3.Location = new Point(8, 157);
            label3.Name = "label3";
            label3.Size = new Size(64, 26);
            label3.TabIndex = 1;
            label3.Text = "Loại ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(255, 128, 0);
            label2.Location = new Point(8, 108);
            label2.Name = "label2";
            label2.Size = new Size(119, 26);
            label2.TabIndex = 1;
            label2.Text = "Số KT_KL";
            // 
            // txtSoKTKL
            // 
            txtSoKTKL.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold);
            txtSoKTKL.Location = new Point(128, 105);
            txtSoKTKL.Name = "txtSoKTKL";
            txtSoKTKL.Size = new Size(228, 32);
            txtSoKTKL.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(255, 128, 0);
            label1.Location = new Point(8, 52);
            label1.Name = "label1";
            label1.Size = new Size(114, 26);
            label1.TabIndex = 1;
            label1.Text = "ID KT_KL";
            // 
            // txtIDKTKL
            // 
            txtIDKTKL.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold);
            txtIDKTKL.Location = new Point(128, 52);
            txtIDKTKL.Name = "txtIDKTKL";
            txtIDKTKL.Size = new Size(228, 32);
            txtIDKTKL.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.SkyBlue;
            groupBox1.Controls.Add(txtIDNV);
            groupBox1.Controls.Add(txtTK);
            groupBox1.Controls.Add(dtpNgayRa);
            groupBox1.Controls.Add(txtTimKiem);
            groupBox1.Controls.Add(btnTimKiem);
            groupBox1.Controls.Add(btnTK);
            groupBox1.Controls.Add(cboLoai);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Controls.Add(btnLM);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(txtNoiDung);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtSoKTKL);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtIDKTKL);
            groupBox1.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.Red;
            groupBox1.Location = new Point(586, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(912, 372);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin khen thưởng & kỉ luật";
            // 
            // txtIDNV
            // 
            txtIDNV.Location = new Point(128, 302);
            txtIDNV.Name = "txtIDNV";
            txtIDNV.Size = new Size(228, 37);
            txtIDNV.TabIndex = 73;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold);
            label6.ForeColor = Color.FromArgb(255, 128, 0);
            label6.Location = new Point(8, 304);
            label6.Name = "label6";
            label6.Size = new Size(69, 26);
            label6.TabIndex = 1;
            label6.Text = "IDNV";
            // 
            // UC_QLKhenThuong_KiLuat
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataGridView1);
            Controls.Add(pictureBox1);
            Controls.Add(groupBox1);
            Name = "UC_QLKhenThuong_KiLuat";
            Size = new Size(1498, 733);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtTK;
        private Button btnTimKiem;
        private DateTimePicker dtpNgayRa;
        private TextBox txtTimKiem;
        private Button btnTK;
        private Button btnSua;
        private Button btnXoa;
        private Button btnThem;
        private Button btnLM;
        private ComboBox cboLoai;
        private Label label5;
        private DataGridView dataGridView1;
        private PictureBox pictureBox1;
        private Label label4;
        private TextBox txtNoiDung;
        private Label label3;
        private Label label2;
        private TextBox txtSoKTKL;
        private Label label1;
        private TextBox txtIDKTKL;
        private GroupBox groupBox1;
        private TextBox txtIDNV;
        private Label label6;
    }
}
