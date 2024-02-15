using EntityLayer.WebApplication.ViewModels.EventVM;
using EntityLayer.WebApplication.ViewModels.RequestAccessVM;
using Microsoft.AspNetCore.Mvc;
using ServiceLayer.Services.Abstract;
using ServiceLayer.Services.Concrete;

namespace Consultings.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class EventController : Controller
    {
       private readonly IEventService _eventService;

        public EventController(IEventService eventService)
        {
            _eventService = eventService;
        }
        public async Task<IActionResult> GetEventList()
        {
            var EventList = await _eventService.GetAllListAsync();
            return View(EventList);
        }
        [HttpGet]
        public IActionResult AddEvent()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddEvent(EventAddVM request)
        {
            await _eventService.AddEventAsync(request);
            return RedirectToAction("GetEventList", "Event", new { Areas = ("Admin") });
        }
        [HttpGet]
        public async Task<IActionResult> UpdateEvent(int id)
        {
            var Event = await _eventService.GetEventById(id);
            return View(Event);
        }
        [HttpPost]
        public async Task<IActionResult> UpdateEvent(EventUpdateVM request)
        {
            await _eventService.UpdateEventAsync(request);
            return RedirectToAction("GetEventList", "Event", new { Areas = ("Admin") });

        }
        public async Task<IActionResult> DeleteEvent(int id)
        {
            await _eventService.DeleteEventAsync(id);
            return RedirectToAction("GetEventList", "Event", new { Areas = ("Admin") });
        }
    }
}
