using AutoMapper;
using AutoMapper.QueryableExtensions;
using EntityLayer.WebApplication.Entities;
using EntityLayer.WebApplication.ViewModels.HomeVM;
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
    public class HomeService : IHomeService
    {
        private readonly IUnitOfWorks _unitOfWorks;
        private readonly IMapper _mapper;
        private readonly IGenericrepositories<Home> _genericrepositories;

        public HomeService(IUnitOfWorks unitOfWorks, IMapper mapper, IGenericrepositories<Home> genericrepositories)
        {
            _unitOfWorks = unitOfWorks;
            _mapper = mapper;
            _genericrepositories = genericrepositories;
        }

        public async Task<List<HomeListVM>> GetAllListAsync()
        {
            var homeList = await _genericrepositories.GetAlltEntityList().ProjectTo<HomeListVM>
                (_mapper.ConfigurationProvider).ToListAsync();
            return homeList;
        }

        public async Task AddHomeAsync(HomeAddVM request)
        {
            var home = _mapper.Map<Home>(request);
            await _genericrepositories.AddtEntityAsync(home);
        }

        public async Task<HomeUpdateVM> GetHomeById(int id)
        {
            var home = await _genericrepositories.WhereAsync(x => x.Id == id).ProjectTo<HomeUpdateVM>
                (_mapper.ConfigurationProvider).SingleAsync();
            return home;
        }
        public async Task UpdateHomeAsync(HomeUpdateVM request)
        {
            var home = _mapper.Map<Home>(request);
            _genericrepositories.UpdatetEntity(home);
            await _unitOfWorks.CommitAsync();
        }
        public async Task DeleteHomeAsync(int id)
        {
            var home = await _genericrepositories.GetEntityByIdAsync(id);
            _genericrepositories.DeletetEntity(home);
            await _unitOfWorks.CommitAsync();
        }

    }
}
