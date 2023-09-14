using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using MudBlazor;

namespace AirApp.Components.Layout;

public partial class MainLayout
{
    [Inject] public NavigationManager NavigationManager { get; set; }
    [Inject] public IJSRuntime JS { get; set; }

    private readonly List<MyButton> _buttons = new();

    private bool _drawerOpen = false;
    private bool _arrow = false;
    private string _arrowIcon = Icons.Material.Filled.KeyboardArrowDown;
    private readonly string _logoImagePath = @"/files/Air_France_Logo.png";

    protected override async Task OnInitializedAsync()
    {
        await base.OnInitializedAsync();

        _buttons.Add(new MyButton("Book a flight", NavigationManager, "/"));
        _buttons.Add(new MyButton("Check-in", NavigationManager, "/check-in"));
        _buttons.Add(new MyButton("My bookings", NavigationManager, "/trip"));
        _buttons.Add(new MyButton("Information", NavigationManager, "/information"));
        _buttons.Add(new MyButton("Covid-19", NavigationManager, "/information/covid-19", "font-weight: bold;"));
    }

    private void NavToIndex()
    {
        NavigationManager.NavigateTo($"/", true);
        StateHasChanged();
    }

    private void NavToPage(string page)
    {
        NavigationManager.NavigateTo($"{page}", true);
        StateHasChanged();
    }

    private void OpenDrawer()
    {
        //_drawerOpen = !_drawerOpen;
    }

    private void ChangeArrow()
    {
        if (_arrow)
        { 
            _arrow = false;
            _arrowIcon = Icons.Material.Filled.KeyboardArrowDown;
        }
        else
        {
            _arrow = true;
            _arrowIcon = Icons.Material.Filled.KeyboardArrowUp;
        }
    }
}

public class MyButton
{
    private readonly string _borderClass = "border-b-4 border-solid mud-border-primary";
    private readonly string _borderlessClass = "border-b-0 border-solid mud-border-primary";

    public string Class;
    public string Style;
    public bool DisableElevation;
    public Color Color;
    public string Name;
    public string Link;
    public string Page;

    public MyButton(string name, NavigationManager navigationManager, string page, string style = "")
    {
        DisableElevation = false;
        Color = Color.Inherit;
        Name = name;
        Page = page;
        Style = "padding-left: 15px; height: 60px; font-size: 20px; text-transform:none; " + style;

        bool b = navigationManager.Uri.EndsWith(page);

        Class = b ? _borderClass : _borderlessClass;
    }
}