using ASP.NET02.Data.DbContexts;

namespace ASP.NET02.Models
{
    public class StudentsBL
    {
        UniversityDbContext context = new UniversityDbContext();
        public List<Students> GetAll()
        {
            return context.Students.ToList();
        }

        public Students GetById(int id) 
        {
            return context.Students.FirstOrDefault(S => S.Id == id);
        }
    }
}
