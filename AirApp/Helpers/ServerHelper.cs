using AirApp.Server.Services;
using MudBlazor.Services;

namespace AirApp.Server.Helpers
{
    public static class ServerHelper
    {
        public static void AddServices(this WebApplicationBuilder builder)
        {
            builder.Services.AddRazorPages();
            builder.Services.AddServerSideBlazor();
            builder.Services.AddMudServices();
            builder.Services.AddDebcior();
        }

        public static string GetFilesDirectory()
        {
            var solutionDirectory = GetSolutionDirectory();

            string[] files = Directory.GetDirectories(solutionDirectory, "*", SearchOption.AllDirectories);
            return files.FirstOrDefault(x => x.Contains(@"AirApp\Files"));
        }

        private static string GetSolutionDirectory()
        {
            DirectoryInfo currentDirectory = new(Directory.GetCurrentDirectory());

            while (currentDirectory is not null && !currentDirectory.GetFiles("*.sln").Any())
            {
                currentDirectory = currentDirectory.Parent;
            }

            return currentDirectory?.FullName;
        }
    }
}