using NHOM1_DA1_QUANLINHANSU.Models;
using NHOM1_DA1_QUANLINHANSU.DTO;
using Microsoft.EntityFrameworkCore;

namespace NHOM1_DA1_QUANLINHANSU.DAL
{
    internal class DAL_QLChamCong
    {
       private Nhom1Da1QlnsContext _db = new Nhom1Da1QlnsContext();

        public List<DTO_QLChamCong> GetAllChamCong()
        {
           return _db.Chamcongs.Include(nv => nv.IdnvNavigation)
                .Include(lc => lc.IdloaiCongNavigation).ToList()
                .Select((x, index) => new DTO_QLChamCong
                {
                    STT = index + 1,
                    IdchamCong = x.IdchamCong,
                    Nam = x.Nam,
                    Thang = x.Thang,
                    Ngay = x.Ngay,
                    GioVao = x.GioVao,
                    PhutVao = x.PhutVao,
                    GioRa = x.GioRa,
                    PhutRa = x.PhutRa,
                    CaLam = x.CaLam,
                    TenLoaiCong = x.IdloaiCongNavigation.TenLoaiCong,
                    Idnv = x.Idnv,
                    TenNv = x.IdnvNavigation.TenNv,
                    GioiTinh = x.IdnvNavigation.GioiTinh,
                    NgaySinh = x.IdnvNavigation.NgaySinh,
                    Sdt = x.IdnvNavigation.Sdt,
                    Cccd = x.IdnvNavigation.Cccd,
                    DiaChi = x.IdnvNavigation.DiaChi
                }).ToList();
        }
    }
}
