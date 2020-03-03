using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using RESTfullWebSvc.ValidationAttributes;

namespace RESTfullWebSvc.Data.Models
{
    [AuthorFirstNameMustBeDifferentFromLastName]
    public class AuthorForCreationDto
    {
        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(50)]
        public string LastName { get; set; }

        [Required]
        public DateTimeOffset DateOfBirth { get; set; }

        [Required]
        [MaxLength(50)]
        public string MainCategory { get; set; }

        public ICollection<CourseForCreationDto> Courses { get; set; } = new List<CourseForCreationDto>();
    }
}
