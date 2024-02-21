using EntityLayer.WebApplication.ViewModels.BlogVM;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.FluentValidation.WebApplication.BlogValidation
{
    public class BolgUpdateValidation : AbstractValidator<BlogUpdateVM>
    {
        public BolgUpdateValidation()
        {

        }
    }
}
