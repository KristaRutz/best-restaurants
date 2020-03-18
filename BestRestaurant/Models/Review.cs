using System;

namespace BestRestaurant.Models
{
    public class Review{
        public string Comment {get; set;}
        public string Author {get; set;}
        public int ReviewId {get;set;}
        public int RestaurantId {get;set;}

        public DateTime Timestamp {get;set;}
        public virtual Restaurant Restaurant {get;set;}
        public int Rating { get; set;}
    }
}