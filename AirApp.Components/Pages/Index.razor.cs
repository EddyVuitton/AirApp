using AirApp.Components.Helpers.Interfaces;
using AirApp.WebApi.Services;
using Microsoft.AspNetCore.Components;
using MudBlazor;

namespace AirApp.Components.Pages;

public partial class Index
{
    [Inject] public IApplicationService ApplicationService { get; set; }
    [Inject] public IErrorHelper ErrorHelper { get; set; }

    protected override async Task OnInitializedAsync()
    {
        await base.OnInitializedAsync();

        ErrorHelper.ShowSnackbar("Co tam", MudBlazor.Severity.Normal);
    }
}