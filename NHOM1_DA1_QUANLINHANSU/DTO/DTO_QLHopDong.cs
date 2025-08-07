using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHOM1_DA1_QUANLINHANSU.DTO
{
    internal class DTO_QLHopDong
    {
        public int STT { get; set; }

        [DisplayName("Số hợp đồng")]
        public int SoHopDong { get; set; }

        [DisplayName("Loại hợp đồng")]
        public string LoainHopDong { get; set; } = null!;

        [DisplayName("Ngày bắt đầu")]
        public DateOnly NgayBd { get; set; }

        [DisplayName("Ngày kết thúc")]
        public DateOnly NgayKt { get; set; }

        [DisplayName("Ngày ký hợp đồng")]
        public DateOnly NgayKiHopDong { get; set; }


        [DisplayName("Lần ký")]
        public int LanKi { get; set; }

        [DisplayName("Nội dung")]
        public string? NoiDung { get; set; }

        [DisplayName("Thời hạn")]
        public string ThoiHan { get; set; } = null!;

        [DisplayName("Hệ số lương")]
        public double HeSoLuong { get; set; }

        [DisplayName("Lương cơ bản")]
        public double LuongCoBan { get; set; }

        [DisplayName("Trạng thái")]
        public string TrangThai { get; set; } = null!;

        [DisplayName("ID Nhân viên")]
        public int Idnv { get; set; }

        [DisplayName("Tên nhân viên")]
        public string TenNv { get; set; } = null!;

        [DisplayName("Số điện thoại")]
        public string Sdt { get; set; } = null!;

        [DisplayName("CCCD")]
        public string Cccd { get; set; } = null!;

        [DisplayName("Địa chỉ")]
        public string DiaChi { get; set; } = null!;
    }
}
