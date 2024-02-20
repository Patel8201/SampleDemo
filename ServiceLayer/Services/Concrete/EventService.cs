using AutoMapper;
using AutoMapper.QueryableExtensions;
using EntityLayer.WebApplication.Entities;
using EntityLayer.WebApplication.ViewModels.EventVM;
using EntityLayer.WebApplication.ViewModels.HomeVM;
using Microsoft.EntityFrameworkCore;
using RepositoryLayer.Repositories.Abstract;
using RepositoryLayer.UnitOfWorks.Abstract;
using ServiceLayer.Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services.Concrete
{
    public class EventService : IEventService
    {
        private readonly IUnitOfWorks _unitOfWorks;
        private readonly IMapper _mapper;
        private readonly IGenericrepositories<Event> _genericrepositories;

        public EventService(IUnitOfWorks unitOfWorks, IMapper mapper, IGenericrepositories<Event> genericrepositories)
        {
            _unitOfWorks = unitOfWorks;
            _mapper = mapper;
            _genericrepositories = genericrepositories;
        }
        public async Task<List<EventListVM>> GetAllListAsync()
        {
            var eventList = await _genericrepositories.GetAlltEntityList().ProjectTo<EventListVM>
                (_mapper.ConfigurationProvider).ToListAsync();
            return eventList;
        }
        public async Task AddEventAsync(EventAddVM request)
        {
            var Event = _mapper.Map<Event>(request);
            await _genericrepositories.AddtEntityAsync(Event);
        }
        public async Task<EventUpdateVM> GetEventById(int id)
        {
            //var Event = await _genericrepositories.WhereAsync(x => x.Id == id).ProjectTo<EventUpdateVM>
            //    (_mapper.ConfigurationProvider).SingleAsync();
            var Event = await _genericrepositories.WhereAsync(x => x.Id == id)
                                         .ProjectTo<EventUpdateVM>(_mapper.ConfigurationProvider)
                                         .FirstOrDefaultAsync();
            return Event;
        }
        public async Task UpdateEventAsync(EventUpdateVM request)
        {
            var Event = _mapper.Map<Event>(request);
            _genericrepositories.UpdatetEntity(Event);
            await _unitOfWorks.CommitAsync();
        }
        public async Task DeleteEventAsync(int id)
        {
            var Event = await _genericrepositories.GetEntityByIdAsync(id);
            _genericrepositories.DeletetEntity(Event);
            await _unitOfWorks.CommitAsync();
        }

    }
}
