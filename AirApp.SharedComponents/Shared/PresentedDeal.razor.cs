using AirApp.Data.DTOs;
using Microsoft.AspNetCore.Components;

namespace AirApp.ComponentsShared.Shared;

public partial class PresentedDeal
{
    [Parameter] public DealDto Deal { get; set; }
}