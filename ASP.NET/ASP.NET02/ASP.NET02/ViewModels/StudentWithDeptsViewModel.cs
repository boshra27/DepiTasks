using ASP.NET02.Models;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace ASP.NET02.ViewModels
{
    public class StudentWithDeptsViewModel
    {
        public int Id { get; set; }

        [Display(Name = "Full Name")]
        [Required(ErrorMessage ="Required")]
        [MinLength(3, ErrorMessage = "More than 3")]
        [MaxLength(30, ErrorMessage ="Less than 30")]
        [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage ="Only use characters and spaces")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Required")]
        [Range(17,int.MaxValue, ErrorMessage ="Age Must be 17 or Older")]
        public int Age { get; set; }

        [Range(1,int.MaxValue, ErrorMessage ="Select a valid Department")]
        [Display(Name ="Department")]
        public int DepartmentId { get; set; }

        [ValidateNever]
        public List<Departments> Departments { get; set; }
    }
}
