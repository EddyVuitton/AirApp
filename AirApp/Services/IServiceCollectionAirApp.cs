using AirApp.Components.Helpers;
using AirApp.Components.Helpers.Interfaces;
using AirApp.WebApi.Services;

namespace AirApp.Server.Services;

public static class IServiceCollectionAirApp
{
    public static IServiceCollection AddDebcior(this IServiceCollection services)
    {
        services.AddHttpClient<IApplicationService, ApplicationService>(client =>
        {
            client.BaseAddress = new Uri("https://localhost:44304/");
        });
        
        services.AddScoped<IErrorHelper, ErrorHelper>();


        return services;
    }
}