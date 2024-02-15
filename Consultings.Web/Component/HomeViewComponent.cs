using Microsoft.AspNetCore.Mvc;
using ServiceLayer.Services.Abstract;

namespace Consultings.Web.Component
{
    public class HomeViewComponent : ViewComponent
    {
        private readonly IHomeService _homeService;

        public HomeViewComponent(IHomeService homeService)
        {
            _homeService = homeService;
        }
    }
}
