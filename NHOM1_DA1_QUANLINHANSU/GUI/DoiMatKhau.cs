using Microsoft.VisualBasic.ApplicationServices;
using NHOM1_DA1_QUANLINHANSU.BLL;
using NHOM1_DA1_QUANLINHANSU.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NHOM1_DA1_QUANLINHANSU.GUI
{
    public partial class DoiMatKhau : Form
    {
        private readonly BLL_ChangePassword _bll = new BLL_ChangePassword();

        public DoiMatKhau()
        {
            InitializeComponent();
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            string username = tbTaiKhoan.Text.Trim();
            string oldPwd = tbMatKhau.Text;
            string newPwd = tbMKMoi.Text;
            string confirmPwd = tbNhapLaiMK.Text;

            if (newPwd != confirmPwd)
            {
                MessageBox.Show("Mật khẩu mới và nhập lại không khớp.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_bll.ChangePassword(username, oldPwd, newPwd, out string reason))
            {
                MessageBox.Show("Đổi mật khẩu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                var login = new Login();
                this.Hide();
                login.FormClosed += (s, args) => this.Close();
                login.Show();
            }
            else
            {
                MessageBox.Show(reason, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            bool show = checkBox1.Checked;
            tbMatKhau.UseSystemPasswordChar = !show;
            tbMKMoi.UseSystemPasswordChar = !show;
            tbNhapLaiMK.UseSystemPasswordChar = !show;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }

}
