using Microsoft.EntityFrameworkCore;
using SchedulerCoreRazorEntityApp.Models;

namespace SchedulerCoreRazorEntityApp.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options): base(options)
        {

        }

        public DbSet<Job> Jobs { set; get; }
    }
}
