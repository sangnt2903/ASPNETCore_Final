using System;
using System.Collections.Generic;

namespace ASPCore_Final.Models
{
    public partial class HinhThucTt
    {
        public HinhThucTt()
        {
            HoaDonThanhToan = new HashSet<HoaDonThanhToan>();
        }

        public string MaLoaiTt { get; set; }
        public string TenLoaiTt { get; set; }
        public bool? TrangThai { get; set; }

        public ICollection<HoaDonThanhToan> HoaDonThanhToan { get; set; }
    }
}
