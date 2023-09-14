namespace AirApp.Data.Entities;

public class MultiFlight
{
    private readonly int _id;

    public string DepartureAirport { get; set; }
    public string ArriveAirport { get; set; }
    public DateTime? TravelDate { get; set; }
    public int Lp { get; set; }

    public MultiFlight(ref List<MultiFlight> multiFlights)
    {
        _id = multiFlights is null ? 1 : multiFlights.Count == 0 ? 1 : multiFlights.Max(x => x._id) + 1;
    }

    public int GetId() => _id;
}