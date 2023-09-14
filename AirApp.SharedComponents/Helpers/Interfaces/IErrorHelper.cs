using MudBlazor;

namespace AirApp.Components.Helpers.Interfaces;

public interface IErrorHelper
{
    void ShowSnackbar(string message, Severity s);
}