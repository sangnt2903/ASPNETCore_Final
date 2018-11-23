using System;
using System.Collections.Generic;

namespace ASPNETCore_Final.Models
{
    public partial class HangHoa
    {
        public int MaHh { get; set; }
        public string TenHh { get; set; }
        public int MaLoai { get; set; }
        public string Hinh { get; set; }
        public double DonGia { get; set; }
        public double GiamGia { get; set; }
        public string MoTa { get; set; }
        public string MaNcc { get; set; }
        public int SoLuongHang { get; set; }

        public Loai MaLoaiNavigation { get; set; }
        public NhaCungCap MaNccNavigation { get; set; }
    }
}
