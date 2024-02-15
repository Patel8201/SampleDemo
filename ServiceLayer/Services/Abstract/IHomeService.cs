using EntityLayer.WebApplication.ViewModels.HomeVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services.Abstract
{
    public interface IHomeService
    {
        Task<List<HomeListVM>> GetAllListAsync();
        Task AddHomeAsync(HomeAddVM request);
        Task<HomeUpdateVM> GetHomeById(int id);
        Task UpdateHomeAsync(HomeUpdateVM request);
        Task DeleteHomeAsync(int id);
    }
}
