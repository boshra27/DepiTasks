using ASP.NET02.Data.DbContexts;
using Microsoft.EntityFrameworkCore;

namespace ASP.NET02.Models
{
    public class StudentsBL
    {
        UniversityDbContext context = new UniversityDbContext();
        public List<Students> GetAll()
        {
            return context.Students.Include(S => S.Department)
                .ToList();
        }

        public List<Students> GetPaged(int page, int pageSize)
        {
            return context.Students
                .Include(S => S.Department)
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToList();
        }

        public int GetCount()
        {
            return context.Students.Count();
        }

        public Students GetById(int id) 
        {
            return context.Students.Include(S =>S.Department).FirstOrDefault(S => S.Id == id);
        }

        public void AddEmp(Students Stu)
        {
            context.Students.Add(Stu);
            context.SaveChanges();
        }

        public void DeleteStu(Students Stu)
        {
            context.Students.Remove(Stu);
            context.SaveChanges();
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }
}
