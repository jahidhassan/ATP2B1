using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ATP2B1.Models
{
    public class PhoneValidation : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var mblNo = value.ToString();

            if (!mblNo.StartsWith("01"))
                return new ValidationResult("Number should start with 0");

            if(mblNo.Length!=11)
                return new ValidationResult("Number should be 11 digit");

            return ValidationResult.Success;
        }
    }
}