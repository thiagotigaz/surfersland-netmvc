using System;
using System.ComponentModel.DataAnnotations;

namespace SurfersLand.Models
{
    public class Min18YearIfAMember : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var customer = (Customer) validationContext.ObjectInstance;
            if (customer.MembershipTypeId == MembershipType.Unknown ||
                customer.MembershipTypeId == MembershipType.PayAsYouGo)
                return ValidationResult.Success;

            if (customer.BirthDate == null)
                return new ValidationResult("Birthdate is required.");

            // TODO do proper age calculation
            var age = DateTime.Today.Year - customer.BirthDate.Value.Year;
            return (age >= 18)
                ? ValidationResult.Success
                : new ValidationResult("Customer should be at least 18 years old to go on a membership.");
        }
    }
}