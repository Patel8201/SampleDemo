using Microsoft.AspNetCore.Mvc;

namespace Consultings.Web.Areas.User.Controllers
{
    public class DashboardController : Controller
    {
        [Area("User")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
