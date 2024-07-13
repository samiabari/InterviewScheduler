using SchedulerCoreRazorEntityApp.Models;

namespace SchedulerCoreRazorEntityApp.Repositories.Interface
{
    public interface IGenericRepo<T> where T : class
    {
        T Add(T t);
        T Update(int id, T t);
        bool Delete(int id);
        T GetById(int id);
        IEnumerable<T> GetAll();

        bool Save();
    }
}
