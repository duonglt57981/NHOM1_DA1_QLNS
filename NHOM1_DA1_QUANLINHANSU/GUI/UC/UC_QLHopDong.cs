using ClosedXML.Excel;
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
            comboBox_QLHD_IDNV.ValueMember = "Idnv";
            comboBox_QLHD_IDNV.DisplayMember = "Idnv";

            var index = QLHD_BLL.GetAllNhanVien();
            comboBox_QLHD_IDNV.SelectedIndexChanged += new(comboBox_QLHD_IDNV_SelectedIndexChanged);
            ThongTinNhanVien(index[0]);
        }


        private void comboBox_QLHD_IDNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            int IDNV = int.Parse(comboBox_QLHD_IDNV.SelectedIndex.ToString().Trim());
            Nhanvien nv = QLHD_BLL.GetAllNhanVien().FirstOrDefault(n => n.Idnv == IDNV);

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

            DialogResult kq = MessageBox.Show("Bạn muốn sửa nhân viên này không!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (kq == DialogResult.No)
            {
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

            DialogResult kq = MessageBox.Show("Bạn muốn xóa nhân viên này không!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (kq == DialogResult.No)
            {
                return;
            }

            int soHopDong = int.Parse(textBox_QLHD_SoHD.Text.Trim());

            QLHD_BLL.XoaHopDong(soHopDong);
            LoadHD();
        }

        private void button_QLHD_LamMoi_Click(object sender, EventArgs e)
        {
            textBox_QLHD_SoHD.Clear();
            textBox_QLHD_HSLuong.Clear();
            textBox_QLHD_LuongCB.Clear();
            textBox_QLHD_NoiDung.Clear();
            textBox_QLHD_LanKi.Clear();
            textBox_QLHD_ThoiHan.Clear();
            LoadHD();
        }

        private void button_QLHD_XuatFile_Click(object sender, EventArgs e)
        {
            var qlhd = QLHD_BLL.GetAllHopDong();
            using (var sfd = new SaveFileDialog())
            {
                sfd.Filter = "Excel Workbook|*.xlsx";
                sfd.Title = "Chọn nơi lưu file";
                sfd.FileName = "DanhSachHopDong.xlsx";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    string filePath = sfd.FileName;

                    if (System.IO.File.Exists(filePath))
                    {
                        MessageBox.Show("File đã tồn tại. Vui lòng chọn tên khác hoặc xóa file cũ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    try
                    {
                        using (var workbook = new XLWorkbook())
                        {
                            var worksheet = workbook.Worksheets.Add("Danh sách nhân viên");
                            worksheet.Cell(1, 1).Value = "STT";
                            worksheet.Cell(1, 2).Value = "Số Hợp Đồng";
                            worksheet.Cell(1, 3).Value = "Loại Hợp Đồng";
                            worksheet.Cell(1, 4).Value = "Ngày bắt đầu";
                            worksheet.Cell(1, 5).Value = "Ngày kết thúc";
                            worksheet.Cell(1, 6).Value = "Ngày ký hợp đồng";
                            worksheet.Cell(1, 7).Value = "Lần Ký";
                            worksheet.Cell(1, 8).Value = "Nội dung";
                            worksheet.Cell(1, 9).Value = "HS Lương";
                            worksheet.Cell(1, 10).Value = "Lương cơ bản";
                            worksheet.Cell(1, 11).Value = "Trạng thái";
                            worksheet.Cell(1, 12).Value = "ID Nhân viên";
                            worksheet.Cell(1, 13).Value = "Tên nhân viên";
                            worksheet.Cell(1, 14).Value = "SĐT";
                            worksheet.Cell(1, 15).Value = "CCCD";
                            worksheet.Cell(1, 16).Value = "Địa chỉ";

                            int row = 2;
                            foreach (var nv in qlhd)
                            {
                                worksheet.Cell(row, 1).Value = nv.STT;
                                worksheet.Cell(row, 2).Value = nv.SoHopDong;
                                worksheet.Cell(row, 3).Value = nv.LoainHopDong;
                                worksheet.Cell(row, 4).Value = nv.NgayBd.ToString("dd/MM/yyyy");
                                worksheet.Cell(row, 5).Value = nv.NgayKt.ToString("dd/MM/yyyy");
                                worksheet.Cell(row, 6).Value = nv.NgayKiHopDong.ToString("dd/MM/yyyy");
                                worksheet.Cell(row, 7).Value = nv.LanKi;
                                worksheet.Cell(row, 8).Value = nv.NoiDung;
                                worksheet.Cell(row, 9).Value = nv.HeSoLuong;
                                worksheet.Cell(row, 10).Value = nv.LuongCoBan;
                                worksheet.Cell(row, 11).Value = nv.TrangThai;
                                worksheet.Cell(row, 12).Value = nv.Idnv;
                                worksheet.Cell(row, 13).Value = nv.TenNv;
                                worksheet.Cell(row, 14).Value = nv.Sdt;
                                worksheet.Cell(row, 15).Value = nv.Cccd;
                                worksheet.Cell(row, 16).Value = nv.DiaChi;
                                row++;
                            }

                            workbook.SaveAs(filePath);
                        }

                        MessageBox.Show($"Xuất file thành công: {Path.GetFileName(filePath)}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Lưu file thất bại: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void button_QLHD_TimKiem_Click(object sender, EventArgs e)
        {
            string tk = textBox_QLHD_TimKiem.Text.Trim();
            if (string.IsNullOrEmpty(tk))
            {
                MessageBox.Show("Vui lòng nhập từ khóa cần tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            List<DTO_QLHopDong> kq = QLHD_BLL.TimKiem(tk);
            if (kq.Any())
            {
                dataGridView_QLHD.DataSource = kq;
            }
            else
            {
                MessageBox.Show("Không tìm thấy thông tin nào nào với từ khóa: " + tk,
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadHD();
            }
        }

        private void dataGridView_QLHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
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
                comboBox_QLHD_IDNV.SelectedValue = dataGridView_QLHD.Rows[e.RowIndex].Cells["Idnv"].Value;
            }
        }
    }
}
