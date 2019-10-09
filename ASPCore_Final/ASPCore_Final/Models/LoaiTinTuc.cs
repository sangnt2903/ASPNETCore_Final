using System;
using System.Collections.Generic;

namespace ASPCore_Final.Models
{
    public partial class LoaiTinTuc
    {
        public LoaiTinTuc()
        {
            TinTuc = new HashSet<TinTuc>();
        }

        public string LoaiTt { get; set; }
        public string TenTt { get; set; }

        public ICollection<TinTuc> TinTuc { get; set; }
    }
}
