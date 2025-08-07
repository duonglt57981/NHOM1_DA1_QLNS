using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using NHOM1_DA1_QUANLINHANSU.DTO;
using NHOM1_DA1_QUANLINHANSU.Models;
using System.Windows.Forms;

namespace NHOM1_DA1_QUANLINHANSU.DAL
{
    internal class DAL_QLTaiKhoan
    {
        private Nhom1Da1QlnsContext _db = new Nhom1Da1QlnsContext();

        public List<DTO_QLTaiKhoan> GetAllTaiKhoan()
        {
            return _db.Taikhoans
                .Include(t => t.IdvaiTroNavigation)
                .ToList()
                .Select((x, index) => new DTO_QLTaiKhoan
                {
                    STT = index + 1,
                    IdtaiKhoan = x.IdtaiKhoan,
                    TenHienThi = x.TenHienThi,
                    TenTaiKhoan = x.TenTaiKhoan,
                    MatKhau = x.MatKhau,
                    TrangThai = x.TrangThai,
                    TenVaiTro = x.IdvaiTroNavigation?.TenVaiTro
                }).ToList();
        }

        public List<Vaitro> GetVaiTro()
        {
            return _db.Vaitros.ToList();
        }

        public void ThemTaiKhoan(Taikhoan tk)
        {
            try
            {
                _db.Taikhoans.Add(tk);
                _db.SaveChanges();
                MessageBox.Show("Thêm tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi thêm tài khoản: " + ex.Message);
            }
        }

        public void SuaTaiKhoan(Taikhoan newTk)
        {
            try
            {
                var old = _db.Taikhoans.FirstOrDefault(t => t.IdtaiKhoan == newTk.IdtaiKhoan);
                if (old != null)
                {
                    old.TenHienThi = string.IsNullOrEmpty(newTk.TenHienThi) ? old.TenHienThi : newTk.TenHienThi;
                    old.TenTaiKhoan = string.IsNullOrEmpty(newTk.TenTaiKhoan) ? old.TenTaiKhoan : newTk.TenTaiKhoan;
                    old.MatKhau = string.IsNullOrEmpty(newTk.MatKhau) ? old.MatKhau : newTk.MatKhau;
                    old.TrangThai = string.IsNullOrEmpty(newTk.TrangThai) ? old.TrangThai : newTk.TrangThai;
                    old.IdvaiTro = newTk.IdvaiTro != 0 ? newTk.IdvaiTro : old.IdvaiTro;

                    _db.SaveChanges();
                    MessageBox.Show("Sửa tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Tài khoản không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi sửa tài khoản: " + ex.Message);
            }
        }

        public void XoaTaiKhoan(int id)
        {
            try
            {
                var tk = _db.Taikhoans.FirstOrDefault(t => t.IdtaiKhoan == id);
                if (tk != null)
                {
                    _db.Taikhoans.Remove(tk);
                    _db.SaveChanges();
                    MessageBox.Show("Xóa tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Tài khoản không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi xóa tài khoản: " + ex.Message);
            }
        }

        public List<DTO_QLTaiKhoan> TimKiem(string tuKhoa)
        {
            tuKhoa = tuKhoa?.Trim() ?? "";
            return _db.Taikhoans
                .Include(t => t.IdvaiTroNavigation)
                .Where(x => x.IdtaiKhoan.ToString().Equals(tuKhoa)
                         || x.TenHienThi.Contains(tuKhoa)
                         || x.TenTaiKhoan.Contains(tuKhoa)
                         || x.TrangThai.Contains(tuKhoa)
                         || x.IdvaiTroNavigation.TenVaiTro.Contains(tuKhoa))
                .ToList()
                .Select((x, index) => new DTO_QLTaiKhoan
                {
                    STT = index + 1,
                    IdtaiKhoan = x.IdtaiKhoan,
                    TenHienThi = x.TenHienThi,
                    TenTaiKhoan = x.TenTaiKhoan,
                    MatKhau = x.MatKhau,
                    TrangThai = x.TrangThai,
                    TenVaiTro = x.IdvaiTroNavigation?.TenVaiTro
                }).ToList();
        }
    }
}
