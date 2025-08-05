using NHOM1_DA1_QUANLINHANSU.GUI.UC;
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
    public partial class TrangChu : Form
    {
        public TrangChu()
        {
            InitializeComponent();
        }


        private void LoadUC(UserControl uc)
        {

            panel_TrangChu.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            panel_TrangChu.Controls.Add(uc);
        }


        private void TrangChu_Load(object sender, EventArgs e)
        {
            UC_TrangChu defaultUC = new UC_TrangChu();
            if (!panel_TrangChu.Controls.Contains(defaultUC))
            {
                panel_TrangChu.Controls.Add(defaultUC);
                defaultUC.Dock = DockStyle.Fill;
                defaultUC.BringToFront();
            }
            else
            {
                panel_TrangChu.Controls[0].BringToFront();
            }
        }


        private void button_QLNhanVien_Click(object sender, EventArgs e)
        {
            LoadUC(new UC.UC_QLNhanVien());
        }


        private void button_QLHopDong_Click(object sender, EventArgs e)
        {
            LoadUC(new UC.UC_QLHopDong());
        }


        private void button_QLChamCong_Click(object sender, EventArgs e)
        {
            LoadUC(new UC.UC_QLChamCong());
        }


        private void button_QLBaoHiem_Click(object sender, EventArgs e)
        {
            LoadUC(new UC.UC_QLBaoHiem());
        }


        private void button_QLKT_KL_Click(object sender, EventArgs e)
        {
            LoadUC(new UC.UC_QLKhenThuong_KiLuat());
        }


        private void button_QLTaiKhoan_Click(object sender, EventArgs e)
        {
            LoadUC(new UC.UC_QLTaiKhoan());
        }


        private void button_DangXuat_Click(object sender, EventArgs e)
        {

        }
    }
}
