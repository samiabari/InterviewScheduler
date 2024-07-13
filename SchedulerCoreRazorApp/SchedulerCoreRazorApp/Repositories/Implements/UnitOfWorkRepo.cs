using SchedulerCoreRazorEntityApp.DAL;
using SchedulerCoreRazorEntityApp.Repositories.Interface;

namespace SchedulerCoreRazorEntityApp.Repositories.Implements
{
    public class UnitOfWorkRepo : IUnitOfWorkRepo
    {
        private readonly AppDbContext appDbContext;
        public IJobRepo JobRepo { get; private set; }

        public UnitOfWorkRepo(AppDbContext _appDbContext)
        {
            this.appDbContext = _appDbContext;
            this.JobRepo = new JobRepo(appDbContext);
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
