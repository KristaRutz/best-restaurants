using System.Collections.Generic;

namespace BestRestaurant.Models
{
  public class Restaurant
  {
    public int RestaurantId { get; set; }
    public string Name { get; set; }
    public int CuisineId { get; set; }
    public virtual Cuisine Cuisine { get; set; }

    public virtual ICollection<Review> Reviews { get; set; }

    public Restaurant()
    {
      this.Reviews = new HashSet<Review>();
    }
  }
}