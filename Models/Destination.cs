using System.Collections.Generic;

namespace TravelApi.Models
{
  public class Destination
  {
    public Destination()
    {
      this.Reviews = new HashSet<Review>();
    }
    public int DestinationId { get; set; }

    public string Country { get; set; }
    public string City { get; set; }
    // Everytime a review is added determine new review average.
    // EX: We have 5 reviews with a total average of 4.
    //     We add new review for a total of 6 reviews, which changes out average
    //     to 3.  We delete that last review, and our total reviews are now 5
    //     and our average goes back to 4.
    // public int ReviewAverage { get; set; }

    public virtual ICollection<Review> Reviews { get; set; }
  }
}
