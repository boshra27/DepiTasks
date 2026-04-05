using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP.NET02.Models
{
    public class Teachers
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public string Address { get; set; }
        public int CourseId { get; set; }
        public int DepartmentId { get; set; }

        public Courses Courses { get; set; }
        public Departments Departments { get; set; }
    }
}
