// DAL/DAL_Login.cs
using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using NHOM1_DA1_QUANLINHANSU.DTO;
using NHOM1_DA1_QUANLINHANSU.Models;

namespace NHOM1_DA1_QUANLINHANSU.DAL
{
    internal class DAL_Login
    {
        private readonly Nhom1Da1QlnsContext _db;

        public DAL_Login()
        {
            var optionsBuilder = new DbContextOptionsBuilder<Nhom1Da1QlnsContext>();
            optionsBuilder.UseSqlServer("Server=CHUNG\\MSSQLSERVER02;Database=NHOM1_DA1_QLNS;Trusted_Connection=True;TrustServerCertificate=True;");
            _db = new Nhom1Da1QlnsContext(optionsBuilder.Options);
        }

        public Taikhoan? Authenticate(DTOLogin dto, out string? reason)
        {
            reason = null;

            if (string.IsNullOrWhiteSpace(dto.TenTaiKhoan))
            {
                reason = "Tên tài khoản trống.";
                return null;
            }

            if (string.IsNullOrWhiteSpace(dto.MatKhau))
            {
                reason = "Mật khẩu trống.";
                return null;
            }

            string userInput = dto.TenTaiKhoan.Trim();
            string passInput = dto.MatKhau; // mật khẩu có thể giữ nguyên, có thể trim nếu muốn

            // Lấy tài khoản: giả định collation là case-insensitive, nên so sánh trực tiếp
            var taiKhoan = _db.Taikhoans
                .AsNoTracking()
                .Include(t => t.IdvaiTroNavigation)
                .FirstOrDefault(t => t.TenTaiKhoan == userInput);

            if (taiKhoan == null)
            {
                reason = "Không tìm thấy tài khoản.";
                return null;
            }

            // Kiểm tra trạng thái (theo DB là "Hoạt Động")
            if (!string.Equals(taiKhoan.TrangThai?.Trim(), "Hoạt Động", StringComparison.OrdinalIgnoreCase))
            {
                reason = $"Tài khoản không được phép đăng nhập (TrangThai = '{taiKhoan.TrangThai}').";
                return null;
            }

            if (taiKhoan.MatKhau != passInput)
            {
                reason = "Mật khẩu không đúng.";
                return null;
            }

            return taiKhoan;
        }
    }
}
