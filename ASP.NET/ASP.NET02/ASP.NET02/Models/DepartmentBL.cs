using ASP.NET02.Data.DbContexts;
using Microsoft.EntityFrameworkCore;

namespace ASP.NET02.Models
{
    public class DepartmentBL
    {
        UniversityDbContext context = new UniversityDbContext();
        public List<Departments> GetAll()
        {
            return context.Departments.ToList();
        }

        public List<Departments> GetPaged(int page, int pageSize)
        {
            return context.Departments
                .Skip((page -1)  * pageSize)
                .Take(pageSize)
                .ToList();
        }

        public int GetCount()
        {
            return context.Departments.Count();
        }

        public Departments GetById(int id)
        {
            return context.Departments.Include((d) => d.Students).FirstOrDefault((d) => d.Id == id);
        }

        public void AddDept(Departments dept) 
        { 
            context.Departments.Add(dept);
            
            context.SaveChanges();
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }
}
