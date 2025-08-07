using System.Linq;
using NHOM1_DA1_QUANLINHANSU.Models;

namespace NHOM1_DA1_QUANLINHANSU.DAL
{
    internal class DAL_DoiMatKhau
    {
        private readonly Nhom1Da1QlnsContext _db = new Nhom1Da1QlnsContext();

        public bool ChangePassword(string username, string oldPassword, string newPassword, out string reason)
        {
            reason = "";

            var tk = _db.Taikhoans.FirstOrDefault(t => t.TenTaiKhoan == username);
            if (tk == null)
            {
                reason = "Tài khoản không tồn tại.";
                return false;
            }

            if (tk.MatKhau != oldPassword)
            {
                reason = "Mật khẩu cũ không đúng.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(newPassword))
            {
                reason = "Mật khẩu mới không được để trống.";
                return false;
            }

            if (newPassword == oldPassword)
            {
                reason = "Mật khẩu mới phải khác mật khẩu cũ.";
                return false;
            }

            tk.MatKhau = newPassword;
            _db.SaveChanges();
            return true;
        }
    }
}
