using SchedulerCoreRazorEntityApp.Models;

namespace SchedulerCoreRazorEntityApp.Repositories.Interface
{
    public interface IUnitOfWorkRepo: IDisposable
    {
        IJobRepo Jobs { get; }
        IGenericRepo<Status> Statuses { get; }
        Task<bool> Save();

    }
}
