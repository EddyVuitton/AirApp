namespace AirApp.WebApi.Helpers;

public static class Logger
{
    private static IConfiguration _configuration;

    public static void Initialize(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public static void LogError(Exception ex)
    {
        int threadId = Environment.CurrentManagedThreadId;
        string now = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff");

        string log = $"[{now}] [{threadId}] [Error] {ex.Message}\n{ex.StackTrace}\nSource: {ex.Source}";
        SaveLogToFile(log);
    }

    public static void LogInfo(string message)
    {
        int threadId = Environment.CurrentManagedThreadId;
        string now = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff");
        string log = $"[{now}] [{threadId}] [Info] {message}";
        SaveLogToFile(log);
    }

    private static void SaveLogToFile(string message)
    {
        var path = _configuration["LogPath:Path"];
        string now = DateTime.Now.ToString("yyyy-MM-dd");
        string filePath = $"{path}\\{now}.txt";

        using FileStream fileStream = new(filePath, FileMode.Append, FileAccess.Write);
        using StreamWriter writer = new(fileStream);
        writer.WriteLine(message);

        writer.Close();
        fileStream.Close();
    }
}