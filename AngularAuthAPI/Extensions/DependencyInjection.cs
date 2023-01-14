using AngularAuthAPI.Commands;
using AngularAuthAPI.Commands.Interfaces;

namespace AngularAuthAPI.Extensions
{
    public static class DependencyInjection
    {
        public static void AddIoc(this IServiceCollection services)
        {
            services.AddScoped<ICommandResult, CommandResult>();
        }
    }
}
