using AirApp.Data.Context;
using AirApp.WebApi.Services;

namespace AirApp.WebApi.Helpers;

public static class WebApiHelper
{
    public static void AddServices(this WebApplicationBuilder builder)
    {
        builder.Services.AddControllers();
        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        builder.Services.AddWebApi();
        builder.Services.AddSqlServer<DBContext>(builder.Configuration.GetConnectionString("DefaultConnection"));
    }
}