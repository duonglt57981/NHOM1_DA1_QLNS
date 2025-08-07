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
    internal class BLL_QLHopDong
    {
        private DAL_QLHopDong QLHD_DAL = new DAL_QLHopDong();

        public List<DTO.DTO_QLHopDong> GetAllHopDong()
        {
            return QLHD_DAL.GetAllHopDong();
        }
        public List<Loaihopdong> GetAllLoaiHopDong()
        {
            return QLHD_DAL.GetAllLoaiHopDong();
        }

        public List<Nhanvien> GetAllNhanVien()
        {
            return QLHD_DAL.GetAllNhanVien()
                .Where(nv => nv.TrangThai == "Hoạt Động").ToList(); ;
        }

        public void ThemHopDong(Hopdong hopdong)
        {
            if (QLHD_DAL.KiemTraIDNV(hopdong.Idnv))
            {
                DialogResult kq = MessageBox.Show("Nhân viên này  đã đăng kí hợp đồng, bạn có muốn thêm không!",
                    "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (kq == DialogResult.Yes)
                {
                    QLHD_DAL.ThemHopDong(hopdong);
                }
                else
                {
                    return;
                }
            }
            else
            {
                QLHD_DAL.ThemHopDong(hopdong);
            }
        }

        public void SuaHopDong(Hopdong newHD)
        {
            QLHD_DAL.SuaHopDong(newHD);
        }

        public void XoaHopDong(int soHopDong)
        {
            QLHD_DAL.XoaHopDong(soHopDong);
        }

        public List<DTO_QLHopDong> TimKiem(string tk)
        {
            return QLHD_DAL.TimKiem(tk);
        }

    }
}
