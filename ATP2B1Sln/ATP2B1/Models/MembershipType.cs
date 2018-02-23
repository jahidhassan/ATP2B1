﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ATP2B1.Models
{
    public class MembershipType
    {
        public int ID { get; set; }
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        public int SignUpFee { get; set; }
        public int Duration { get; set; }
        public int Discount { get; set; }
    }
}