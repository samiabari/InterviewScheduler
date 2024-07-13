using Microsoft.EntityFrameworkCore;
using SchedulerCoreRazorEntityApp.DAL;
using SchedulerCoreRazorEntityApp.Models;
using SchedulerCoreRazorEntityApp.Repositories.Interface;
using System;

namespace SchedulerCoreRazorEntityApp.Repositories.Implements
{
    public class JobRepo : GenericRepo<Job>, IJobRepo
    {
        public JobRepo(AppDbContext _appDbContext) : base(_appDbContext)
        {

        }

        public async Task<IEnumerable<Job>> GetAllPendingJobs(int status_id)
        {
            var obj = await appDbContext.Jobs.Where(j=> j.Status_id== status_id).ToListAsync();
            if (obj == null)
            {
                throw new Exception("No Data found with this status.");
            }
            return obj;
        }
    }
}
