using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace ItemInsight.Shared.Domain
{
    public class Staff : BaseDomainModel, IValidatableObject
    {
        [Required]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Your Name does not meet the length requirements")]
        public string? Name { get; set; }

        [Required]
        [Phone(ErrorMessage = "Invalid Phone Number")]
        [StringLength(8, ErrorMessage = "Contact number must be 8 digits")]
        public string? ContactNo { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        [EmailAddress(ErrorMessage = "Email Address is not a valid email")]
        public string? Email { get; set; }

        [Required]
        [EnhancedPasswordValidation] // Renamed custom validation attribute for password
        public string? Password { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            // Example of custom validation logic
            if (Password == Name)
            {
                yield return new ValidationResult("Password cannot be the same as your name", new[] { nameof(Password) });
            }

            // Add more custom validation logic as needed
        }
    }

    public class EnhancedPasswordValidationAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var password = value as string;
            if (string.IsNullOrWhiteSpace(password))
            {
                return new ValidationResult("Password is required");
            }

            // Example: Password must be at least 8 characters long and contain a number and an uppercase letter
            if (password.Length < 8 || !Regex.IsMatch(password, @"\d") || !Regex.IsMatch(password, @"[A-Z]"))
            {
                return new ValidationResult("Password must be at least 8 characters long, contain a number, and an uppercase letter");
            }

            return ValidationResult.Success;
        }
    }
}
