using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using BestRestaurant.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;

namespace BestRestaurant.Controllers
{
  public class ReviewsController : Controller
  {
    private readonly BestRestaurantContext _db;

    public ReviewsController(BestRestaurantContext db)
    {
      _db = db;
    }

    public ActionResult Create(int restaurantId)
    {
			Restaurant thisRestaurant = _db.Restaurants.FirstOrDefault(restaurants => restaurants.RestaurantId == restaurantId);
      Console.WriteLine(restaurantId);
			ViewBag.RestaurantId = restaurantId;
      return View();
    }

    [HttpPost]
    public ActionResult Create(Review review)
    {
      _db.Reviews.Add(review);
      _db.SaveChanges();
      return RedirectToAction("Details", "Restaurants", new { id = review.RestaurantId});
    }

    public ActionResult Edit(int id)
    {
      return View();
    }

    [HttpPost]
    public ActionResult Edit(Review review)
    {
      return View();
    }

    public ActionResult Delete(int id)
    {
        var thisReview = _db.Reviews.FirstOrDefault(reviews => reviews.ReviewId == id);
      return View();
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
      var thisReview = _db.Reviews.FirstOrDefault(reviews => reviews.ReviewId == id);
      _db.Reviews.Remove(thisReview);
      _db.SaveChanges();
      return RedirectToAction("Details", "Restaurants", new {id = thisReview.RestaurantId});
    }
  }
}