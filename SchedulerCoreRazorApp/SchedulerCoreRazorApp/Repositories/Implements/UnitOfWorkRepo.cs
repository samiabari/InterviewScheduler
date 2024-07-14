using SchedulerCoreRazorEntityApp.DAL;
using SchedulerCoreRazorEntityApp.Models;
using SchedulerCoreRazorEntityApp.Repositories.Interface;

namespace SchedulerCoreRazorEntityApp.Repositories.Implements
{
    public class UnitOfWorkRepo : IUnitOfWorkRepo
    {
        private readonly AppDbContext appDbContext;
        public IJobRepo Jobs { get; private set; }

        public IGenericRepo<Status>  Statuses { get; private set; }
        public UnitOfWorkRepo(AppDbContext _appDbContext)
        {
            this.appDbContext = _appDbContext;
            this.Jobs = new JobRepo(appDbContext);
            this.Statuses = new GenericRepo<Status>(appDbContext);
        }

        public async Task<bool> Save()
        {
            try
            {
                await appDbContext.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public void Dispose()
        {
            appDbContext.Dispose();
        }
    }
}
