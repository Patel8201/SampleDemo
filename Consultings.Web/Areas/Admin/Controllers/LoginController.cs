﻿using Microsoft.AspNetCore.Mvc;

namespace Consultings.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
