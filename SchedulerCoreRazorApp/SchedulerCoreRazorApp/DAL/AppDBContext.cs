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
        public DbSet<Appsite> Appsites { set; get; }
        public DbSet<Coretech> Coretechs { set; get; }
        public DbSet<Country> Countries { set; get; }
        public DbSet<Designation> Designations { set; get; }

        public DbSet<Interviewtype> Interviewtypes { set; get; }
        public DbSet<Jobtype> Jobtypes { set; get; }
        public DbSet<Position> Positions { set; get; }
        public DbSet<Recruitementtype> Recruitementtypes { set; get; }
        public DbSet<Workstation> Workstations { set; get; }

    }
}
