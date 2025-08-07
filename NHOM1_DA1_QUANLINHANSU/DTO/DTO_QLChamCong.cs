using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHOM1_DA1_QUANLINHANSU.DTO
{
    internal class DTO_QLChamCong
    {
        public int STT { get; set; }

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

        [DisplayName("Tên loại công")]
        public string TenLoaiCong { get; set; } = null!;

        [DisplayName("ID nhân viên")]
        public int Idnv { get; set; }

        [DisplayName("Tên nhân viên")]
        public string TenNv { get; set; } = null!;

        [DisplayName("giới tính")]
        public string GioiTinh { get; set; } = null!;

        [DisplayName("Ngày sinh")]
        public DateOnly NgaySinh { get; set; }

        [DisplayName("Số điện thoại")]
        public string Sdt { get; set; } = null!;

        [DisplayName("CCCD")]
        public string Cccd { get; set; } = null!;

        [DisplayName("Địa chỉ")]
        public string DiaChi { get; set; } = null!;

        public byte[] HinhAnh { get; set; } = null!;
    }
}
