using EntityLayer.WebApplication.ViewModels.BlogVM;
using FluentValidation;

namespace ServiceLayer.FluentValidation.WebApplication.BlogValidation
{
    public class BlogAddValidation : AbstractValidator<BlogAddVM>
    {
        public BlogAddValidation()
        {
            
        }
    }
}
