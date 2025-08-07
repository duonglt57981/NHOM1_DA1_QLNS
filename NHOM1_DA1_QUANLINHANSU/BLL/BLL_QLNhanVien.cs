using NHOM1_DA1_QUANLINHANSU.DAL;
using NHOM1_DA1_QUANLINHANSU.DTO;
using NHOM1_DA1_QUANLINHANSU.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHOM1_DA1_QUANLINHANSU.BLL
{
    internal class BLL_QLNhanVien
    {
        private DAL_QLNhanVien QLNV_DAL = new DAL_QLNhanVien();

        public List<DTO_QLNhanVien> GetAllNhanVien()
        {
            return QLNV_DAL.GetAllNhanVien();
        }

        public List<Phongban> GetPhongBAN()
        {
            return QLNV_DAL.GetPhongBAN();
        }

        public List<Congviec> GetCongViec()
        {
            return QLNV_DAL.GetCongViec();
        }
        public List<Trinhdo> GetTrinhDo()
        {
            return QLNV_DAL.GetTrinhDo();
        }

        public List<Taikhoan> GetTaiKhoan()
        {
            return QLNV_DAL.GetTaiKhoan().ToList()
                     .Where(nv => nv.IdvaiTro == 1 && nv.TrangThai == "Hoạt Động").ToList();
        }

        public void ThemNhanVien(Nhanvien nv)
        {
            if (QLNV_DAL.KiemTraTaiKhoan(nv.IdtaiKhoan))
            {
                var KT = MessageBox.Show("Tài Khoản này đã được đăng kí cho nhân viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (QLNV_DAL.KiemTraSDT(nv.Sdt))
            {
                var KT = MessageBox.Show("Số điện thoại này đã được đăng kí cho nhân viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (QLNV_DAL.KiemTraCCCD(nv.Cccd))
            {
                var KT = MessageBox.Show("CCCD này đã được đăng kí cho nhân viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                QLNV_DAL.ThemNhanVien(nv);
            }
        }

        public bool KiemTraIDNV(int idnv)
        {
             return QLNV_DAL.KiemTraIDNV(idnv);
        }

        public bool KiemTraTaiKhoan(int IDTK)
        {
            return QLNV_DAL.KiemTraTaiKhoan(IDTK);
        }
        public void SuaNhanVien(Nhanvien NewNV)
        {
            QLNV_DAL.SuaNhanVien(NewNV);
        }

        public void XoaNhanVien(int idnv)
        {
            if (QLNV_DAL.KiemTraNhanVienBangHopDong(idnv))
            {
                MessageBox.Show("Nhân viên này đang có hợp đồng, không thể xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }else if (QLNV_DAL.KiemTraNhanVienBangChamCong(idnv))
            {
                MessageBox.Show("Nhân viên này đang có chấm công, không thể xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }else if(QLNV_DAL.KiemTraNhanVienBangKT_KL(idnv))
            {
                MessageBox.Show("Nhân viên này đang có khen thưởng kỉ luật, không thể xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }else if (QLNV_DAL.KiemTraNhanVienCoBaoHiem(idnv))
            {
                MessageBox.Show("Nhân viên này đang có bảo hiểm, không thể xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                QLNV_DAL.XoaNhanVien(idnv);
            }
        }

        public List<DTO_QLNhanVien> TimKiemNV(string tuKhoa)
        {
            return QLNV_DAL.TimKiemNV(tuKhoa);
        }
    }
}
