using EntityLayer.WebApplication.ViewModels.BlogVM;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.FluentValidation.WebApplication.EventValidation
{
    public class EventAddValidation : AbstractValidator<BlogAddVM>
    {
        public EventAddValidation()
        {
        }
    }
}
