using DocumentFormat.OpenXml.Wordprocessing;
using NHOM1_DA1_QUANLINHANSU.BLL;
using NHOM1_DA1_QUANLINHANSU.DTO;
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
    public partial class UC_QLTaiKhoan : UserControl
    {
        private readonly BLL_QLTaiKhoan _bll = new();

        public UC_QLTaiKhoan()
        {
            InitializeComponent();
            LoadVaiTro();
            LoadTrangThai();
            LoadGrid();

        }
        private void LoadVaiTro()
        {
            cmbVaiTro.DisplayMember = "TenVaiTro";
            cmbVaiTro.ValueMember = "IDVaiTro";
            cmbVaiTro.DataSource = _bll.GetVaiTro();
        }
        private void LoadTrangThai()
        {
            cmbTrangThai.Items.Clear();
            cmbTrangThai.Items.Add("Hoạt Động");
            cmbTrangThai.Items.Add("Khóa");
            cmbTrangThai.SelectedIndex = 0;
        }
        private void LoadGrid()
        {
            dataGridView1.DataSource = _bll.GetAll();
        }
        
        private void textBox_QLNV_ID_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var row = dataGridView1.Rows[e.RowIndex];
            tbID.Text = row.Cells["IdtaiKhoan"].Value?.ToString();
            tbTenNV.Text = row.Cells["TenHienThi"].Value?.ToString();
            tbTenTK.Text = row.Cells["TenTaiKhoan"].Value?.ToString();
            tbMK.Text = row.Cells["MatKhau"].Value?.ToString();
            cmbTrangThai.Text = row.Cells["TrangThai"].Value?.ToString();
            var vaiTro = row.Cells["TenVaiTro"].Value?.ToString() ?? "";
            cmbVaiTro.SelectedIndex = cmbVaiTro.FindStringExact(vaiTro);
        }

        private void button_QLNV_Them_Click(object sender, EventArgs e)
        {
            var tk = new Taikhoan
            {
                TenHienThi = tbTenNV.Text.Trim(),
                TenTaiKhoan = tbTenTK.Text.Trim(),
                MatKhau = tbMK.Text,
                TrangThai = cmbTrangThai.Text,
                IdvaiTro = Convert.ToInt32(cmbVaiTro.SelectedValue)
            };
            _bll.Them(tk);
            LoadGrid();
            ClearInputs();
        }

        private void button_QLNV_Sua_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(tbID.Text, out int id)) return;
            var tk = new Taikhoan
            {
                IdtaiKhoan = id,
                TenHienThi = tbTenNV.Text.Trim(),
                TenTaiKhoan = tbTenTK.Text.Trim(),
                MatKhau = tbMK.Text,
                TrangThai = cmbTrangThai.Text,
                IdvaiTro = Convert.ToInt32(cmbVaiTro.SelectedValue)
            };
            _bll.Sua(tk);
            LoadGrid();
            ClearInputs();
        }

        private void button_QLNV_Xoa_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(tbID.Text, out int id)) return;
            _bll.Xoa(id);
            LoadGrid();
            ClearInputs();

        }

        private void button_TimKiem_Click(object sender, EventArgs e)
        {
            string key = textBox_TimKiem.Text.Trim();
            if (string.IsNullOrEmpty(key))
                LoadGrid();
            else
                dataGridView1.DataSource = _bll.TimKiem(key);
        }
        private void ClearInputs()
        {
            tbID.Clear();
            tbTenNV.Clear();
            tbTenTK.Clear();
            tbMK.Clear();
            cmbTrangThai.SelectedIndex = 0;
            if (cmbVaiTro.Items.Count > 0) cmbVaiTro.SelectedIndex = 0;
        }
    }
}
