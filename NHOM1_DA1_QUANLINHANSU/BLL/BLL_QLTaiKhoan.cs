using System.Collections.Generic;
using NHOM1_DA1_QUANLINHANSU.DAL;
using NHOM1_DA1_QUANLINHANSU.DTO;
using NHOM1_DA1_QUANLINHANSU.Models;

namespace NHOM1_DA1_QUANLINHANSU.BLL
{
    public class BLL_QLTaiKhoan
    {
        private readonly DAL_QLTaiKhoan _dal = new DAL_QLTaiKhoan();

        public List<DTO_QLTaiKhoan> GetAll()
        {
            return _dal.GetAllTaiKhoan();
        }

        public List<Vaitro> GetVaiTro()
        {
            return _dal.GetVaiTro();
        }

        public void Them(Taikhoan tk)
        {
            _dal.ThemTaiKhoan(tk);
        }

        public void Sua(Taikhoan tk)
        {
            _dal.SuaTaiKhoan(tk);
        }

        public void Xoa(int id)
        {
            _dal.XoaTaiKhoan(id);
        }

        public List<DTO_QLTaiKhoan> TimKiem(string tuKhoa)
        {
            return _dal.TimKiem(tuKhoa);
        }
    }
}
