using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;

namespace TesteFlurl.API.Configurations
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddMySwaggerGen(this IServiceCollection services)
        {
            services.AddSwaggerGen(c => c.SwaggerDoc("v1", new OpenApiInfo { Title = "TesteFlurl.API", Version = "v1" }));

            return services;
        }
    }
}
