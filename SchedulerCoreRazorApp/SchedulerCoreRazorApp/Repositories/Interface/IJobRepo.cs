using SchedulerCoreRazorEntityApp.Models;

namespace SchedulerCoreRazorEntityApp.Repositories.Interface
{
    public interface IJobRepo
    {
        Job AddJob(Job job);
        Job UpdateJob(Job job);
        bool DeleteJob(int id);
        Job GetJobById(int id);
        List<Job> GetAllJob();
        
    }
}
