using Microsoft.Extensions.DependencyInjection;

namespace BookMyCinema.Infrastructure.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddPersistance(this IServiceCollection services)
    {

        return services;
    }
}
