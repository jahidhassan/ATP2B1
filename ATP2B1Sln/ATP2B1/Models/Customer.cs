using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Services.Description;

namespace ATP2B1.Models
{
    public class Customer
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "Name Required")]
        [StringLength(255,ErrorMessage = "Name Can't be more than 255 char")]
        public string Name { get; set; }
        [Required]
        [StringLength(25)]
        [PhoneValidation]
        public string MobileNo { get; set; }
        public bool IsSubscribeToMail { get; set; }
        public MembershipType MembershipType { get; set; }
        [Display(Name = "Membership Type")]
        public int MembershipTypeID { get; set; }

        [Display(Name = "Date of Birth")]
        [Min18Years]
        public DateTime BirthDate { get; set; }

        [Required]
        public string Gender { get; set; }
    }
}