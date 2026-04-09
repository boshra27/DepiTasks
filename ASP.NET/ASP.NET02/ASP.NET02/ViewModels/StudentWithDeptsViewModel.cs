using ASP.NET02.Models;

namespace ASP.NET02.ViewModels
{
    public class StudentWithDeptsViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int DepartmentId { get; set; }

        public List<Departments> Departments { get; set; }
    }
}
