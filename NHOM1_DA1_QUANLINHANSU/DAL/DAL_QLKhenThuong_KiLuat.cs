using NHOM1_DA1_QUANLINHANSU.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHOM1_DA1_QUANLINHANSU.DAL
{
    public class DAL_QLKhenThuong_KiLuat
    {
        private readonly Nhom1Da1QlnsContext _context;

        public DAL_QLKhenThuong_KiLuat()
        {
            _context = new Nhom1Da1QlnsContext();
        }

        public List<KhenthuongKiluat> GetAll()
        {
            return _context.KhenthuongKiluats.ToList();
        }

        public void Add(KhenthuongKiluat ktkl)
        {
            _context.KhenthuongKiluats.Add(ktkl);
            _context.SaveChanges();
        }

        public void Update(KhenthuongKiluat ktkl)
        {
            var existing = _context.KhenthuongKiluats.FirstOrDefault(x => x.IdktKl == ktkl.IdktKl);
            if (existing != null)
            {
                // Gán từng thuộc tính cần cập nhật
                existing.SoKtKl = ktkl.SoKtKl;
                existing.Loai = ktkl.Loai;
                existing.NoiDung = ktkl.NoiDung;
                existing.NgayRaQuyetDinh = ktkl.NgayRaQuyetDinh;
                existing.Idnv = ktkl.Idnv;

                _context.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            var ktkl = _context.KhenthuongKiluats.Find(id);
            if (ktkl != null)
            {
                _context.KhenthuongKiluats.Remove(ktkl);
                _context.SaveChanges();
            }
        }

        public List<KhenthuongKiluat> Search(string keyword)
        {
            return _context.KhenthuongKiluats
                .Where(x => x.Loai.Contains(keyword) || x.NoiDung.Contains(keyword))
                .ToList();
        }

        public KhenthuongKiluat? GetById(int id)
        {
            return _context.KhenthuongKiluats.FirstOrDefault(x => x.IdktKl == id);
        }

    }
}
