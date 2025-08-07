using NHOM1_DA1_QUANLINHANSU.DAL;
using NHOM1_DA1_QUANLINHANSU.Models;
using System;
using System.Collections.Generic;

namespace NHOM1_DA1_QUANLINHANSU.BLL
{
    internal class BLL_QLChamCong
    {
        private readonly DAL_QLChamCong _dal = new DAL_QLChamCong();
        private readonly DAL_LoaiCong _loaiCongDAL = new DAL_LoaiCong();

        public List<Chamcong> GetAll() => _dal.GetAll();

        public List<Nhanvien> GetNhanVien()
        {
            return _dal.GetNhanVien();
        }

        public List<Loaicong> GetAllLoaiCong() => _loaiCongDAL.GetAll();

        public bool AddChamCong(Chamcong cc)
        {
            if (!_dal.CheckExistToday(cc.Idnv, new DateTime(cc.Nam, cc.Thang, cc.Ngay)))
            {
                return _dal.Insert(cc);
            }
            return false;
        }

        public bool UpdateChamCong(Chamcong cc) => _dal.Update(cc);

        public bool DeleteChamCong(int id) => _dal.Delete(id);

        public Chamcong GetById(int id) => _dal.GetById(id);

        public bool CheckExistToday(int idNV, DateTime ngay) => _dal.CheckExistToday(idNV, ngay);

        internal static object? GetAllChamCong()
        {
            throw new NotImplementedException();
        }
        public List<Chamcong> SearchChamCong(int keyword)
        {
            using (var context = new Nhom1Da1QlnsContext())
            {
                return context.Chamcongs
                             .Where(c => c.Idnv == keyword).ToList();
            }
        }

    }
}
