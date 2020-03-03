using System.ComponentModel.DataAnnotations;
using RESTfullWebSvc.Data.Models;

namespace RESTfullWebSvc.ValidationAttributes
{
    public class CourseTitleMustBeDifferentFromDescriptionAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var course = (CourseForChangingDto)value;

            if (course.Title == course.Description)
            {
                return new ValidationResult(
                    string.IsNullOrWhiteSpace(ErrorMessage) ? "The provided description should be different from the title" : ErrorMessage,
                    new[] { nameof(CourseForChangingDto) });
            }

            return ValidationResult.Success;
        }
    }
}
