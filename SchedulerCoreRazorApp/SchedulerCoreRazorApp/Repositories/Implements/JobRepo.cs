using SchedulerCoreRazorEntityApp.DAL;
using SchedulerCoreRazorEntityApp.Models;
using SchedulerCoreRazorEntityApp.Repositories.Interface;

namespace SchedulerCoreRazorEntityApp.Repositories.Implements
{
    public class JobRepo : IJobRepo
    {
        private readonly AppDbContext appDbContext;
        public JobRepo(AppDbContext _appDbContext) 
        { 
            this.appDbContext = _appDbContext;
        }
        public Job AddJob(Job job)
        {
            var result = appDbContext.Jobs.Add(job);
            appDbContext.SaveChanges();
            return result.Entity;
        }

        public Job UpdateJob(int id, Job job)
        {
            var result = appDbContext.Jobs.Find(id);
            
            if (result == null)
            {
                throw new Exception("No Data found to be updated");
            }
            var updatedJob = appDbContext.Jobs.Update(job);
            appDbContext.SaveChanges();
            return updatedJob.Entity;

        }
        public bool DeleteJob(int id)
        {
            var result = appDbContext.Jobs.Find(id);

            if (result == null)
            {
                throw new Exception("No Data found to be updated");
            }

            try
            {
                appDbContext.Jobs.Remove(result);
                appDbContext.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<Job> GetAllJob()
        {
            var jobs = appDbContext.Jobs.ToList();
            return jobs;
        }

        public Job GetJobById(int id)
        {
            var job = appDbContext.Jobs.Find(id);
            return job;
        }

       
    }
}
