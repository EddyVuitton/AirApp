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
            new InfoDto() { Header = "Air France Business Cabin", Span = "An exceptional journey guaranteed", ImagePath = "https://img.static-af.com/images/media/66F81E07-4F35-4D6F-813746E36CF46425/?w=560&h=280", Width = 550, Height = 386 },
            new InfoDto() { Header = "Premium Economy Offers", Span = "Take advantage of our offers to travel in a comfortable seat with more space and in a private cabin.", ImagePath = "https://img.static-af.com/images/media/668C9D23-A9FC-4252-9F9C65ED9A5E0E0D/source/hp-blueweb-1440x600?w=560&h=280", Width = 386, Height = 386 },
            new InfoDto() { Header = "A Masterpiece", Span = "Paris", ImagePath = "https://img.static-af.com/images/media/3082F417-31A6-4EDC-A6B39BBDADB577A4/?w=560&h=280", Width = 386, Height = 386 },
            new InfoDto() { Header = "Air France Newsletter", Span = "Subscribe to our newsletter and receive the latest offers and informations.", ImagePath = "https://img.static-af.com/images/media/244C48C2-6544-43E1-A0C4288DED9FF12A/?w=560&h=280", Width = 550, Height = 386 }
        };
    }
}