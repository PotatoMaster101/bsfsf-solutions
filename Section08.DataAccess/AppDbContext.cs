using Microsoft.EntityFrameworkCore;
using Section08.DataAccess.Dto;

namespace Section08.DataAccess;

public sealed class AppDbContext : DbContext
{
    public DbSet<UserDto> Users { get; set; } = default!;

    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
        ChangeTracker.AutoDetectChangesEnabled = false;
    }
}
