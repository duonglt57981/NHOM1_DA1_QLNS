using NHOM1_DA1_QUANLINHANSU.BLL;
using NHOM1_DA1_QUANLINHANSU.Models;

namespace NHOM1_DA1_QUANLINHANSU.GUI.UC
{
    public partial class UC_QLChamCong : UserControl
    {
        public UC_QLChamCong()
        {

            InitializeComponent();
            LoadNhanVien();
            LoadLoaiCong();
            LoadData();
            LoadCaLam();
        }

        BLL_QLChamCong bllCC = new BLL_QLChamCong();
        private void UC_QLChamCong_Load(object sender, EventArgs e)
        {


        }

        public void ThongTinNV(Nhanvien nv)
        {
            txtTen.Text = nv.TenNv;
        }
        private void LoadNhanVien()
        {
            cboMaNV.DataSource = bllCC.GetNhanVien();
            cboMaNV.DisplayMember = "Idnv";
            cboMaNV.ValueMember = "Idnv";

            var index = bllCC.GetNhanVien();
            cboMaNV.SelectedIndexChanged += new (cboMaNV_SelectedIndexChanged);
            ThongTinNV(index[0]);
        }

        private void LoadLoaiCong()
        {
            var listLoaiCong = bllCC.GetAllLoaiCong();
            cbbLoaiCong.DataSource = listLoaiCong;
            cbbLoaiCong.DisplayMember = "TenLoaiCong";
            cbbLoaiCong.ValueMember = "IdloaiCong";
        }

        private void LoadData()
        {
            var list = bllCC.GetAll();
            dgvChamCong.DataSource = list;
            dgvChamCong.ClearSelection();
        }

        private void LoadCaLam()
        {
            cbbCa.Items.Add("Ca Sáng");
            cbbCa.Items.Add("Ca Tối");
        }
        private void UC_QLChamCong_Load_1(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                Chamcong cc = new Chamcong()
                {
                    Idnv = Convert.ToInt32(cboMaNV.SelectedValue),
                    IdloaiCong = Convert.ToInt32(cbbLoaiCong.SelectedValue),
                    Ngay = int.Parse(dtpNgayCong.Value.Day.ToString()),
                    Thang = int.Parse(dtpNgayCong.Value.Month.ToString()),
                    Nam = int.Parse(dtpNgayCong.Value.Year.ToString()),
                    CaLam = cbbCa.Text,
                    GioVao = int.Parse(txtGV.Text),
                    PhutVao = int.Parse(txtPV.Text),
                    GioRa = int.Parse(txtGR.Text),
                    PhutRa = int.Parse(txtPR.Text),

                };

                bool result = bllCC.AddChamCong(cc);
                if (result)
                {
                    MessageBox.Show("Thêm chấm công thành công!");
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Thêm thất bại. Nhân viên đã được chấm công hôm nay.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                Chamcong cc = new Chamcong()
                {
                    IdchamCong = int.Parse(txtMaCC.Text),
                    Idnv = Convert.ToInt32(cboMaNV.SelectedValue),
                    IdloaiCong = Convert.ToInt32(cbbLoaiCong.SelectedValue),
                    Ngay = int.Parse(dtpNgayCong.Value.Day.ToString()),
                    Thang = int.Parse(dtpNgayCong.Value.Month.ToString()),
                    Nam = int.Parse(dtpNgayCong.Value.Year.ToString()),
                    CaLam = cbbCa.Text,
                    GioVao = int.Parse(txtGV.Text),
                    PhutVao = int.Parse(txtPV.Text),
                    GioRa = int.Parse(txtGR.Text),
                    PhutRa = int.Parse(txtPR.Text),

                };

                bool result = bllCC.UpdateChamCong(cc);
                if (result)
                {
                    MessageBox.Show("Cập nhật thành công!");
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy bản ghi để cập nhật.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(txtMaCC.Text);
                if (MessageBox.Show("Bạn có chắc muốn xoá?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    bool result = bllCC.DeleteChamCong(id);
                    if (result)
                    {
                        MessageBox.Show("Xoá thành công!");
                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show("Xoá thất bại.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            btnThem_Click(sender, e);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            int keyword = int.Parse(txtTimKiem.Text.Trim());
            dgvChamCong.DataSource = bllCC.SearchChamCong(keyword);
        }

        private void btnTaiLai_Click(object sender, EventArgs e)
        {
            LoadData();
            txtMaCC.Clear();

            txtTen.Clear();
            txtTimKiem.Clear();
            cboMaNV.SelectedIndex = 0;
            cbbLoaiCong.SelectedIndex = 0;
        }

        private void dgvChamCong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= -1)
            {
                DataGridViewRow row = dgvChamCong.Rows[e.RowIndex];
                txtMaCC.Text = dgvChamCong.Rows[e.RowIndex].Cells["IdchamCong"].Value.ToString();
                cboMaNV.SelectedValue = Convert.ToInt32(row.Cells["Idnv"].Value);
                cbbLoaiCong.Text = dgvChamCong.Rows[e.RowIndex].Cells["IdloaiCong"].Value.ToString();
                txtGV.Text = dgvChamCong.Rows[e.RowIndex].Cells["GioVao"].Value.ToString();
                txtGR.Text = dgvChamCong.Rows[e.RowIndex].Cells["GioRa"].Value.ToString();
                txtPV.Text = dgvChamCong.Rows[e.RowIndex].Cells["PhutVao"].Value.ToString();
                txtPR.Text = dgvChamCong.Rows[e.RowIndex].Cells["PhutRa"].Value.ToString();
                cbbCa.Text = dgvChamCong.Rows[e.RowIndex].Cells["CaLam"].Value.ToString();
                
            }
        }

        private void cboMaNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idnv = int.Parse(cboMaNV.SelectedIndex.ToString().Trim());
            Nhanvien nv = bllCC.GetNhanVien().FirstOrDefault(nv => nv.Idnv == idnv);

            if (nv != null)
            {
                ThongTinNV(nv);
            }
        }
    }
}
