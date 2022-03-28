using System.Text.Json.Serialization;

namespace TravelApi.Models
{
  public class Review
  {
    // Primary Key
    public int ReviewId { get; set; }

    // String to verify a user is allowed to edit/delete a review, also required
    // for review creation
    public string UserName { get; set; }
    public string Text { get; set; }
    public int Score { get; set; }

    // Foreign key pointing back to destination, cannot create reviews without
    // a destination
    public int DestinationId { get; set; }
    [JsonIgnore]
    public virtual Destination Destination { get; set; }
  }
}

/*
[
    {
        "destinationId": 1,
        "country": "usa",
        "city": "chicago",
        "reviews": [
            {
                "reviewId": 1,
                "userName": "steve",
                "text": "abc",
                "score": 4,
                "destinationId": 1
            },
            {
                "reviewId": 2,
                "userName": "billy",
                "text": "def",
                "score": 1,
                "destinationId": 1
            },
            {
                "reviewId": 3,
                "userName": "steve",
                "text": "hjk",
                "score": 3,
                "destinationId": 1
            }
        ]
    },
    {
        "destinationId": 2,
        "country": "usa",
        "city": "new york",
        "reviews": []
    }
]
*/