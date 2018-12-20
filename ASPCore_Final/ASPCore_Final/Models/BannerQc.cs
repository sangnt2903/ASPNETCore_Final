using System;
using System.Collections.Generic;

namespace ASPCore_Final.Models
{
    public partial class BannerQc
    {
        public int MaQc { get; set; }
        public string NoiDungQc { get; set; }
        public DateTime? NgayTao { get; set; }
        public string Hinh { get; set; }
        public DateTime? NgayBatDau { get; set; }
        public DateTime? NgayKetThucQc { get; set; }
    }
}
