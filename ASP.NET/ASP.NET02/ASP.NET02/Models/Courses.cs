using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP.NET02.Models
{
    public class Courses
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Degree { get; set; }
        public int MinDegree { get; set; }
        public int DepartmentId { get; set; }

        public List<Teachers> Teachers { get; set; } = new();
        public Departments Departments { get; set; }
        public List<StuCrsRes> StuCrsRes { get; set; } = new();

    }
}
