using NHOM1_DA1_QUANLINHANSU.BLL;
using NHOM1_DA1_QUANLINHANSU.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NHOM1_DA1_QUANLINHANSU.GUI.UC
{
    public partial class UC_QLHopDong : UserControl
    {
        private BLL_QLHopDong QLHD_BLL = new BLL_QLHopDong();
        public UC_QLHopDong()
        {
            InitializeComponent();
            LoadHD();
            LoadLoaiHD();
            LoadTrangThai();
            LoadThongTinNV();
        }


        public void LoadHD()
        {
            dataGridView_QLHD.DataSource = QLHD_BLL.GetAllHopDong();
        }

        public void LoadLoaiHD()
        {
            comboBox_QLHD_LoaiHD.DataSource = QLHD_BLL.GetAllLoaiHopDong();
            comboBox_QLHD_LoaiHD.DisplayMember = "TenHopDong";
            comboBox_QLHD_LoaiHD.ValueMember = "IdloaiHopDong";
        }

        public void LoadTrangThai()
        {
            comboBox_QLHD_TrangThai.Items.Add("Còn Hạn");
            comboBox_QLHD_TrangThai.Items.Add("Hết Hạn");
            comboBox_QLHD_TrangThai.Items.Add("Khác");
            comboBox_QLHD_TrangThai.SelectedIndex = 0;
        }

        public void ThongTinNhanVien(Nhanvien nv)
        {
            textBox_QLHD_TenNV.Text = nv.TenNv;
            textBox_QLHD_SDT.Text = nv.Sdt;
            textBox_QLHD_CCCD.Text = nv.Cccd;
            textBox_QLHD_DiaChi.Text = nv.DiaChi;
        }

        public void LoadThongTinNV()
        {
            comboBox_QLHD_IDNV.DataSource = QLHD_BLL.GetAllNhanVien();
            var index = QLHD_BLL.GetAllNhanVien();
            comboBox_QLHD_IDNV.ValueMember = "Idnv";
            comboBox_QLHD_IDNV.DisplayMember = "Idnv";

            comboBox_QLHD_IDNV.SelectedIndexChanged += new (comboBox_QLHD_IDNV_SelectedIndexChanged);

            ThongTinNhanVien(index[0]);
        }


        private void comboBox_QLHD_IDNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            string IDNV = comboBox_QLHD_IDNV.SelectedValue.ToString();
            Nhanvien nv = QLHD_BLL.GetAllNhanVien().FirstOrDefault(n => n.Idnv.ToString() == IDNV);

            if (nv != null)
            {
                ThongTinNhanVien(nv);
            }
        }

        private void button_QLHD_Them_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_QLHD_ThoiHan.Text)
                || string.IsNullOrEmpty(textBox_QLHD_HSLuong.Text)
                || string.IsNullOrEmpty(textBox_QLHD_LanKi.Text)
                || string.IsNullOrEmpty(textBox_QLHD_LuongCB.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin hợp đồng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Hopdong hd = new Hopdong
            {
                NgayBd = DateOnly.FromDateTime(dateTimePicker_QLHD_NgayBD.Value),
                NgayKt = DateOnly.FromDateTime(dateTimePicker_QLHD_NgayKT.Value),
                NgayKiHopDong = DateOnly.FromDateTime(dateTimePicker_QLHD_NgayKiHD.Value),
                IdloaiHd = (int)comboBox_QLHD_LoaiHD.SelectedValue,
                TrangThai = comboBox_QLHD_TrangThai.SelectedItem.ToString().Trim(),
                ThoiHan = textBox_QLHD_ThoiHan.Text.Trim(),
                HeSoLuong = double.Parse(textBox_QLHD_HSLuong.Text),
                LuongCoBan = double.Parse(textBox_QLHD_LuongCB.Text.Trim()),
                LanKi = int.Parse(textBox_QLHD_LanKi.Text),
                NoiDung = textBox_QLHD_NoiDung.Text.Trim(),
                Idnv = int.Parse(comboBox_QLHD_IDNV.Text.Trim())
            };

            QLHD_BLL.ThemHopDong(hd);
            LoadHD();
        }

        private void button_QLHD_Sua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_QLHD_SoHD.Text))
            {
                MessageBox.Show("Vui lòng chọn hợp đồng cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(textBox_QLHD_ThoiHan.Text)
               || string.IsNullOrEmpty(textBox_QLHD_HSLuong.Text)
               || string.IsNullOrEmpty(textBox_QLHD_LanKi.Text)
               || string.IsNullOrEmpty(textBox_QLHD_LuongCB.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin hợp đồng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Hopdong hd = new Hopdong
            {
                SoHopDong = int.Parse(textBox_QLHD_SoHD.Text.Trim()),
                NgayBd = DateOnly.FromDateTime(dateTimePicker_QLHD_NgayBD.Value),
                NgayKt = DateOnly.FromDateTime(dateTimePicker_QLHD_NgayKT.Value),
                NgayKiHopDong = DateOnly.FromDateTime(dateTimePicker_QLHD_NgayKiHD.Value),
                IdloaiHd = (int)comboBox_QLHD_LoaiHD.SelectedValue,
                TrangThai = comboBox_QLHD_TrangThai.SelectedItem.ToString().Trim(),
                ThoiHan = textBox_QLHD_ThoiHan.Text.Trim(),
                HeSoLuong = double.Parse(textBox_QLHD_HSLuong.Text),
                LuongCoBan = double.Parse(textBox_QLHD_LuongCB.Text.Trim()),
                LanKi = int.Parse(textBox_QLHD_LanKi.Text),
                NoiDung = textBox_QLHD_NoiDung.Text.Trim(),
                Idnv = int.Parse(comboBox_QLHD_IDNV.Text.Trim())
            };

            QLHD_BLL.SuaHopDong(hd);
            LoadHD();
        }

        private void button_QLHD_Xoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_QLHD_SoHD.Text))
            {
                MessageBox.Show("Vui lòng chọn hợp đồng cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void button_QLHD_LamMoi_Click(object sender, EventArgs e)
        {

        }

        private void button_QLHD_XuatFile_Click(object sender, EventArgs e)
        {

        }

        private void button_QLHD_TimKiem_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView_QLHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex > -1)
            {
                dateTimePicker_QLHD_NgayBD.Text = dataGridView_QLHD.Rows[e.RowIndex].Cells["NgayBd"].Value.ToString();
                dateTimePicker_QLHD_NgayKT.Text = dataGridView_QLHD.Rows[e.RowIndex].Cells["NgayKt"].Value.ToString();
                dateTimePicker_QLHD_NgayKiHD.Text = dataGridView_QLHD.Rows[e.RowIndex].Cells["NgayKiHopDong"].Value.ToString();
                textBox_QLHD_SoHD.Text = dataGridView_QLHD.Rows[e.RowIndex].Cells["SoHopDong"].Value.ToString();
                comboBox_QLHD_LoaiHD.Text = dataGridView_QLHD.Rows[e.RowIndex].Cells["LoainHopDong"].Value.ToString();
                comboBox_QLHD_TrangThai.Text = dataGridView_QLHD.Rows[e.RowIndex].Cells["TrangThai"].Value.ToString();
                textBox_QLHD_ThoiHan.Text = dataGridView_QLHD.Rows[e.RowIndex].Cells["ThoiHan"].Value.ToString();
                textBox_QLHD_HSLuong.Text = dataGridView_QLHD.Rows[e.RowIndex].Cells["HeSoLuong"].Value.ToString();
                textBox_QLHD_LuongCB.Text = dataGridView_QLHD.Rows[e.RowIndex].Cells["LuongCoBan"].Value.ToString();
                textBox_QLHD_LanKi.Text = dataGridView_QLHD.Rows[e.RowIndex].Cells["LanKi"].Value.ToString();
                textBox_QLHD_NoiDung.Text = dataGridView_QLHD.Rows[e.RowIndex].Cells["NoiDung"].Value.ToString();
                comboBox_QLHD_IDNV.Text = dataGridView_QLHD.Rows[e.RowIndex].Cells["Idnv"].Value.ToString();
            }
        }
    }
}
