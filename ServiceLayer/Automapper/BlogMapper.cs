using AutoMapper;
using EntityLayer.WebApplication.Entities;
using EntityLayer.WebApplication.ViewModels.BlogVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Automapper
{
    public class BlogMapper : Profile
    {
        public BlogMapper()
        {
            CreateMap<Blog , BlogListVM>().ReverseMap();
            CreateMap<Blog , BlogAddVM>().ReverseMap();
            CreateMap < Blog, BlogUpdateVM>().ReverseMap();
        }
    }
}
