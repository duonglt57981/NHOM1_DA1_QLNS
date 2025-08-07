// BLL/BLL_Login.cs
using NHOM1_DA1_QUANLINHANSU.DTO;
using NHOM1_DA1_QUANLINHANSU.DAL;
using NHOM1_DA1_QUANLINHANSU.Models;

namespace NHOM1_DA1_QUANLINHANSU.BLL
{
    public class BLL_Login
    {
        private readonly DAL_Login _dalLogin = new DAL_Login();

        public Taikhoan? Authenticate(DTOLogin dto, out string? reason)
        {
            return _dalLogin.Authenticate(dto, out reason);
        }
    }
}
