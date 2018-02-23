using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ATP2B1.Models;

namespace ATP2B1.ViewModel
{
    public class DetailCustomerVM
    {
        public Customer Customer { get; set; }
        public List<MembershipType> MembershipTypes { get; set; }
    }
}