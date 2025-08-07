using DocumentFormat.OpenXml.Wordprocessing;
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

    public partial class UC_QLKhenThuong_KiLuat : UserControl
    {
        private readonly BLL_QLKhenThuong_KiLuat _bll = new BLL_QLKhenThuong_KiLuat();
        public UC_QLKhenThuong_KiLuat()
        {
            InitializeComponent();
            LoadData();
            cboLoai.Items.AddRange(new string[] { "Khen thưởng", "Phê bình" });
        }
        private void LoadData()
        {
            dataGridView1.DataSource = _bll.GetAll()
                .Select(x => new
                {
                    x.IdktKl,
                    x.SoKtKl,
                    x.Loai,
                    x.NoiDung,
                    NgayRaQuyetDinh = x.NgayRaQuyetDinh.ToString("yyyy-MM-dd"),
                    x.Idnv
                }).ToList();
        }
        private void ClearForm()
        {
            txtIDKTKL.Text = "";
            txtSoKTKL.Text = "";
            cboLoai.SelectedIndex = -1;
            txtNoiDung.Text = "";
            dtpNgayRa.Value = DateTime.Now;
            txtIDNV.Text = "";
        }
        private KhenthuongKiluat GetFormData()
        {

            return new KhenthuongKiluat
            {
                IdktKl = string.IsNullOrEmpty(txtIDKTKL.Text) ? 0 : int.Parse(txtIDKTKL.Text),
                SoKtKl = int.Parse(txtSoKTKL.Text),
                Loai = cboLoai.Text,
                NoiDung = txtNoiDung.Text,
                NgayRaQuyetDinh = DateOnly.FromDateTime(dtpNgayRa.Value),
                Idnv = string.IsNullOrEmpty(txtIDNV.Text) ? 0 : int.Parse(txtIDNV.Text)
            };
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSoKTKL.Text) || string.IsNullOrEmpty(cboLoai.Text) || string.IsNullOrEmpty(txtIDNV.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin");
                return;
            }

            if (!int.TryParse(txtSoKTKL.Text, out int soktkl) || !int.TryParse(txtIDNV.Text, out int idnv))
            {
                MessageBox.Show("Số quyết định và IDNV phải là số");
                return;
            }
            var dto = GetFormData();
            _bll.Add(dto);
            LoadData();

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSoKTKL.Text) || string.IsNullOrEmpty(cboLoai.Text) || string.IsNullOrEmpty(txtIDNV.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin");
                return;
            }

            if (!int.TryParse(txtSoKTKL.Text, out int soktkl) || !int.TryParse(txtIDNV.Text, out int idnv))
            {
                MessageBox.Show("Số quyết định và IDNV phải là số");
                return;
            }

            var dto = GetFormData();
            _bll.Update(dto);
            LoadData();

        }

        private void btnLM_Click(object sender, EventArgs e)
        {
            ClearForm();
            LoadData();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtIDKTKL.Text);
            _bll.Delete(id);
            LoadData();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string keyword = txtNoiDung.Text.Trim();
            dataGridView1.DataSource = _bll.Search(keyword)
                .Select(x => new
                {
                    x.IdktKl,
                    x.SoKtKl,
                    x.Loai,
                    x.NoiDung,
                    NgayRaQuyetDinh = x.NgayRaQuyetDinh.ToString("yyyy-MM-dd"),
                    x.Idnv
                }).ToList();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txtIDKTKL.Text = row.Cells["IdktKl"].Value.ToString();
                txtSoKTKL.Text = row.Cells["SoktKl"].Value.ToString();
                cboLoai.Text = row.Cells["Loai"].Value.ToString();
                txtNoiDung.Text = row.Cells["NoiDung"].Value.ToString();
                dtpNgayRa.Value = DateTime.Parse(row.Cells["NgayRaQuyetDinh"].Value.ToString());
                txtIDNV.Text = row.Cells["Idnv"].Value.ToString();
            }
        }
    }
}
