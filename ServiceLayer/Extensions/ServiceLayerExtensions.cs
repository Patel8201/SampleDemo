using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ServiceLayer.Extensions.Identity;
using ServiceLayer.Services.Abstract;
using ServiceLayer.Services.Concrete;
using System.Reflection;

namespace ServiceLayer.Extensions
{
    public static class ServiceLayerExtensions
    {
        public static IServiceCollection LoadServiceLayerExtensions(this IServiceCollection services, IConfiguration configuration)
        {
            services.LoadIdentityExtensions();

            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddScoped<IRequestAccessService, RequestAccessService>();
            services.AddScoped<IBlogService, BlogService>();
            services.AddScoped<IEventService, EventService>();
            services.AddScoped<IHomeService, HomeService>();

            return services;


        }
    }
}
