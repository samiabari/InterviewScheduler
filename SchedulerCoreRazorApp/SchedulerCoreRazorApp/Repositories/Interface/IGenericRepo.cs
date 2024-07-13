using SchedulerCoreRazorEntityApp.Models;

namespace SchedulerCoreRazorEntityApp.Repositories.Interface
{
    public interface IGenericRepo<T> where T : class
    {
        Task<T> Add(T t);
        Task<T> Update(int id, T t);
        Task<bool> Delete(int id);
        Task<T> GetById(int id);
        Task<IEnumerable<T>> GetAll();

        Task<bool> Save();
    }
}
