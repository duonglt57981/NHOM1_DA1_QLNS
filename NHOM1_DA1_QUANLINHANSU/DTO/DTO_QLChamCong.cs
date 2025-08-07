using System;

namespace NHOM1_DA1_QUANLINHANSU.Models
{
    public class ChamCong
    {
        public int Id { get; set; }              // Mã chấm công (tự tăng)
        public string MaNv { get; set; }         // Mã nhân viên
        public DateTime Ngay { get; set; }       // Ngày chấm công
        public TimeSpan? GioVao { get; set; }    // Giờ vào (có thể null)
        public TimeSpan? GioRa { get; set; }     // Giờ ra (có thể null)
        public string GhiChu { get; set; }       // Ghi chú (nếu có)

        // Có thể thêm constructor nếu cần khởi tạo nhanh
        public ChamCong() { }

        public ChamCong(string maNv, DateTime ngay, TimeSpan? gioVao, TimeSpan? gioRa, string ghiChu = "")
        {
            MaNv = maNv;
            Ngay = ngay;
            GioVao = gioVao;
            GioRa = gioRa;
            GhiChu = ghiChu;
        }
    }
}
