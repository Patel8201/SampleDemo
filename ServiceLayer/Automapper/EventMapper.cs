using AutoMapper;
using EntityLayer.WebApplication.Entities;
using EntityLayer.WebApplication.ViewModels.EventVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Automapper
{
    public class EventMapper : Profile
    {
        public EventMapper()
        {
            CreateMap<Event , EventListVM>().ReverseMap();
            CreateMap<Event , EventAddVM>().ReverseMap();
            CreateMap<Event , EventUpdateVM>().ReverseMap();
        }
    }
}
