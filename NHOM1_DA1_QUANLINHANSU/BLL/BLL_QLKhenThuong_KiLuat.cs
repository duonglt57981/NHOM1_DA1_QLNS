using NHOM1_DA1_QUANLINHANSU.DAL;
using NHOM1_DA1_QUANLINHANSU.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHOM1_DA1_QUANLINHANSU.BLL
{
    public class BLL_QLKhenThuong_KiLuat
    {
        private readonly DAL_QLKhenThuong_KiLuat _dal;

        public BLL_QLKhenThuong_KiLuat()
        {
            _dal = new DAL_QLKhenThuong_KiLuat();
        }

        public List<KhenthuongKiluat> GetAll()
        {
            return _dal.GetAll();
        }

        public void Add(KhenthuongKiluat dto)
        {
            var entity = new KhenthuongKiluat
            {
                SoKtKl = dto.SoKtKl,
                Loai = dto.Loai,
                NoiDung = dto.NoiDung,
                NgayRaQuyetDinh = dto.NgayRaQuyetDinh,
                Idnv = dto.Idnv

            };
            _dal.Add(entity);
        }

        public void Update(KhenthuongKiluat dto)
        {
            var entity = new KhenthuongKiluat
            {
                IdktKl = dto.IdktKl,
                SoKtKl = dto.SoKtKl,
                Loai = dto.Loai,
                NoiDung = dto.NoiDung,
                NgayRaQuyetDinh = dto.NgayRaQuyetDinh,
                Idnv = dto.Idnv
            };
            _dal.Update(entity);
        }

        public void Delete(int id) => _dal.Delete(id);

        public List<KhenthuongKiluat> Search(string keyword) => _dal.Search(keyword);

        public KhenthuongKiluat? GetById(int id) => _dal.GetById(id);
    }
}
