using AirApp.Data.Entities;
using Microsoft.AspNetCore.Components;

namespace AirApp.ComponentsShared.Popups;

public partial class AddPassengers
{
    [Parameter] public Action ParamOpenPopup { get; set; }
    [Parameter] public Action<string, string> ParamUpdateTitles { get; set; }
    [Parameter] public List<Passenger> Passengers { get; set; }
    [Parameter] public List<PassengerAge> PassengersAges { get; set; }
    [Parameter] public string PopupTitle { get; set; }
    [Parameter] public string PopupButtonTitle { get; set; }

    private bool _isDeletePassDisabled;
    private bool _isAddPassDisabled;
    private readonly int _maxPassCount = 9;

    protected override async Task OnInitializedAsync()
    {
        await base.OnInitializedAsync();

        _isDeletePassDisabled = !(Passengers.Count > 1);
        _isAddPassDisabled = false;

        UpdateTitles();
    }

    private void InvokePopupOpen()
    {
        ParamOpenPopup?.Invoke();
    }

    private void InvokeUpdateTitles()
    {
        ParamUpdateTitles?.Invoke(PopupTitle, PopupButtonTitle);
    }

    private void AddPassenger()
    {
        var temp = Passengers;

        Passengers.Add(new Passenger("Passenger", PassengersAges.FirstOrDefault(x => x.GetName() == "Adult"), ref temp));

        if (Passengers.Count > 1 && _isDeletePassDisabled)
            _isDeletePassDisabled = false;

        if (Passengers.Count == _maxPassCount)
            _isAddPassDisabled = true;

        UpdateTitles();
    }

    private void DeletePassenger(int id)
    {
        var passenger = Passengers.Find(x => x.GetId() == id);

        if (passenger is not null)
            Passengers.Remove(passenger);

        if (Passengers.Count == 1)
            _isDeletePassDisabled = true;

        if (Passengers.Count < _maxPassCount)
            _isAddPassDisabled = false;

        UpdateTitles();
    }

    private void OnAgeChange(ChangeEventArgs e, Passenger passenger)
    {
        var selectedString = e.Value;
        var passengerAge = PassengersAges.FirstOrDefault(x => x.GetName() == selectedString.ToString());

        Passengers.FirstOrDefault(x => x.GetId() == passenger.GetId()).ChangeAge(passengerAge);
        UpdateTitles();
    }

    private void UpdateTitles()
    {
        var passengerCount = Passengers.Count;
        var isAllAdults = Passengers.All(x => x.GetPassengerAge().GetName() == "Adult");
        var isMoreThanOne = passengerCount > 1;

        PopupTitle = $"Passengers ({Passengers.Count})";
        PopupButtonTitle = $"{passengerCount} {(isAllAdults ? "adult" : "passenger")}{(isMoreThanOne ? "s" : string.Empty)}";

        InvokeUpdateTitles();
        StateHasChanged();
    }
}