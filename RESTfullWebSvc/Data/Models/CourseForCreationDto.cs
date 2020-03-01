using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using RESTfullWebSvc.ValidationAttributes;

namespace RESTfullWebSvc.Data.Models
{
    [CourseTitleMustBeDifferentFromDescription(ErrorMessage = "Course Title must be different from the description.")]
    public class CourseForCreationDto
    {
        [Required(ErrorMessage ="The Course Title is required.")]
        [MaxLength(100, ErrorMessage ="The Course Title cannot exceed 100 characters.")]
        public string Title { get; set; }

        [MaxLength(1500, ErrorMessage = "The Course Description cannot exceed 1500 characters.")]
        public string Description { get; set; }
    }
}