using System;
using System.Collections.Generic;

namespace ASPCore_Final.Models
{
    public partial class HangHoa
    {
        public int MaHh { get; set; }
        public string TenHh { get; set; }
        public string MaLoai { get; set; }
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
