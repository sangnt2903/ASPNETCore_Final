﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPCore_Final.Models
{
    public class SendSMS
    {
        public string NumberFrom { get; set; }

        public string NumberTo { get; set; }

        public string Greeting { get; set; }

        public string NameTo { get; set; }

        public string Body { get; set; }

        public string Signature { get; set; }
    }
}
