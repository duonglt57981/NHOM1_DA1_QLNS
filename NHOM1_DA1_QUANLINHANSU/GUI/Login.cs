// GUI/Login.cs
using NHOM1_DA1_QUANLINHANSU.BLL;
using NHOM1_DA1_QUANLINHANSU.DTO;
using System;
using System.Windows.Forms;

namespace NHOM1_DA1_QUANLINHANSU.GUI
{
    public partial class Login : Form
    {
        private readonly BLL_Login _bllLogin = new BLL_Login();

        public Login()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            var dto = new DTOLogin
            {
                TenTaiKhoan = tbTaiKhoan.Text.Trim(),
                MatKhau = tbMatKhau.Text
            };

            var taiKhoan = _bllLogin.Authenticate(dto, out string? reason);
            if (taiKhoan != null)
            {
                // Lưu thông tin người dùng
                Session.CurrentUser = taiKhoan;

                MessageBox.Show($"Đăng nhập thành công với vai trò: {taiKhoan.IdvaiTroNavigation.TenVaiTro}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                var trangChu = new TrangChu();
                this.Hide();
                trangChu.FormClosed += (s, args) => this.Close();
                trangChu.Show();
            }
            else
            {
                MessageBox.Show(
                    !string.IsNullOrEmpty(reason) ? $"Đăng nhập thất bại: {reason}" : "Tên tài khoản hoặc mật khẩu không đúng.",
                    "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DoiMatKhau doiMatKhauForm = new DoiMatKhau();
            this.Hide();
            doiMatKhauForm.FormClosed += (s, args) => this.Close();
            doiMatKhauForm.ShowDialog();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            bool show = checkBox1.Checked;
            tbMatKhau.UseSystemPasswordChar = !show;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
