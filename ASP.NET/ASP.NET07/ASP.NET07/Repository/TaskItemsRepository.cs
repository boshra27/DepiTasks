using ASP.NET07.Data.Contexts;
using ASP.NET07.Models;

namespace ASP.NET07.Repository
{
    public class TaskItemsRepository : ITaskItemsRepository
    {
        TaskDbContext _context;
        public TaskItemsRepository()
        {
            _context = new TaskDbContext();
        }
        public void Add(TaskItem taskitem)
        {
            _context.Add(taskitem);
        }

        public void Delete(TaskItem taskitem)
        {
            _context.Remove(taskitem);
        }

        public List<TaskItem> GetAll()
        {
            return _context.TaskItems.ToList();
        }

        public TaskItem GetById(int id)
        {
            return _context.TaskItems.FirstOrDefault(t => t.Id == id);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(TaskItem taskitem)
        {
            _context.Update(taskitem);
        }
    }
}
