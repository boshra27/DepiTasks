using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP.NET02.Models
{
    public class Departments
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string MgrName { get; set; }

        public List<Teachers> Teachers { get; set; } = new();
        public List<Courses> Courses { get; set; } = new();
        public List<Students> Students { get; set; } = new();
    }
}
