using EntityLayer.WebApplication.ViewModels.BlogVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services.Abstract
{
    public interface IBlogService
    {
        Task<List<BlogListVM>> GetAllListAsync();
        Task AddBlogAsync(BlogAddVM request);
        Task<BlogUpdateVM> GetBlogById(int id);
        Task UpdateBlogAsync(BlogUpdateVM request);
        Task DeleteBlogAsync(int id);

    }
}
