using AirApp.Data.DTOs;

namespace AirApp.ComponentsShared.Panels;

public partial class Informations
{
    private List<InfoDto> _infos;

    protected override async Task OnInitializedAsync()
    {
        await base.OnInitializedAsync();
        LoadDefaultValues();
    }

    private void LoadDefaultValues()
    {
        _infos = new()
        {
            new InfoDto() { Header = "Air France Business Cabin", Span = "An exceptional journey guaranteed", ImagePath = "", Width = 550, Height = 386 },
            new InfoDto() { Header = "Premium Economy Offers", Span = "Take advantage of our offers to travel in a comfortable seat with more space and in a private cabin.", ImagePath = "", Width = 386, Height = 386 },
            new InfoDto() { Header = "A Masterpiece", Span = "Paris", ImagePath = "", Width = 386, Height = 386 },
            new InfoDto() { Header = "Air France Newsletter", Span = "Subscribe to our newsletter and receive the latest offers and informations.", ImagePath = "", Width = 550, Height = 386 }
        };
    }
}