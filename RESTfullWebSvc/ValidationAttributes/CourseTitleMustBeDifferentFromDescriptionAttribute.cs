using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RESTfullWebSvc.Data.Models;

namespace RESTfullWebSvc.ValidationAttributes
{
    public class CourseTitleMustBeDifferentFromDescriptionAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var course = (CourseForCreationDto)value;

            if (course.Title == course.Description)
            {
                return new ValidationResult(
                    string.IsNullOrWhiteSpace(ErrorMessage) ? "The provided description should be different from the title" : ErrorMessage,
                    new[] { nameof(CourseForCreationDto) });
            }

            return ValidationResult.Success;
        }
    }
}
