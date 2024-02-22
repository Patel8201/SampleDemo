using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ServiceLayer.Extensions.Identity;
using ServiceLayer.FluentValidation.Identity.SignUpValidation;
using ServiceLayer.Services.Abstract;
using ServiceLayer.Services.Concrete;
using System.Reflection;



namespace ServiceLayer.Extensions
{
    public static class ServiceLayerExtensions
    {
        public static IServiceCollection LoadServiceLayerExtensions(this IServiceCollection services, IConfiguration configuration)
        {
            services.LoadIdentityExtensions(configuration);

            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddScoped<IRequestAccessService, RequestAccessService>();
            services.AddScoped<IBlogService, BlogService>();
            services.AddScoped<IEventService, EventService>();
            services.AddScoped<IHomeService, HomeService>();


            services.AddFluentValidationAutoValidation(opt =>
            {
                opt.DisableDataAnnotationsValidation = true;
            });

            services.AddValidatorsFromAssemblyContaining<SignUpValidations>();

            return services;


        }
    }
}
