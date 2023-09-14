//using AirApp.WebApi.Repositories;

namespace AirApp.WebApi.Services;

public static class IServiceCollectionWebApi
{
    public static IServiceCollection AddWebApi(this IServiceCollection services)
    {
        //services.AddScoped<IApplicationRepository, ApplicationRepository>();

        return services;
    }
}