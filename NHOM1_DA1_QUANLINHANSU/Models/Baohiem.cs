using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace NHOM1_DA1_QUANLINHANSU.Models;

public partial class Baohiem
{
    [DisplayName("ID bảo hiểm")]
    public int IdbaoHiem { get; set; }
    [DisplayName("Loại bảo hiểm")]
    public string LoaiBaoHiem { get; set; } = null!;
    [DisplayName("Số bảo hiểm")]
    public int SoBaoHiem { get; set; }
    [DisplayName("Ngày cấp")]
    public DateOnly NgayCap { get; set; }
    [DisplayName("Nơi cấp")]
    public string NoiCap { get; set; } = null!;
    [DisplayName("Nơi đăng kí")]
    public string NoiDangKi { get; set; } = null!;
    [DisplayName("Ngày bắt đầu")]
    public DateOnly NgayBatDau { get; set; }
    [DisplayName("Ngày hết hạn")]
    public DateOnly NgayHetHan { get; set; }
    [DisplayName("Trạng thái")]
    public string? TrangThai { get; set; }
    [DisplayName("IDNV")]
    public int Idnv { get; set; }
    [BrowsableAttribute(false)]
    public virtual Nhanvien IdnvNavigation { get; set; } = null!;
}
