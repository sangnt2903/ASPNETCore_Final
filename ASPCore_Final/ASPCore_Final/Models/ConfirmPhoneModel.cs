using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASPCore_Final.Models
{
    public class ConfirmPhoneModel
    {
        [Required]
        [Display(Name = "Country dialing code")]
        public int DialingCode { get; set; }

        [Required]
        [Phone]
        [Display(Name = "Phone number")]
        public string PhoneNumber { get; set; }

        [Required]
        [Display(Name = "Code")]
        public string VerificationCode { get; set; }
    }
}
