using NHOM1_DA1_QUANLINHANSU.Models;
using System.Collections.Generic;
using System.Linq;

namespace NHOM1_DA1_QUANLINHANSU.DAL
{
    internal class DAL_LoaiCong
    {
        private Nhom1Da1QlnsContext _context = new Nhom1Da1QlnsContext();

        public List<Loaicong> GetAll()
        {
            return _context.Loaicongs.ToList();
        }
    }
}
