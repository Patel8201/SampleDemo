using AutoMapper;
using AutoMapper.QueryableExtensions;
using EntityLayer.WebApplication.Entities;
using EntityLayer.WebApplication.ViewModels.BlogVM;
using Microsoft.EntityFrameworkCore;
using RepositoryLayer.Repositories.Abstract;
using RepositoryLayer.Repositories.Concrete;
using RepositoryLayer.UnitOfWorks.Abstract;
using RepositoryLayer.UnitOfWorks.Concrete;
using ServiceLayer.Services.Abstract;

namespace ServiceLayer.Services.Concrete
{
    public class BlogService : IBlogService
    {


        public readonly IUnitOfWorks _unitOfWorks;
        public readonly IMapper _mapper;
        public readonly IGenericrepositories<Blog> _genericrepositories;

        public BlogService(IUnitOfWorks unitOfWorks, IMapper mapper, IGenericrepositories<Blog> genericrepositories)
        {
            _unitOfWorks = unitOfWorks;
            _mapper = mapper;
            _genericrepositories = genericrepositories;
        }
        public async Task<List<BlogListVM>> GetAllListAsync()
        {
            var blogList = await _genericrepositories.GetAlltEntityList().ProjectTo<BlogListVM>
                (_mapper.ConfigurationProvider).ToListAsync();
            return blogList;
        }

        public async Task AddBlogAsync(BlogAddVM request)
        {
            var blog = _mapper.Map<Blog>(request);
            await _genericrepositories.AddtEntityAsync(blog);
        }
        public async Task<BlogUpdateVM> GetBlogById(int id)
        {
            var blog = await _genericrepositories.WhereAsync(x => x.Id == id)
                                         .ProjectTo<BlogUpdateVM>(_mapper.ConfigurationProvider)
                                         .FirstOrDefaultAsync();
            //var blog = await _genericrepositories.WhereAsync(x => x.Id == id).ProjectTo<BlogUpdateVM>
            //     (_mapper.ConfigurationProvider).SingleAsync();
            return blog;
        }
      
        public async Task UpdateBlogAsync(BlogUpdateVM request)
        {
            var blog = _mapper.Map<Blog>(request);
            _genericrepositories.UpdatetEntity(blog);
            await _unitOfWorks.CommitAsync();
        }
        public async Task DeleteBlogAsync(int id)
        {
            var blog = await _genericrepositories.GetEntityByIdAsync(id);
            _genericrepositories.DeletetEntity(blog);
            await _unitOfWorks.CommitAsync();
        }
    }
}
