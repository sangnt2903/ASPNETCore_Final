using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASPCore_Final.Models
{
    public class VerifyPhoneModel
    {
        [Required]
        [Display(Name = "Country dialing code")]
        public int CountryCode { get; set; }

        [Required]
        [Phone]
        [Display(Name = "Phone number")]
        public string PhoneNumber { get; set; }
    }
}
