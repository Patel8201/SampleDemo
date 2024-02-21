using EntityLayer.Identity.ViewModels;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.FluentValidation.Identity.SignUpValidation
{
    public class SignUpValidations : AbstractValidator<SignUpVM>
    {
        public SignUpValidations()
        {
            RuleFor(x => x.Title)
                .NotEmpty()
                .NotNull();
            RuleFor(x => x.FirstName)
                .NotEmpty()
                .NotNull();
            RuleFor(x => x.LastName)
                .NotEmpty()
                .NotNull();
            RuleFor(x => x.OtherLastName)
                .NotEmpty()
                .NotNull();
            RuleFor(x => x.CAQualificationYear)
                .NotEmpty()
                .NotNull();
            RuleFor(x => x.ProfessionalDesignation)
                .NotEmpty()
                .NotNull();
            RuleFor(x=> x.CurrentTitle)
                .NotEmpty()
                .NotNull();
            RuleFor(x => x.Phone)
                .NotEmpty()
                .NotNull();
            RuleFor(x => x.Extension)
                .NotEmpty()
                .NotNull();
            RuleFor(x => x.Company)
                .NotEmpty()
                .NotNull();
            RuleFor(x => x.BuildingNumber)
                .NotEmpty()
                .NotNull();
            RuleFor(x => x.Street)
                .NotEmpty()
                .NotNull();
            RuleFor(x => x.Country)
                .NotEmpty()
                .NotNull();
            RuleFor(x => x.State)
                .NotEmpty()
                .NotNull();
            RuleFor(x => x.PostalCode)
                .NotEmpty()
                .NotNull();
            RuleFor(x => x.CommencementYear)
                .NotEmpty()
                .NotNull();
            RuleFor(x => x.LeaveYear)
                .NotEmpty()
                .NotNull();
            RuleFor(x => x.KPMGOffice)
                .NotEmpty()
                .NotNull();
            RuleFor(x => x.Email)
                .NotEmpty()
                .NotNull();

        }
    }
}
