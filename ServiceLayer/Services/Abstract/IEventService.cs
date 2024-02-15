using EntityLayer.WebApplication.ViewModels.EventVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services.Abstract
{
    public interface IEventService
    {
        Task<List<EventListVM>> GetAllListAsync();
        Task AddEventAsync(EventAddVM request);
        Task<EventUpdateVM> GetEventById(int id);
        Task UpdateEventAsync(EventUpdateVM request);
        Task DeleteEventAsync(int id);
    }
}
