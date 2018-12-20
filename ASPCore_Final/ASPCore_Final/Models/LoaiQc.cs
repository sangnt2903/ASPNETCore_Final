using System;
using System.Collections.Generic;

namespace ASPCore_Final.Models
{
    public partial class LoaiQc
    {
        public LoaiQc()
        {
            BannerQc = new HashSet<BannerQc>();
        }

        public string LoaiQc1 { get; set; }
        public string TenQc { get; set; }

        public ICollection<BannerQc> BannerQc { get; set; }
    }
}
