using System;
using System.Collections.Generic;

namespace ASPNETCore_Final.Models
{
    public partial class NhanVien
    {
        public string MaNv { get; set; }
        public string HoTen { get; set; }
        public string Email { get; set; }
        public string MatKhau { get; set; }
        public int MaPq { get; set; }
        public bool? TrangThaiHd { get; set; }

        public PhanQuyen MaPqNavigation { get; set; }
    }
}
