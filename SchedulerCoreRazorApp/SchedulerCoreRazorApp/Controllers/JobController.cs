using Microsoft.AspNetCore.Mvc;
using SchedulerCoreRazorEntityApp.Models;
using SchedulerCoreRazorEntityApp.Repositories.Interface;

namespace SchedulerCoreRazorEntityApp.Controllers
{
    public class JobController : Controller
    {
        private readonly IUnitOfWorkRepo unitOfWork;

        public JobController(IUnitOfWorkRepo _unitOfWork)
        {
            this.unitOfWork = _unitOfWork;
        }

        public async Task<IActionResult> Index()
        {
            var jobs = await unitOfWork.Jobs.GetAllPendingJobs(2);
            return View(jobs);
        }


        public async Task<IActionResult> AddJob(Job job)
        {
            var jobs = await unitOfWork.Jobs.GetAllPendingJobs(2);
            return View();
        }
    }
}
