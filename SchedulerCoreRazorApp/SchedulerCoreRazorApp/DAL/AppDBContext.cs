using Microsoft.EntityFrameworkCore;
using SchedulerCoreRazorEntityApp.Models;

namespace SchedulerCoreRazorEntityApp.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
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

        public DbSet<Status> Statuses { set; get; }


        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            base.OnModelCreating(modelbuilder);
            modelbuilder.Entity<Job>().HasKey(a=>a.JobId);
            modelbuilder.Entity<Appsite>().HasKey(a => a.App_site_id);
            modelbuilder.Entity<Coretech>().HasKey(a => a.Core_tech_id);
            modelbuilder.Entity<Country>().HasKey(a => a.Country_id);
            modelbuilder.Entity<Designation>().HasKey(a => a.Designation_id);
            modelbuilder.Entity<Interviewtype>().HasKey(a => a.Interview_type_id);
            modelbuilder.Entity<Jobtype>().HasKey(a => a.Job_type_id);
            modelbuilder.Entity<Position>().HasKey(a => a.Position_type_id);

            modelbuilder.Entity<Recruitementtype>().HasKey(a => a.Recruitement_type_id);
            modelbuilder.Entity<Workstation>().HasKey(a => a.Workstation_id);
            modelbuilder.Entity<Status>().HasKey(a => a.Status_id);

        }

    }
}
