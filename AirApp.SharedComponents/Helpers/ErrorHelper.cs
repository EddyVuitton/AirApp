﻿using AirApp.Components.Helpers.Interfaces;
using Microsoft.AspNetCore.Components;
using MudBlazor;

namespace AirApp.Components.Helpers;

public class ErrorHelper : IErrorHelper
{
    [Inject] public ISnackbar Snackbar { get; set; }

    public ErrorHelper(ISnackbar snackbar)
    {
        Snackbar = snackbar;
        Snackbar.Configuration.PreventDuplicates = false;
        Snackbar.Configuration.RequireInteraction = true;
        Snackbar.Configuration.HideTransitionDuration = 500;
    }

    public void ShowSnackbar(string message, Severity s)
    {
        var now = DateTime.Now;

        Snackbar.Add($"[{now:yyyy-MM-dd HH:mm:ss}] {message}", s);
    }
}