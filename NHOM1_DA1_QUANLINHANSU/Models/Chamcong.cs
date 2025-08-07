using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace NHOM1_DA1_QUANLINHANSU.Models;

public partial class Chamcong
{
    [DisplayName("ID chấm công")]
    public int IdchamCong { get; set; }
    [DisplayName("Năm")]
    public int Nam { get; set; }
    [DisplayName("Tháng")]
    public int Thang { get; set; }
    [DisplayName("Ngày")]
    public int Ngay { get; set; }
    [DisplayName("Giờ vào")]
    public int GioVao { get; set; }
    [DisplayName("Phút vào")]
    public int PhutVao { get; set; }
    [DisplayName("Giờ ra")]
    public int GioRa { get; set; }
    [DisplayName("Phút ra")]
    public int PhutRa { get; set; }
    [DisplayName("Ca làm")]
    public string CaLam { get; set; } = null!;
    [DisplayName("ID nhân viên")]
    public int Idnv { get; set; }

    [DisplayName("ID loại công")]
    public int IdloaiCong { get; set; }

    [Browsable(false)]
    public virtual Loaicong IdloaiCongNavigation { get; set; } = null!;

    [Browsable(false)]
    public virtual Nhanvien IdnvNavigation { get; set; } = null!;
    

}
