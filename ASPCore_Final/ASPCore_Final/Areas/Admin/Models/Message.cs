using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASPCore_Final.Areas.Admin.Models
{
    public class Message
    {
        [Required(ErrorMessage = "Nội dung tin nhắn không thể để trống")]
        public string message { get; set; }
    }
}
