using ASP.NET02.Models;
using System.ComponentModel.DataAnnotations;

namespace ASP.NET02.ViewModels
{
    public class CoursesWithDeptsViewModel
    {
        public int Id { get; set; }

        [Display(Name = "Course Name")]
        [Required(ErrorMessage = "Required")]
        [MinLength(3, ErrorMessage = "More than 3")]
        [MaxLength(30, ErrorMessage = "Less than 30")]
        [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "Only use characters and spaces")]
        public string Name { get; set; }


        [Required(ErrorMessage = "Required")]
        [Range(1, int.MaxValue, ErrorMessage = "Must be Positive")]
        public int Degree { get; set; }

        [Display(Name = "Minimum Degree")]
        [Required(ErrorMessage = "Required")]
        [Range(1, int.MaxValue, ErrorMessage = "Must be Positive")]
        public int MinDegree { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Select a valid Department")]
        [Display(Name = "Department")]
        public int DepartmentId { get; set; }

        public List<Departments> Departments { get; set; } = new List<Departments>();
    }
}
