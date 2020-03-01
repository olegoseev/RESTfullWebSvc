using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RESTfullWebSvc.Data.Models;

namespace RESTfullWebSvc.ValidationAttributes
{
    public class AuthorFirstNameMustBeDifferentFromLastName : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var author = (AuthorForCreationDto)value;

            if (author.FirstName == author.LastName)
            {
                return new ValidationResult(
                    string.IsNullOrWhiteSpace(ErrorMessage) ? "Authors FirstName and LastName cannot be same" : ErrorMessage,
                    new[] { nameof(AuthorForCreationDto) });
            }

            return ValidationResult.Success;
        }
    }
}
