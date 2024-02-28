using EntityLayer.Identity.ViewModels;
using FluentValidation;

namespace ServiceLayer.FluentValidation.Identity.SignUpValidation
{
    public class SignUpValidations : AbstractValidator<SignUpVM>
    {
        public SignUpValidations()
        {
            RuleFor(x => x.UserName)
                .NotEmpty()
                .NotNull();
            RuleFor(x => x.Email)
                .NotEmpty()
                .NotNull()
                .EmailAddress();
            RuleFor(x => x.Password)
                .NotEmpty()
                .NotNull();
            RuleFor(x => x.ConfirmPassword)
                .NotEmpty()
                .NotNull()
                .Equal(x => x.Password);
        }
    }
}
