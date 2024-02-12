using AutoMapper;
using EntityLayer.WebApplication.Entities;
using EntityLayer.WebApplication.ViewModels.RequestAccessVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Automapper
{
    public class RequestAccessMapper : Profile
    {
        public RequestAccessMapper()
        {
            CreateMap<RequestAccess, RequestAccessListVM>().ReverseMap();
            CreateMap<RequestAccess , RequestAccessAddVM>().ReverseMap();
            CreateMap<RequestAccess , RequestAccessUpdateVM>().ReverseMap();
        }
    }
}
