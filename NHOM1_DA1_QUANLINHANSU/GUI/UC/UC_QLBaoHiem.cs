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
    public partial class UC_QLBaoHiem : UserControl
    {
        private BLL_QLBaoHiem _bll = new BLL_QLBaoHiem();
        public UC_QLBaoHiem()
        {
            InitializeComponent();
            
            LoadData();
            cboLoaiBH.Items.AddRange(new string[] { "BHYT", "BHXH" });
            cboTrangThai.Items.AddRange(new string[] { "Hiệu lực", "Hết hiệu lực" });
        }
        private void LoadData()
        {
            dataGridView1.DataSource = _bll.LayDanhSach();
        }
       
        private void LamMoi()
        {
            txtIDBH.Clear();
            cboLoaiBH.SelectedIndex = -1;
            txtSoBH.Clear();
            dtpNgayCap.Value = DateTime.Now;
            txtNoiCap.Clear();
            txtNoiDK.Clear();
            dtpNgayBatDau.Value = DateTime.Now;
            dtpNgayHetHan.Value = DateTime.Now;
            cboTrangThai.SelectedIndex = -1;
            txtIDNV.Clear();
        }

        private void button_QLBH_Them_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSoBH.Text) || !int.TryParse(txtSoBH.Text.Trim(), out int soBH))
            {
                MessageBox.Show("Số bảo hiểm không hợp lệ!");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtIDNV.Text) || !int.TryParse(txtIDNV.Text.Trim(), out int idnv))
            {
                MessageBox.Show("ID nhân viên không hợp lệ!");
                return;
            }

            // Lấy dữ liệu từ combobox LoaiBaoHiem
           
            var bh = new Baohiem
            {

                LoaiBaoHiem = cboLoaiBH.Text,
                SoBaoHiem = int.Parse(txtSoBH.Text.Trim()),
                NgayCap = DateOnly.FromDateTime(dtpNgayCap.Value),
                NoiCap = txtNoiCap.Text,
                NoiDangKi = txtNoiDK.Text,
                NgayBatDau = DateOnly.FromDateTime(dtpNgayBatDau.Value),
                NgayHetHan = DateOnly.FromDateTime(dtpNgayHetHan.Value),
                TrangThai = cboTrangThai.Text,
                Idnv = int.Parse(txtIDNV.Text.Trim())

            };
            _bll.Them(bh);
            LoadData();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtIDBH.Text.Trim(), out int id))
            {
                MessageBox.Show("ID bảo hiểm không hợp lệ.");
                return;
            }
            if (!int.TryParse(txtSoBH.Text.Trim(), out int soBH))
            {
                MessageBox.Show("Số bảo hiểm không hợp lệ.");
                return;
            }

            if (!int.TryParse(txtIDNV.Text.Trim(), out int idNV))
            {
                MessageBox.Show("ID nhân viên không hợp lệ.");
                return;
            }

          
            var bh = new Baohiem
            {
                IdbaoHiem = id,
                LoaiBaoHiem = cboLoaiBH.Text,
                SoBaoHiem = int.Parse(txtSoBH.Text.Trim()),
                NgayCap = DateOnly.FromDateTime(dtpNgayCap.Value),
                NoiCap = txtNoiCap.Text,
                NoiDangKi = txtNoiDK.Text,
                NgayBatDau = DateOnly.FromDateTime(dtpNgayBatDau.Value),
                NgayHetHan = DateOnly.FromDateTime(dtpNgayHetHan.Value),
                TrangThai = cboTrangThai.Text,
                Idnv = int.Parse(txtIDNV.Text.Trim())
            };
            _bll.CapNhat(bh);
            LoadData();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int id = int.TryParse(txtIDBH.Text.Trim(), out id) ? id : 0;
            _bll.Xoa(id);
            LoadData();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LamMoi();
            LoadData();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string timkem = txtTK.Text;
            dataGridView1.DataSource = _bll.TimKiem(timkem);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txtIDBH.Text = row.Cells["IdbaoHiem"].Value.ToString();
                cboLoaiBH.Text = row.Cells["LoaiBaoHiem"].Value.ToString();
                txtSoBH.Text = row.Cells["SoBaoHiem"].Value.ToString();
                dtpNgayCap.Value = DateTime.Parse(row.Cells["NgayCap"].Value.ToString());
                txtNoiCap.Text = row.Cells["NoiCap"].Value.ToString();
                txtNoiDK.Text = row.Cells["NoiDangKi"].Value.ToString();
                dtpNgayBatDau.Value = DateTime.Parse(row.Cells["NgayBatDau"].Value.ToString());
                dtpNgayHetHan.Value = DateTime.Parse(row.Cells["NgayHetHan"].Value.ToString());
                cboTrangThai.Text = row.Cells["TrangThai"].Value.ToString();
                txtIDNV.Text = row.Cells["Idnv"].Value.ToString();
            }
        }
    }
}
