using Microsoft.EntityFrameworkCore;

namespace TravelApi.Models
{
  public class TravelApiContext : DbContext
  {
    public TravelApiContext(DbContextOptions<TravelApiContext> options) : base(options)
    {
      // empty
    }

    public DbSet<Review> Reviews { get; set; }
    public DbSet<Destination> Destinations { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      var review1 = new Review { ReviewId = 1, UserName = "steve", Text = "abc", Score = 4, DestinationId = 1};
      var review2 = new Review { ReviewId = 2, UserName = "billy", Text = "def", Score = 1, DestinationId = 1};
      var review3 = new Review { ReviewId = 3, UserName = "steve", Text = "hjk", Score = 3, DestinationId = 1};
      var review4 = new Review { ReviewId = 4, UserName = "billy", Text = "nop", Score = 5, DestinationId = 4};
      var review5 = new Review { ReviewId = 5, UserName = "steve", Text = "qrs", Score = 2, DestinationId = 4};

      builder.Entity<Review>()
        .HasData(
            review1,
            review2,
            review3,
            review4,
            review5
        );
      builder.Entity<Destination>()
        .HasData(
            //new Destination { DestinationId = 1, Country = "usa", City = "chicago", Reviews = { review1, review2, review3 } },
            new Destination { DestinationId = 1, Country = "usa", City = "chicago" },
            new Destination { DestinationId = 2, Country = "usa", City = "new york" },
            new Destination { DestinationId = 3, Country = "mex", City = "juarez" },
            // new Destination { DestinationId = 4, Country = "mex", City = "mexico city", Reviews = { review4, review5 } },
            new Destination { DestinationId = 4, Country = "mex", City = "mexico city" },
            new Destination { DestinationId = 5, Country = "can", City = "alberta" }
        );
    }
  }
}

// gh repo create

// The seed entity for entity type 'Destination' cannot be added because it has the navigation 'Reviews' set. To seed relationships,  add the entity seed to 'Review' and specify the foreign key values {'DestinationId'}. Consider using 'DbContextOptionsBuilder.EnableSensitiveDataLogging' to see the involved property values.