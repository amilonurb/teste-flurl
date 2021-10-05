using Microsoft.AspNetCore.Builder;

namespace TesteFlurl.API.Configurations
{
    public static class ApplicationBuilderExtensions
    {
        public static IApplicationBuilder UseMySwagger(this IApplicationBuilder app)
        {
            app.UseSwagger();

            app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "TesteFlurl.API v1"));

            return app;
        }
    }
}
