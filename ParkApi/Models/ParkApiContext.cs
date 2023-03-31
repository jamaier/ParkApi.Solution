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
        new Park { ParkId = 1, Name = "Yellowstone", State = "Wyoming", Description = "A national park in Wyoming known for its geysers, hot springs, and wildlife." },
        new Park { ParkId = 2, Name = "Yosemite", State = "California", Description = "A national park in California known for its waterfalls, giant sequoia groves, and wildlife." },
        new Park { ParkId = 3, Name = "Grand Canyon", State = "Arizona", Description = "A national park in Arizona known for its steep canyon walls, desert landscape, and wildlife." },
        new Park { ParkId = 4, Name = "Zion", State = "Utah", Description = "A national park in Utah known for its red sandstone cliffs, canyons, and hiking trails." },
        new Park { ParkId = 5, Name = "Glacier", State = "Montana", Description = "A national park in Montana known for its rugged mountains, alpine lakes, and abundant wildlife." },
        new Park { ParkId = 6, Name = "Olympic", State = "Washington", Description = "A national park in Washington known for its rainforests, mountains, and beaches." },
        new Park { ParkId = 7, Name = "Rocky Mountain", State = "Colorado", Description = "A national park in Colorado known for its rugged mountains, alpine lakes, and abundant wildlife." },
        new Park { ParkId = 8, Name = "Grand Teton", State = "Wyoming", Description = "A national park in Wyoming known for its rugged mountains, alpine lakes, and abundant wildlife." },
        new Park { ParkId = 9, Name = "Acadia", State = "Maine", Description = "A national park in Maine known for its rugged mountains, alpine lakes, and abundant wildlife." },
        new Park { ParkId = 10, Name = "Arches", State = "Utah", Description = "A national park in Utah known for its rugged mountains, alpine lakes, and abundant wildlife." },
        new Park { ParkId = 11, Name = "Crater Lake", State = "Oregon", Description = "A caldera lake in Oregon known for its deep blue color and water clarity." },
        new Park { ParkId = 12, Name = "Mount Rainier", State = "Washington", Description = "A volcano in Washington known for its snow-capped peak and hiking trails." },
        new Park { ParkId = 13, Name = "Redwood", State = "California", Description = "A national park in California known for its old-growth coast redwood forests." },
        new Park { ParkId = 14, Name = "Badlands", State = "South Dakota", Description = "A national park in South Dakota known for its rugged mountains, alpine lakes, and abundant wildlife." },
        new Park { ParkId = 15, Name = "Big Bend", State = "Texas", Description = "A national park in Texas known for its rugged mountains, alpine lakes, and abundant wildlife." }
      );
    }
  }
}