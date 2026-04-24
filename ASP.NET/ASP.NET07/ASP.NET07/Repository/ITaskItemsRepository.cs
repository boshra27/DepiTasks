using ASP.NET07.Models;

namespace ASP.NET07.Repository
{
    public interface ITaskItemsRepository
    {
        void Add(TaskItem taskitem);
        void Update(TaskItem taskitem);
        void Delete(TaskItem taskitem);
        void Save();
        List<TaskItem> GetAll();
        TaskItem GetById(int id);

    }
}
