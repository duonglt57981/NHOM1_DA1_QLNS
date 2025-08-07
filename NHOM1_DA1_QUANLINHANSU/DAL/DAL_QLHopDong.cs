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
    internal class DAL_QLHopDong
    {
        private Nhom1Da1QlnsContext _db = new Nhom1Da1QlnsContext();

        public List<DTO_QLHopDong> GetAllHopDong()
        {
            return _db.Hopdongs.Include(nv => nv.IdnvNavigation)
                .Include(nv => nv.IdloaiHdNavigation).ToList()
                .Select((x, index) => new DTO_QLHopDong
                {
                    STT = index + 1,
                    SoHopDong = x.SoHopDong,
                    LoainHopDong = x.IdloaiHdNavigation.TenHopDong,
                    NgayBd = x.NgayBd,
                    NgayKt = x.NgayKt,
                    NgayKiHopDong = x.NgayKiHopDong,
                    LanKi = x.LanKi,
                    NoiDung = x.NoiDung,
                    ThoiHan = x.ThoiHan,
                    HeSoLuong = x.HeSoLuong,
                    LuongCoBan = x.LuongCoBan,
                    TrangThai = x.TrangThai,
                    TenNv = x.IdnvNavigation.TenNv,
                    Sdt = x.IdnvNavigation.Sdt,
                    Cccd = x.IdnvNavigation.Cccd,
                    DiaChi = x.IdnvNavigation.DiaChi
                }).ToList();
        }

        public List<Loaihopdong> GetAllLoaiHopDong()
        {
            return _db.Loaihopdongs.ToList();
        }

        public List<Nhanvien> GetAllNhanVien()
        {
            return _db.Nhanviens.ToList()
                .Select(nv => new Nhanvien
                {
                    Idnv = nv.Idnv,
                    TenNv = nv.TenNv,
                    Sdt = nv.Sdt,
                    Cccd = nv.Cccd,
                    DiaChi = nv.DiaChi
                }).ToList();
        }

        public void ThemHopDong(Hopdong hopdong)
        {
            try
            {
                _db.Hopdongs.Add(hopdong);
                _db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi thêm hợp đồng: " + ex.Message);
            }
        }

        public void SuaHopDong(Hopdong newHD)
        {
            try
            {
                var oldNV = _db.Hopdongs.FirstOrDefault(hd => hd.SoHopDong == newHD.SoHopDong);
                if (oldNV != null)
                {
                    oldNV.NgayBd = newHD.NgayBd == null ? oldNV.NgayBd : newHD.NgayBd;
                    oldNV.NgayKt = newHD.NgayKt == null ? oldNV.NgayBd : newHD.NgayBd;
                    oldNV.NgayKiHopDong = newHD.NgayKiHopDong == null ? oldNV.NgayKiHopDong : newHD.NgayKiHopDong;
                    oldNV.LanKi = newHD.LanKi == null ? oldNV.LanKi : newHD.LanKi;
                    oldNV.NoiDung = newHD.NoiDung == null ? oldNV.NoiDung : newHD.NoiDung;
                    oldNV.ThoiHan = newHD.ThoiHan == null ? oldNV.ThoiHan : newHD.ThoiHan;
                    oldNV.HeSoLuong = newHD.HeSoLuong == null ? oldNV.HeSoLuong : newHD.HeSoLuong;
                    oldNV.LuongCoBan = newHD.LuongCoBan == null ? oldNV.LuongCoBan : newHD.LuongCoBan;
                    oldNV.TrangThai = newHD.TrangThai == null ? oldNV.TrangThai : newHD.TrangThai;
                    oldNV.Idnv = newHD.Idnv == null ? oldNV.Idnv : newHD.Idnv;
                    oldNV.IdloaiHd = newHD.IdloaiHd == null ? oldNV.IdloaiHd : newHD.IdloaiHd;
                    MessageBox.Show("Sửa hợp đồng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _db.SaveChanges();
                }
                else
                {
                    throw new Exception("Hợp đồng không tồn tại.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi sửa hợp đồng: " + ex.Message);
            }
        }

        public void XoaHopDong(int soHopDong)
        {
            try
            {
                var hopdong = _db.Hopdongs.FirstOrDefault(hd => hd.SoHopDong == soHopDong);
                if (hopdong != null)
                {
                    _db.Hopdongs.Remove(hopdong);
                    _db.SaveChanges();
                    MessageBox.Show("Xóa hợp đồng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    throw new Exception("Hợp đồng không tồn tại.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi xóa hợp đồng: " + ex.Message);
            }
        }

        
    }
}
