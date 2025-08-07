using Microsoft.EntityFrameworkCore;
using NHOM1_DA1_QUANLINHANSU.DTO;
using NHOM1_DA1_QUANLINHANSU.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHOM1_DA1_QUANLINHANSU.DAL
{
    internal class DAL_QLNhanVien
    {
        private Nhom1Da1QlnsContext _db = new Nhom1Da1QlnsContext();

        public List<DTO_QLNhanVien> GetAllNhanVien()
        {
            return _db.Nhanviens.Include(nv => nv.IdphongBanNavigation)
                .Include(nv => nv.IdcongViecNavigation)
                .Include(nv => nv.IdtrinhDoNavigation)
                .Include(nv => nv.IdtaiKhoanNavigation).ToList()
                .Select((x, index) => new DTO_QLNhanVien
                {
                    STT = index + 1,
                    Idnv = x.Idnv,
                    TenNv = x.TenNv,
                    GioiTinh = x.GioiTinh,
                    NgaySinh = x.NgaySinh,
                    Sdt = x.Sdt,
                    Cccd = x.Cccd,
                    DiaChi = x.DiaChi,
                    HinhAnh = x.HinhAnh,
                    SoTienPhuCap = x.SoTienPhuCap,
                    TrangThai = x.TrangThai,
                    TenTaiKhoan = x.IdtaiKhoanNavigation.TenTaiKhoan,
                    TenPhongBan = x.IdphongBanNavigation?.TenPhongBan,
                    TenCongViec = x.IdcongViecNavigation?.TenCongViec,
                    MoTaCV = x.IdcongViecNavigation?.MoTa,
                    TenTrinhDo = x.IdtrinhDoNavigation?.TenTrinhDo
                }).ToList();
        }

        public bool KiemTraTaiKhoan(int IDTK)
        {
            return _db.Nhanviens.Any(nv => nv.IdtaiKhoan == IDTK);
        }

        public bool KiemTraSDT(string sdt)
        {
            return _db.Nhanviens.Any(nv => nv.Sdt == sdt);
        }

        public bool KiemTraCCCD(string cccd)
        {
            return _db.Nhanviens.Any(nv => nv.Cccd == cccd);
        }

        public bool KiemTraIDNV(int idnv)
        {
            return _db.Nhanviens.Any(nv => nv.Idnv == idnv);
        }

        public bool KiemTraNhanVienBangHopDong(int idnv)
        {
            return _db.Hopdongs.Any(hd => hd.Idnv == idnv);
        }

        public bool KiemTraNhanVienBangKT_KL(int idnv)
        {
            return _db.KhenthuongKiluats.Any(kt => kt.Idnv == idnv);
        }

        public bool KiemTraNhanVienCoBaoHiem(int idnv)
        {
            return _db.Baohiems.Any(bh => bh.Idnv == idnv);
        }

        public bool KiemTraNhanVienBangChamCong(int idnv)
        {
            return _db.Chamcongs.Any(cc => cc.Idnv == idnv);
        }
        public List<Phongban> GetPhongBAN()
        {
            return _db.Phongbans.ToList();
        }

        public List<Congviec> GetCongViec()
        {
            return _db.Congviecs.ToList();
        }

        public List<Trinhdo> GetTrinhDo()
        {
            return _db.Trinhdos.ToList();
        }

        public List<Taikhoan> GetTaiKhoan()
        {
            return _db.Taikhoans.ToList();
        }

        public void ThemNhanVien(Nhanvien nv)
        {
            try
            {
                _db.Nhanviens.Add(nv);
                _db.SaveChanges();
                MessageBox.Show("Thêm nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi thêm nhân viên: " + ex.Message);
            }
        }

        public void SuaNhanVien(Nhanvien NewNV)
        {
            try
            {
                var OldNV = _db.Nhanviens.FirstOrDefault(nv => nv.Idnv == NewNV.Idnv);
                if (OldNV != null)
                {
                    OldNV.TenNv = NewNV.TenNv == null ? OldNV.TenNv : NewNV.TenNv;
                    OldNV.GioiTinh = NewNV.GioiTinh == null ? OldNV.GioiTinh : NewNV.GioiTinh;
                    OldNV.NgaySinh = NewNV.NgaySinh == null ? OldNV.NgaySinh : NewNV.NgaySinh;
                    OldNV.Sdt = NewNV.Sdt == null ? OldNV.Sdt : NewNV.Sdt;
                    OldNV.Cccd = NewNV.Cccd == null ? OldNV.Cccd : NewNV.Cccd;
                    OldNV.DiaChi = NewNV.DiaChi == null ? OldNV.DiaChi : NewNV.DiaChi;
                    OldNV.HinhAnh = NewNV.HinhAnh == null ? OldNV.HinhAnh : NewNV.HinhAnh;
                    OldNV.SoTienPhuCap = NewNV.SoTienPhuCap == null ? OldNV.SoTienPhuCap : NewNV.SoTienPhuCap;
                    OldNV.TrangThai = NewNV.TrangThai == null ? OldNV.TrangThai : NewNV.TrangThai;
                    OldNV.IdphongBan = NewNV.IdphongBan == null ? OldNV.IdphongBan : NewNV.IdphongBan;
                    OldNV.IdcongViec = NewNV.IdcongViec == null ? OldNV.IdcongViec : NewNV.IdcongViec;
                    OldNV.IdtrinhDo = NewNV.IdtrinhDo == null ? OldNV.IdtrinhDo : NewNV.IdtrinhDo;
                    OldNV.IdtaiKhoan = NewNV.IdtaiKhoan == null ? OldNV.IdtaiKhoan : NewNV.IdtaiKhoan;

                    _db.Nhanviens.Update(OldNV);
                    _db.SaveChanges();
                    MessageBox.Show("Sửa nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Nhân viên không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi sửa nhân viên: " + ex.Message);
            }
        }

        public void XoaNhanVien(int idnv)
        {
            try
            {
                var nv = _db.Nhanviens.FirstOrDefault(nv => nv.Idnv == idnv);
                if (nv != null)
                {
                    _db.Nhanviens.Remove(nv);
                    _db.SaveChanges();
                    MessageBox.Show("Xóa nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Nhân viên không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi xóa nhân viên: " + ex.Message);
            }
        }

        public List<DTO_QLNhanVien> TimKiemNV(string tuKhoa)
        {
            return _db.Nhanviens
        .Include(nv => nv.IdphongBanNavigation)
        .Include(nv => nv.IdcongViecNavigation)
        .Include(nv => nv.IdtrinhDoNavigation)
        .Include(nv => nv.IdtaiKhoanNavigation)
        .Where(x => x.Idnv.ToString().Equals(tuKhoa) || x.TenNv.Contains(tuKhoa)
            || x.DiaChi.Contains(tuKhoa)
            || x.IdphongBanNavigation.TenPhongBan.Contains(tuKhoa)
            || x.IdcongViecNavigation.TenCongViec.Contains(tuKhoa)
            || x.IdtrinhDoNavigation.TenTrinhDo.Contains(tuKhoa)
            || x.IdtaiKhoanNavigation.TenTaiKhoan.Contains(tuKhoa))
        .ToList()
        .Select((x, index) => new DTO_QLNhanVien
        {
            STT = index + 1,
            Idnv = x.Idnv,
            TenNv = x.TenNv,
            GioiTinh = x.GioiTinh,
            NgaySinh = x.NgaySinh,
            Sdt = x.Sdt,
            Cccd = x.Cccd,
            DiaChi = x.DiaChi,
            SoTienPhuCap = x.SoTienPhuCap,
            TrangThai = x.TrangThai,
            TenTaiKhoan = x.IdtaiKhoanNavigation.TenTaiKhoan,
            TenPhongBan = x.IdphongBanNavigation?.TenPhongBan,
            TenCongViec = x.IdcongViecNavigation?.TenCongViec,
            MoTaCV = x.IdcongViecNavigation?.MoTa,
            TenTrinhDo = x.IdtrinhDoNavigation?.TenTrinhDo
        }).ToList();
        }
    }
}
