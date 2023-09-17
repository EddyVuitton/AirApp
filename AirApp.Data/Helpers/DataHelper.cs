using AirApp.Data.DTOs;
using Microsoft.EntityFrameworkCore;

namespace AirApp.Data.Helpers;

public static class DataHelper
{
    public static void AddEntities(this ModelBuilder modelBuilder)
    {

    }

    public static void AddDtos(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<DealDto>(entity =>
        {
            entity.HasNoKey();
        });
    }
}