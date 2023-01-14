using Microsoft.OpenApi.Models;

namespace AngularAuthAPI.Extensions
{
    public static class AddSwaggerConfigurationExtensions
    {
        public static void AddSwaggerConfig(this IServiceCollection services)
        {
            services.AddSwaggerGen(x =>
            {
                x.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "AngularAuthAPI",
                    Description = "Authentication Api",
                    Version = "v1",
                });
            });
        }
    }
}
