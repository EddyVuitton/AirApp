namespace AirApp.Components.Pages;

public partial class BookFlight
{
    private readonly bool _loading = false;
    private readonly string _backgroundImagePath = @"/files/1440x600_bw_hp_carousel3.jpg";

    protected override async Task OnInitializedAsync()
    {
        await base.OnInitializedAsync();
    }

    protected override async Task OnAfterRenderAsync(bool isFirstRender)
    {
        await base.OnAfterRenderAsync(isFirstRender);

        if (isFirstRender)
        {

        }
    }
}