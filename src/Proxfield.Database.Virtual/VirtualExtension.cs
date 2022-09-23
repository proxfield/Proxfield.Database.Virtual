using Microsoft.Extensions.DependencyInjection;

namespace Proxfield.Database.Virtual
{
    public static class VirtualExtension
    {
        public static IServiceCollection AddVirtualDatabase(this IServiceCollection services)
        {

            return services;
        }
    }
}
