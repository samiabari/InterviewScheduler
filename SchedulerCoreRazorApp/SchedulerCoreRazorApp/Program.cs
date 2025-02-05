using Microsoft.EntityFrameworkCore;
using SchedulerCoreRazorEntityApp.DAL;
using SchedulerCoreRazorEntityApp.Repositories.Implements;
using SchedulerCoreRazorEntityApp.Repositories.Interface;

namespace SchedulerCoreRazorApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddRazorPages();

            builder.Services.AddDbContext<AppDbContext>(options => {

                options.UseSqlServer(builder.Configuration.GetConnectionString("DBConnection"));
            });

         
            builder.Services.AddScoped<IUnitOfWorkRepo, UnitOfWorkRepo>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
            name: "default",
            pattern: "{controller=Job}/{action=Index}"); // Change Home/Dashboard to your desired controller/action



            app.MapRazorPages();

            app.Run();
        }
    }
}
