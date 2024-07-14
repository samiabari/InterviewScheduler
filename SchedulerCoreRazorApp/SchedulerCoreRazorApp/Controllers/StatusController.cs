using Microsoft.AspNetCore.Mvc;
using SchedulerCoreRazorEntityApp.Repositories.Interface;

namespace SchedulerCoreRazorEntityApp.Controllers
{
    public class StatusController : Controller
    {
        private readonly IUnitOfWorkRepo unitOfWork;

        public StatusController(IUnitOfWorkRepo _unitOfWork)
        {
            this.unitOfWork = _unitOfWork;
        }
        public async Task<IActionResult> StatusIndex()
        {
            var statuses = await unitOfWork.Statuses.GetAll();
            return View(statuses);
          
        }
    }
}
