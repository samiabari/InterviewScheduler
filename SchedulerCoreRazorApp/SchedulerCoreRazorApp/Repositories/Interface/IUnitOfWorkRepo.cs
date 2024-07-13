namespace SchedulerCoreRazorEntityApp.Repositories.Interface
{
    public interface IUnitOfWorkRepo: IDisposable
    {
        IJobRepo JobRepo { get; }

        Task<bool> Save();

    }
}
