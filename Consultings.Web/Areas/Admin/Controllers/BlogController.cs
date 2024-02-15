using EntityLayer.WebApplication.ViewModels.BlogVM;
using EntityLayer.WebApplication.ViewModels.RequestAccessVM;
using Microsoft.AspNetCore.Mvc;
using ServiceLayer.Services.Abstract;
using ServiceLayer.Services.Concrete;

namespace Consultings.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BlogController : Controller
    {
        private readonly IBlogService _blogService;

        public BlogController(IBlogService blogService)
        {
            _blogService = blogService;
        }
        public async Task<IActionResult> GetBlogList()
        {
            var blogList = await _blogService.GetAllListAsync();
            return View(blogList);
        }

        [HttpGet]
        public IActionResult AddBlog()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddBlog(BlogAddVM request)
        {
            await _blogService.AddBlogAsync(request);
            return RedirectToAction("GetBlogList", "Blog", new { Areas = ("Admin") });
        }
        [HttpGet]
        public async Task<IActionResult> UpdateBlog(int id)
        {
            var Blog = await _blogService.GetBlogById(id);
            return View(Blog);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateBlog(BlogUpdateVM request)
        {
            await _blogService.UpdateBlogAsync(request);
            return RedirectToAction("GetBlogList", "Blog", new { Areas = ("Admin") });

        }

        public async Task<IActionResult> DeleteBlog(int id)
        {
            await _blogService.DeleteBlogAsync(id);
            return RedirectToAction("GetBlogList", "Blog", new { Areas = ("Admin") });
        }
    }
}
