using AutoMapper;
using AutoMapper.QueryableExtensions;
using EntityLayer.WebApplication.Entities;
using EntityLayer.WebApplication.ViewModels.RequestAccessVM;
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
    public class RequestAccessService : IRequestAccessService
    {
        
        private readonly IUnitOfWorks _unitOfWorks;
        private readonly IMapper _mapper;
        private readonly IGenericrepositories<RequestAccess> _genericrepositories;


        public RequestAccessService(IUnitOfWorks unitOfWorks, IMapper mapper, IGenericrepositories<RequestAccess> genericrepositories)
        {

            _unitOfWorks = unitOfWorks;
            _mapper = mapper;
            _genericrepositories = genericrepositories;
        }

        public async Task<List<RequestAccessListVM>> GetAllListAsync()
        {
            var requestAccessList = await _genericrepositories.GetAlltEntityList().ProjectTo<RequestAccessListVM>
                (_mapper.ConfigurationProvider).ToListAsync();
            return requestAccessList;
        }
        public async Task AddRequestAccessAsync(RequestAccessAddVM request)
        {
            var requestAccess = _mapper.Map<RequestAccess>(request);
            await _genericrepositories.AddtEntityAsync(requestAccess);
        }
        public async Task<RequestAccessUpdateVM> GetRequestAccessById(int id)
        {
            var requestAccess = await _genericrepositories.WhereAsync(x => x.Id == id).ProjectTo<RequestAccessUpdateVM>
                (_mapper.ConfigurationProvider).SingleAsync();
            return requestAccess;
        }

        public async Task UpdateRequestAccessAsync(RequestAccessUpdateVM request)
        {
            var requestAccess = _mapper.Map<RequestAccess> (request);
            _genericrepositories.UpdatetEntity(requestAccess);
            await _unitOfWorks.CommitAsync();
        }

        public async Task DeleteRequestAccessAsync(int id)
        {
            var requestAccess = await _genericrepositories.GetEntityByIdAsync(id);
            _genericrepositories.DeletetEntity(requestAccess);
            await _unitOfWorks.CommitAsync();
        }
    } 
}
