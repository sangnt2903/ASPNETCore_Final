using System;
using System.Collections.Generic;

namespace ASPCore_Final.Models
{
    public partial class TinTuc
    {
        public int MaTt { get; set; }
        public string NoiDung { get; set; }
        public DateTime? NgayTao { get; set; }
        public int? MaNv { get; set; }
        public string LoaiTt { get; set; }
        public bool? TrangThai { get; set; }

        public LoaiTinTuc LoaiTtNavigation { get; set; }
        public NhanVien MaNvNavigation { get; set; }
    }
}
