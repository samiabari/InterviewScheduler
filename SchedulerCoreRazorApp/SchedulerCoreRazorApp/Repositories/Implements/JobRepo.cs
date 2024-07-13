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

        public Job UpdateJob(Job job)
        {
            var jobToBeUpdated = appDbContext.Jobs.SingleOrDefault(j => j.JobId == job.JobId);
            
            if (jobToBeUpdated == null)
            {
                throw new Exception("No Data found to be updated");
            }
            var result = appDbContext.Jobs.Update(jobToBeUpdated);
            appDbContext.SaveChanges();
            return result.Entity;

        }
        public bool DeleteJob(int id)
        {
            var jobToBeUpdated = appDbContext.Jobs.SingleOrDefault(j => j.JobId == id);

            if (jobToBeUpdated == null)
            {
                throw new Exception("No Data found to be updated");
            }

            try
            {
                appDbContext.Jobs.Remove(jobToBeUpdated);
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
            var job = appDbContext.Jobs.SingleOrDefault(j => j.JobId == id);
            return job;
        }

       
    }
}
