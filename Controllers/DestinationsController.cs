using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TravelApi.Models;

namespace TravelApi.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class DestinationsController : ControllerBase
  {
    private readonly TravelApiContext _db;
    public DestinationsController(TravelApiContext db)
    {
      _db = db;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Destination>>> Get(
        string country,
        string city,
        int revmin
      )
    {
      var query = _db.Destinations
        .Include(a => a.Reviews)
        .AsQueryable(); // => IQueryable

      System.Console.WriteLine("WHAT TYPE ARE YOU? {0}", query);

      var test = query.ToList();

      foreach (var x in test)
      {
        System.Console.WriteLine("SHIT: {0}", x.Reviews);
      }

      // How could we DRY this up? Would it be worth it to do so?
      if (country != null)
        query = query.Where(e => e.Country == country);
      if (city != null)
        query = query.Where(e => e.City == city);
       if (revmin > 0)
       {
        //  query = query.Where(e => e.Reviews)
        //   .Where(r => r.Score >= revmin);
        query = query.Select(d => d.Reviews)
          .Where(r => r.Score >= revmin);
       }

      return await query
        .ToListAsync();
    }
  }
}
