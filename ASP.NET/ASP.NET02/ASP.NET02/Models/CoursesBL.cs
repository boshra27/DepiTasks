using ASP.NET02.Data.DbContexts;
using Microsoft.EntityFrameworkCore;

namespace ASP.NET02.Models
{
    public class CoursesBL
    {
        UniversityDbContext context = new UniversityDbContext();

        public List<Courses> GetAll()
        {
            return context.Courses.Include(c => c.Departments)
                .ToList();
        }

        public Courses GetById(int id) 
        {
            return context.Courses.FirstOrDefault((c) => c.Id == id);
        }

        public void AddCourse(Courses crs)
        {
            context.Courses.Add(crs);
            context.SaveChanges();
        }
        public void Save()
        {
            context.SaveChanges();
        }

        public void DeleteCrs(Courses Crs) 
        {
            context.Courses.Remove(Crs);
            context.SaveChanges();
        }

    }
}
