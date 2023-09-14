using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace AirApp.WebApi.Services;

public class ApplicationService : IApplicationService
{
    private readonly HttpClient _httpClient;
    private const string _URL = "api/main";

    public ApplicationService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }
}