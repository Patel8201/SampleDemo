using EntityLayer.WebApplication.ViewModels.RequestAccessVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services.Abstract
{
    public interface IRequestAccessService
    {
        Task<List<RequestAccessListVM>> GetAllListAsync();
        Task AddRequestAccessAsync(RequestAccessAddVM request);
        Task<RequestAccessUpdateVM> GetRequestAccessById(int id);
        Task UpdateRequestAccessAsync(RequestAccessUpdateVM request);

        Task DeleteRequestAccessAsync(int id);
    }
}
