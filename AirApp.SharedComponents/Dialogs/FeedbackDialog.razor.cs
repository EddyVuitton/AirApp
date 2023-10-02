using Microsoft.AspNetCore.Components;
using MudBlazor;

namespace AirApp.ComponentsShared.Dialogs;

public partial class FeedbackDialog
{
    [CascadingParameter] MudDialogInstance MudDialog { get; set; }

    void Close() => MudDialog.Close(DialogResult.Ok(true));
}