using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace NHOM1_DA1_QUANLINHANSU.Models;

public partial class KhenthuongKiluat
{
    [DisplayName("ID KT Kỷ luật")]
    public int IdktKl { get; set; }
    [DisplayName("Số khen thưởng kỷ luật")]
    public int SoKtKl { get; set; }
    [DisplayName("Loại")]
    public string Loai { get; set; } = null!;
    [DisplayName("Nội dung")]
    public string? NoiDung { get; set; }
    [DisplayName("Ngày ra quyết định")]
    public DateOnly NgayRaQuyetDinh { get; set; }
    [DisplayName("ID Nhân viên")]
    public int Idnv { get; set; }

    public virtual Nhanvien IdnvNavigation { get; set; } = null!;
}
