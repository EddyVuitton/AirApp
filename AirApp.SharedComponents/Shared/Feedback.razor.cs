using AirApp.ComponentsShared.Dialogs;
using Microsoft.AspNetCore.Components;
using MudBlazor;

namespace AirApp.ComponentsShared.Shared;

public partial class Feedback
{
    [Inject] public IDialogService DialogService { get; set; }

    private void OpenDialog()
    {
        var options = new DialogOptions { 
            CloseOnEscapeKey = true,
            NoHeader = true
        };
        DialogService.Show<FeedbackDialog>(string.Empty, options);
    }
}