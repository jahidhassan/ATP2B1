using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ATP2B1.Models
{
    public class Min18Years:ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var customer = (Customer)validationContext.ObjectInstance;

            if(customer.MembershipTypeID==0||customer.MembershipTypeID==1)
                return ValidationResult.Success;

            int age = DateTime.Now.Year - customer.BirthDate.Year;

            if (age >= 18)
                return ValidationResult.Success;
            else
            {
                return new ValidationResult("Age Should be greater than or equal 18");
            }
        }
    }
}