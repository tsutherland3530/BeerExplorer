using System.Collections.Generic;
using BeerExplorer.Models;

namespace BeerExplorer.Services
{
    public class UserService
    {
        private List<User> _users;

        public UserService()
        {
            // Initialize with some sample data
            _users = new List<User>
            {
                new User { Username = "john_doe", Favorites = new List<BeerStyle>(), Reviews = new List<Review>() },
                new User { Username = "jane_smith", Favorites = new List<BeerStyle>(), Reviews = new List<Review>() }
            };
        }

        public User GetUserByUsername(string username)
        {
            return _users.Find(user => user.Username == username);
        }

        public void AddFavoriteBeer(string username, BeerStyle beerStyle)
        {
            var user = GetUserByUsername(username);
            if (user != null && !user.Favorites.Contains(beerStyle))
            {
                user.Favorites.Add(beerStyle);
            }
        }

        public void AddReview(string username, Review review)
        {
            var user = GetUserByUsername(username);
            if (user != null)
            {
                user.Reviews.Add(review);
            }
        }

        public List<Review> GetReviewsForBeer(BeerStyle beerStyle)
        {
            var reviews = new List<Review>();
            foreach (var user in _users)
            {
                reviews.AddRange(user.Reviews.FindAll(review => review.BeerStyle == beerStyle));
            }
            return reviews;
        }
    }
}
