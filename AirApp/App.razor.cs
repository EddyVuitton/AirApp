using AirApp.Components.Layout;
using System.Reflection;

namespace AirApp.Server;

public partial class App
{
    private readonly List<Assembly> _additionalAssemblies = new()
    {
        typeof(MainLayout).Assembly,
    };
}