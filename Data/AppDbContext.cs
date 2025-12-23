using Microsoft.EntityFrameworkCore;
using GameHubMVC.Models;

namespace GameHubMVC.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public DbSet<GameCharacter> GameCharacters { get; set; }
}