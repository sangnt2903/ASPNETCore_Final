using System;
using System.Collections.Generic;

namespace ASPCore_Final.Models
{
    public partial class HoaDonThanhToan
    {
        public int MaHtttHd { get; set; }
        public int? MaHd { get; set; }
        public string MaHttt { get; set; }
        public string NoiDungTt { get; set; }
        public bool? TrangThaiTt { get; set; }

        public HoaDon MaHdNavigation { get; set; }
        public HinhThucTt MaHtttNavigation { get; set; }
    }
}
