using AirApp.Data.Entities;
using MudBlazor;

namespace AirApp.ComponentsShared.Panels;

public partial class ChooseFlightType
{
    private List<string> _flightTypes;
    private List<string> _sitsTypes;
    private List<Passenger> _passengers;
    private List<PassengerAge> _passengerAges;
    private List<MultiFlight> _multiFligts;

    private readonly string[] _departureAirports =
    {
        "Gdansk, Lech Walesa Airport",
        "Krakow, John Paul II International Airport",
        "Warsaw, Frederic Chopin"
    };
    private readonly string[] _arriveAirports =
    {
        "Punta Cana, Punta Cana International Airport",
        "Lisbon, Humberto Delgado Airport",
        "Cancun, Cancun International airport"
    };
    private readonly string[] _tabs = { string.Empty, string.Empty };

    private readonly string _flyingBlueLogo = @"/files/flyingblue.jpg";
    private readonly string _activedTabStyle = "color: #051039; background-color: white;";
    private readonly string _deactivatedTabStyle = "color: white; background-color: #051039;";

    private string _flightType;
    private string _sitsType;
    private string _departureValue;
    private string _arriveValue;
    private string _popupTitle;
    private string _popupButtonTitle;

    private readonly DateTime _dateRangeMin = DateTime.Now.AddDays(-1);
    private readonly DateTime _dateRangeMax = new(2024, 12, 31);
    private DateTime? _travelDate;
    private DateRange _travelDates;

    private bool _isOpen = false;
    private bool _isBluebizCorpateContract = false;
    private bool _showAddNewFlightsButton = true;
    private bool _onlyFlexFales = false;

    private readonly int _onInitFlights = 2;
    private readonly int _limitOfFlights = 4;

    protected override async Task OnInitializedAsync()
    {
        await base.OnInitializedAsync();

        LoadDefaultValues();
        ChangeTabsStyle(0);
    }

    protected override async Task OnAfterRenderAsync(bool isFirstRender)
    {
        await base.OnAfterRenderAsync(isFirstRender);

        if (isFirstRender)
        {

        }
    }

    public void OpenPopup()
    {
        _isOpen = !_isOpen;

        //UpdateTitles();
        StateHasChanged();
    }

    public void UpdateTitles(string arg1, string arg2)
    {
        _popupTitle = arg1;
        _popupButtonTitle = arg2;
    }

    private void OnChooseFligthType(string e)
    {
        LoadDefaultValues();
        _flightType = e;
    }

    private void OnChooseFligthClassType(string e)
    {
        _sitsType = e;
    }

    private static IEnumerable<string> Search(string[] airports, string value)
    {
        return airports.Where(x => x.Contains(value, StringComparison.InvariantCultureIgnoreCase));
    }

    private async Task<IEnumerable<string>> DepartureSearch(string value)
    {
        await Task.Delay(5);

        // if text is null or empty, show complete list
        if (string.IsNullOrEmpty(value))
            return _departureAirports;

        return Search(_departureAirports, value);
    }

    private async Task<IEnumerable<string>> ArriveSearch(string value)
    {
        await Task.Delay(5);

        // if text is null or empty, show complete list
        if (string.IsNullOrEmpty(value))
            return _arriveAirports;

        return Search(_arriveAirports, value);
    }

    private void OnTabChange(int id)
    {
        ChangeTabsStyle(id);
    }

    private void ChangeTabsStyle(int id)
    {
        for (int i = 0; i < _tabs.Length; i++)
        {
            if (i == id)
                _tabs[i] = _activedTabStyle;
            else
                _tabs[i] = _deactivatedTabStyle;
        }
    }

    private void LoadDefaultValues()
    {
        _popupTitle = "Passengers (1)";
        _popupButtonTitle = "1 Adult";

        _flightTypes = new List<string>
        {
            "Round trip",
            "One-way",
            "Multicity"
        };
        _sitsTypes = new List<string>
        {
            "ECONOMY",
            "PREMIUM ECONOMY",
            "BUSINESS",
            "LA PREMIÉRE"
        };
        _multiFligts = new();

        for (var i = 0; i < _onInitFlights; i++)
            _multiFligts.Add(new MultiFlight(ref _multiFligts));

        _flightType = _flightTypes[0];
        _sitsType = _sitsTypes[0];

        _passengerAges = new()
        {
            new PassengerAge(1, "Infant (0 - 23 months)"),
            new PassengerAge(2, "Child (2 - 11 years)"),
            new PassengerAge(3, "Youth (12 - 17 years)"),
            new PassengerAge(4, "Youth (18 - 24 years)"),
            new PassengerAge(5, "Student (18 - 29 years)"),
            new PassengerAge(6, "Adult"),
            new PassengerAge(7, "Senior (65 years and Older)"),
        };
        _passengers = new()
        {
            new Passenger("Passenger", _passengerAges.FirstOrDefault(x => x.GetName() == "Adult") , ref _passengers)
        };

        _travelDate = null;
        _travelDates = new();

        _departureValue = string.Empty;
        _arriveValue = string.Empty;
    }

    private void AddNewMultiFlight()
    {
        _multiFligts.Add(new MultiFlight(ref _multiFligts));

        if (_multiFligts.Count == _limitOfFlights)
            _showAddNewFlightsButton = false;
    }

    private void DeleteMultiFlight(int id)
    {
        var flight = _multiFligts.First(x => x.GetId() == id);

        if (flight is not null)
            _multiFligts.Remove(flight);

        if (_multiFligts.Count > _onInitFlights)
            _showAddNewFlightsButton = true;
    }
}