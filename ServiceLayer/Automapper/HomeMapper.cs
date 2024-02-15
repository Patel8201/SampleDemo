using AutoMapper;
using EntityLayer.WebApplication.Entities;
using EntityLayer.WebApplication.ViewModels.HomeVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Automapper
{
    public class HomeMapper : Profile
    {
        public HomeMapper()
        {
            CreateMap<Home , HomeListVM>().ReverseMap();
            CreateMap<Home, HomeAddVM>().ReverseMap();
            CreateMap<Home, HomeUpdateVM>().ReverseMap();
        }
    }
}
