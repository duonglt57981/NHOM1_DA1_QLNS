using NHOM1_DA1_QUANLINHANSU.DAL;

namespace NHOM1_DA1_QUANLINHANSU.BLL
{
    public class BLL_ChangePassword
    {
        private readonly DAL_DoiMatKhau _dal = new DAL_DoiMatKhau();

        public bool ChangePassword(string username, string oldPassword, string newPassword, out string reason)
        {
            return _dal.ChangePassword(username, oldPassword, newPassword, out reason);
        }
    }
}
