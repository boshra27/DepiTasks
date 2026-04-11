using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP.NET02.Models
{
    public class Departments
    {
        public int Id { get; set; }

        [Display(Name = "Department")]
        [Required(ErrorMessage = "Required")]
        [MinLength(3, ErrorMessage = "More than 3")]
        [MaxLength(30, ErrorMessage = "Less than 30")]
        [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "Only use characters and spaces")]
        public string Name { get; set; }

        [Display(Name ="Manager Name")]
        [Required(ErrorMessage = "Required")]
        [MinLength(3, ErrorMessage = "More than 3")]
        [MaxLength(30, ErrorMessage = "Less than 30")]
        [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "Only use characters and spaces")]
        public string MgrName { get; set; }

        public List<Teachers> Teachers { get; set; } = new();
        public List<Courses> Courses { get; set; } = new();
        public List<Students> Students { get; set; } = new();
    }
}
