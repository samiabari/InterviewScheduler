using SchedulerCoreRazorEntityApp.Models;

namespace SchedulerCoreRazorEntityApp.Repositories.Interface
{
    public interface IJobRepo : IGenericRepo<Job>
    {
        IEnumerable<Job> GetAllPendingJobs(int status_id);
    }
}
