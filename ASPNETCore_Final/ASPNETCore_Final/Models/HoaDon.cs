using System;
using System.Collections.Generic;

namespace ASPNETCore_Final.Models
{
    public partial class HoaDon
    {
        public int MaHd { get; set; }
        public string MaKh { get; set; }
        public DateTime NgayDat { get; set; }
        public DateTime? NgayGiao { get; set; }
        public string HoTen { get; set; }
        public string DiaChi { get; set; }
        public string CachThanhToan { get; set; }
        public string CachVanChuyen { get; set; }
        public double PhiVanChuyen { get; set; }
        public int MaTrangThai { get; set; }
        public string MaNv { get; set; }
        public string GhiChu { get; set; }

        public TrangThai MaTrangThaiNavigation { get; set; }
    }
}
