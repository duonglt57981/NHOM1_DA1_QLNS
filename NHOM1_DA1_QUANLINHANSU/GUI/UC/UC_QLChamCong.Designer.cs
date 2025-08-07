namespace NHOM1_DA1_QUANLINHANSU.GUI.UC
{
    partial class UC_QLChamCong
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
            cbbLoaiCong = new ComboBox();
            label6 = new Label();
            btnTimKiem = new Button();
            txtTimKiem = new TextBox();
            btnTaiLai = new Button();
            btnHuy = new Button();
            btnLuu = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            label3 = new Label();
            dtpNgayCong = new DateTimePicker();
            label2 = new Label();
            cboMaNV = new ComboBox();
            txtMaCC = new TextBox();
            label1 = new Label();
            dgvChamCong = new DataGridView();
            txtTen = new TextBox();
            label7 = new Label();
            txtGV = new TextBox();
            label4 = new Label();
            txtPV = new TextBox();
            label5 = new Label();
            txtPR = new TextBox();
            label8 = new Label();
            txtGR = new TextBox();
            label9 = new Label();
            label10 = new Label();
            cbbCa = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvChamCong).BeginInit();
            SuspendLayout();
            // 
            // cbbLoaiCong
            // 
            cbbLoaiCong.FormattingEnabled = true;
            cbbLoaiCong.Location = new Point(639, 17);
            cbbLoaiCong.Name = "cbbLoaiCong";
            cbbLoaiCong.Size = new Size(182, 33);
            cbbLoaiCong.TabIndex = 43;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(506, 20);
            label6.Name = "label6";
            label6.Size = new Size(89, 25);
            label6.TabIndex = 42;
            label6.Text = "Loại công";
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(1116, 264);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(112, 34);
            btnTimKiem.TabIndex = 41;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(698, 267);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(422, 31);
            txtTimKiem.TabIndex = 40;
            // 
            // btnTaiLai
            // 
            btnTaiLai.Location = new Point(1116, 182);
            btnTaiLai.Name = "btnTaiLai";
            btnTaiLai.Size = new Size(112, 34);
            btnTaiLai.TabIndex = 39;
            btnTaiLai.Text = "Tải lại";
            btnTaiLai.UseVisualStyleBackColor = true;
            btnTaiLai.Click += btnTaiLai_Click;
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(1116, 94);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(112, 34);
            btnHuy.TabIndex = 38;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(1116, 14);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(112, 34);
            btnLuu.TabIndex = 37;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(972, 179);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(112, 34);
            btnXoa.TabIndex = 36;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(972, 91);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(112, 34);
            btnSua.TabIndex = 35;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(972, 15);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(112, 34);
            btnThem.TabIndex = 34;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 261);
            label3.Name = "label3";
            label3.Size = new Size(99, 25);
            label3.TabIndex = 29;
            label3.Text = "Ngày công";
            // 
            // dtpNgayCong
            // 
            dtpNgayCong.Location = new Point(160, 258);
            dtpNgayCong.Name = "dtpNgayCong";
            dtpNgayCong.Size = new Size(182, 31);
            dtpNgayCong.TabIndex = 28;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 101);
            label2.Name = "label2";
            label2.Size = new Size(118, 25);
            label2.TabIndex = 27;
            label2.Text = "Mã nhân viên";
            // 
            // cboMaNV
            // 
            cboMaNV.FormattingEnabled = true;
            cboMaNV.Location = new Point(160, 98);
            cboMaNV.Name = "cboMaNV";
            cboMaNV.Size = new Size(182, 33);
            cboMaNV.TabIndex = 25;
            cboMaNV.SelectedIndexChanged += cboMaNV_SelectedIndexChanged;
            // 
            // txtMaCC
            // 
            txtMaCC.Location = new Point(160, 21);
            txtMaCC.Name = "txtMaCC";
            txtMaCC.ReadOnly = true;
            txtMaCC.Size = new Size(182, 31);
            txtMaCC.TabIndex = 24;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 21);
            label1.Name = "label1";
            label1.Size = new Size(130, 25);
            label1.TabIndex = 23;
            label1.Text = "Mã chấm công";
            // 
            // dgvChamCong
            // 
            dgvChamCong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvChamCong.BackgroundColor = Color.White;
            dgvChamCong.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvChamCong.Dock = DockStyle.Bottom;
            dgvChamCong.Location = new Point(0, 328);
            dgvChamCong.Name = "dgvChamCong";
            dgvChamCong.RowHeadersWidth = 62;
            dgvChamCong.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvChamCong.Size = new Size(1240, 406);
            dgvChamCong.TabIndex = 22;
            dgvChamCong.CellClick += dgvChamCong_CellClick;
            // 
            // txtTen
            // 
            txtTen.Location = new Point(160, 179);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(182, 31);
            txtTen.TabIndex = 45;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(11, 179);
            label7.Name = "label7";
            label7.Size = new Size(119, 25);
            label7.TabIndex = 44;
            label7.Text = "Tên nhân viên";
            // 
            // txtGV
            // 
            txtGV.Location = new Point(532, 98);
            txtGV.Name = "txtGV";
            txtGV.Size = new Size(79, 31);
            txtGV.TabIndex = 47;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(444, 104);
            label4.Name = "label4";
            label4.Size = new Size(73, 25);
            label4.TabIndex = 46;
            label4.Text = "Giờ vào";
            // 
            // txtPV
            // 
            txtPV.Location = new Point(532, 179);
            txtPV.Name = "txtPV";
            txtPV.Size = new Size(79, 31);
            txtPV.TabIndex = 49;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(444, 182);
            label5.Name = "label5";
            label5.Size = new Size(82, 25);
            label5.TabIndex = 48;
            label5.Text = "Phút vào";
            // 
            // txtPR
            // 
            txtPR.Location = new Point(774, 182);
            txtPR.Name = "txtPR";
            txtPR.Size = new Size(79, 31);
            txtPR.TabIndex = 53;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(686, 185);
            label8.Name = "label8";
            label8.Size = new Size(68, 25);
            label8.TabIndex = 52;
            label8.Text = "Phút ra";
            // 
            // txtGR
            // 
            txtGR.Location = new Point(774, 101);
            txtGR.Name = "txtGR";
            txtGR.Size = new Size(79, 31);
            txtGR.TabIndex = 51;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(686, 107);
            label9.Name = "label9";
            label9.Size = new Size(59, 25);
            label9.TabIndex = 50;
            label9.Text = "Giờ ra";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(444, 264);
            label10.Name = "label10";
            label10.Size = new Size(66, 25);
            label10.TabIndex = 54;
            label10.Text = "Ca làm";
            // 
            // cbbCa
            // 
            cbbCa.FormattingEnabled = true;
            cbbCa.Location = new Point(510, 264);
            cbbCa.Name = "cbbCa";
            cbbCa.Size = new Size(101, 33);
            cbbCa.TabIndex = 55;
            // 
            // UC_QLChamCong
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(cbbCa);
            Controls.Add(label10);
            Controls.Add(txtPR);
            Controls.Add(label8);
            Controls.Add(txtGR);
            Controls.Add(label9);
            Controls.Add(txtPV);
            Controls.Add(label5);
            Controls.Add(txtGV);
            Controls.Add(label4);
            Controls.Add(txtTen);
            Controls.Add(label7);
            Controls.Add(cbbLoaiCong);
            Controls.Add(label6);
            Controls.Add(btnTimKiem);
            Controls.Add(txtTimKiem);
            Controls.Add(btnTaiLai);
            Controls.Add(btnHuy);
            Controls.Add(btnLuu);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(label3);
            Controls.Add(dtpNgayCong);
            Controls.Add(label2);
            Controls.Add(cboMaNV);
            Controls.Add(txtMaCC);
            Controls.Add(label1);
            Controls.Add(dgvChamCong);
            Name = "UC_QLChamCong";
            Size = new Size(1240, 734);
            Load += UC_QLChamCong_Load_1;
            ((System.ComponentModel.ISupportInitialize)dgvChamCong).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbbLoaiCong;
        private Label label6;
        private Button btnTimKiem;
        private TextBox txtTimKiem;
        private Button btnTaiLai;
        private Button btnHuy;
        private Button btnLuu;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private Label label3;
        private DateTimePicker dtpNgayCong;
        private Label label2;
        private ComboBox cboMaNV;
        private TextBox txtMaCC;
        private Label label1;
        private DataGridView dgvChamCong;
        private TextBox txtTen;
        private Label label7;
        private TextBox txtGV;
        private Label label4;
        private TextBox txtPV;
        private Label label5;
        private TextBox txtPR;
        private Label label8;
        private TextBox txtGR;
        private Label label9;
        private Label label10;
        private ComboBox cbbCa;
    }
}
