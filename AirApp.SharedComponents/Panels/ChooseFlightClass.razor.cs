using AirApp.Data.Entities;
using Microsoft.AspNetCore.Components;

namespace AirApp.ComponentsShared.Panels;

public partial class ChooseFlightClass
{
    [Parameter] public Action<string> ParamChangeSitType { get; set; }
    [Parameter] public List<string> SitsTypes { get; set; }

    private string _sitsType = string.Empty;

    protected override async Task OnInitializedAsync()
    {
        await base.OnInitializedAsync();

        _sitsType = SitsTypes[0];
    }

    private void InvokeChangeSitType()
    {
        ParamChangeSitType?.Invoke(_sitsType);
        StateHasChanged();
    }
}