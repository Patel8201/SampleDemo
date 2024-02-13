using EntityLayer.WebApplication.ViewModels.RequestAccessVM;
using Microsoft.AspNetCore.Mvc;
using ServiceLayer.Services.Abstract;

namespace Consultings.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class RequestAccessController : Controller
    {
        private readonly IRequestAccessService _requestAccessService;

        public RequestAccessController(IRequestAccessService requestAccessService)
        {
            _requestAccessService = requestAccessService;
        }

        public async Task<IActionResult> GetRequestAccessList()
        {
            var requestAccessList = await _requestAccessService.GetAllListAsync();
            return View(requestAccessList);
        }
        [HttpGet]
        public IActionResult AddRequestAccess()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddRequestAccess(RequestAccessAddVM request)
        {
            await _requestAccessService.AddRequestAccessAsync(request);
            return RedirectToAction("GetRequestAccessList", "RequestAccess", new { Areas = ("Admin") });
        }
        [HttpGet]
        public async Task<IActionResult> UpdateRequestAccess(int id)
        {
            var requestAccess = await _requestAccessService.GetRequestAccessById(id);
            return View(requestAccess);
        }
        [HttpPost]
        public async Task<IActionResult> UpdateRequestAccess(RequestAccessUpdateVM request)
        {
            await _requestAccessService.UpdateRequestAccessAsync(request);
            return RedirectToAction("GetRequestAccessList", "RequestAccess", new { Areas = ("Admin") });

        }
        public async Task<IActionResult> DeleteRequestAccess(int id)
        {
            await _requestAccessService.DeleteRequestAccessAsync(id);
            return RedirectToAction("GetRequestAccessList", "RequestAccess", new { Areas = ("Admin") });

        }
    }
}
