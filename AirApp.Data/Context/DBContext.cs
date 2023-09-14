using AirApp.Data.DTOs;
using AirApp.Data.Helpers;
using Microsoft.EntityFrameworkCore;

namespace AirApp.Data.Context;

public partial class DBContext : DbContext
{
    public DBContext(DbContextOptions<DBContext> options) : base(options) { }

    public virtual DbSet<TestModelDto> test_model_dto { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        DataHelper.AddEntities(modelBuilder);
        DataHelper.AddDtos(modelBuilder);

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}