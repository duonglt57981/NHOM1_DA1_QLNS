using NHOM1_DA1_QUANLINHANSU.Models;

namespace NHOM1_DA1_QUANLINHANSU.DAL
{
    internal class DAL_QLChamCong
    {
        private Nhom1Da1QlnsContext _context;

        public DAL_QLChamCong()
        {
            _context = new Nhom1Da1QlnsContext();
        }



        // Lấy toàn bộ danh sách chấm công
        public List<Chamcong> GetAll()
        {
            return _context.Chamcongs.ToList();
        }

        public List<Nhanvien> GetNhanVien()
        {
            return _context.Nhanviens.ToList();
        }

        // Thêm mới bản ghi chấm công
        public bool Insert(Chamcong cc)
        {
            try
            {
                _context.Chamcongs.Add(cc);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        // Kiểm tra xem nhân viên đã chấm công ngày hôm nay chưa
        public bool CheckExistToday(int idNV, DateTime ngay)
        {
            return _context.Chamcongs.Any(cc =>
                cc.Idnv == idNV &&
                cc.Ngay == ngay.Day &&
                cc.Thang == ngay.Month &&
                cc.Nam == ngay.Year);
        }

        // Xóa chấm công theo ID
        public bool Delete(int idChamCong)
        {
            try
            {
                var cc = _context.Chamcongs.FirstOrDefault(x => x.IdchamCong == idChamCong);
                if (cc != null)
                {
                    _context.Chamcongs.Remove(cc);
                    _context.SaveChanges();
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        // Cập nhật bản ghi chấm công
        public bool Update(Chamcong cc)
        {
            try
            {
                var existing = _context.Chamcongs.FirstOrDefault(x => x.IdchamCong == cc.IdchamCong);
                if (existing != null)
                {
                    existing.Idnv = cc.Idnv;
                    existing.Ngay = cc.Ngay;
                    existing.Thang = cc.Thang;
                    existing.Nam = cc.Nam;
                    _context.SaveChanges();
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        // Lấy bản ghi chấm công theo ID
        public Chamcong GetById(int id)
        {
            return _context.Chamcongs.FirstOrDefault(x => x.IdchamCong == id);
        }
    }
}
