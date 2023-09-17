using AirApp.Data.Context;

namespace AirApp.WebApi.Repositories;

public class ApplicationRepository : IApplicationRepository
{
    private readonly DBContext _context;

    public ApplicationRepository(DBContext context)
    {
        _context = context;
    }

    public DateTime? Test()
    {
        var random = new Random().Next(1, 3);

        if (random == 1)
            throw new ApplicationException();

        return DateTime.Now;
    }
}