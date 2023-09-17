using AirApp.Data.DTOs;

namespace AirApp.ComponentsShared.Panels;

public partial class DestinationsAndDeals
{
    private List<DealDto> _deals;

    protected override async Task OnInitializedAsync()
    {
        await base.OnInitializedAsync();
        LoadDefaultValues();
    }

    private void LoadDefaultValues()
    {
        _deals = new()
        {
            new DealDto() { Capital = "Antananarivo", Country = "Madagascar", Currency = "PLN", Price = 4134.0m, FlightType = "Round trip"},
            new DealDto() { Capital = "Fort de France", Country = "Martinique", Currency = "PLN", Price = 3185.0m, FlightType = "Round trip"},
            new DealDto() { Capital = "Abidjan", Country = "Côte d’Ivoire", Currency = "PLN", Price = 3874.0m, FlightType = "Round trip"},
            new DealDto() { Capital = "Havana", Country = "Cuba", Currency = "PLN", Price = 2855.0m, FlightType = "Round trip"},
            new DealDto() { Capital = "St Martin", Country = "Saint Martin", Currency = "PLN", Price = 3369.0m, FlightType = "Round trip"}
        };
    }
}