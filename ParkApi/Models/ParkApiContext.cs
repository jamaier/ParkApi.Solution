using Microsoft.EntityFrameworkCore;

namespace ParkApi.Models
{
  public class ParkApiContext : DbContext
  {
    public DbSet<Park> Parks { get; set; }

    public ParkApiContext(DbContextOptions<ParkApiContext> options) : base(options)
    {
    }

    protected override void
    OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Park>().HasData(
        new Park { ParkId = 1, Name = "Yellowstone", State = "Wyoming", Description = "PlaceHolder Text" },
        new Park { ParkId = 2, Name = "Yosemite", State = "California", Description = "PlaceHolder Text" },
        new Park { ParkId = 3, Name = "Grand Canyon", State = "Arizona", Description = "PlaceHolder Text" },
        new Park { ParkId = 4, Name = "Zion", State = "Utah", Description = "PlaceHolder Text" },
        new Park { ParkId = 5, Name = "Glacier", State = "Montana", Description = "PlaceHolder Text" },
        new Park { ParkId = 6, Name = "Olympic", State = "Washington", Description = "PlaceHolder Text" },
        new Park { ParkId = 7, Name = "Rocky Mountain", State = "Colorado", Description = "PlaceHolder Text" },
        new Park { ParkId = 8, Name = "Grand Teton", State = "Wyoming", Description = "PlaceHolder Text" },
        new Park { ParkId = 9, Name = "Acadia", State = "Maine", Description = "PlaceHolder Text" },
        new Park { ParkId = 10, Name = "Arches", State = "Utah", Description = "PlaceHolder Text" }
      );
    }
  }
}