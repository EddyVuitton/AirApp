using AirApp.Data.DTOs;
using Microsoft.AspNetCore.Components;

namespace AirApp.ComponentsShared.Shared;

public partial class PresentedInformation
{
    [Parameter] public InfoDto Info { get; set; }
}