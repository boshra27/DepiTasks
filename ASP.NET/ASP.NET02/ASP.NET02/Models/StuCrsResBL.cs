using ASP.NET02.Data.DbContexts;
using Microsoft.EntityFrameworkCore;

namespace ASP.NET02.Models
{
    public class StuCrsResBL
    {
        UniversityDbContext context = new UniversityDbContext();

        public List<StuCrsRes> GetAll()
        {
            return context.StuCrsRes.Include(scr => scr.Student)
                .Include(scr => scr.Course)
                .ToList();
        }

        public StuCrsRes GetById(int sid, int cid)
        {
            return context.StuCrsRes
                .Include(scr => scr.Student)
                .Include(scr => scr.Course)
                .FirstOrDefault(scr => scr.StudentId == sid && scr.CourseId == cid);
        }
    }
}
