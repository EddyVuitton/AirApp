using AirApp.WebApi.Helpers;
using AirApp.WebApi.Repositories;

namespace AirApp.WebApi.Services;

public static class IServiceCollectionWebApi
{
    public static IServiceCollection AddWebApi(this IServiceCollection services)
    {
        services.AddScoped<IApplicationRepository, ApplicationRepository>();

        return services;
    }

    public static IServiceCollection InitializeLogger(this IServiceCollection services)
    {
        IConfiguration configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.Development.json")
            .AddJsonFile("appsettings.json")
            .Build();

        services.AddSingleton(configuration);
        Logger.Initialize(configuration);

        return services;
    }
}