﻿using System;
using System.Collections.Generic;

namespace ASPNETCore_Final.Models
{
    public partial class Loai
    {
        public Loai()
        {
            HangHoa = new HashSet<HangHoa>();
        }

        public int MaLoai { get; set; }
        public string TenLoai { get; set; }

        public ICollection<HangHoa> HangHoa { get; set; }
    }
}
