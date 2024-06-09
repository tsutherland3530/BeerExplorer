using Beer_Explorer.Models;

namespace BeerExplorer.Models
{
    public class Review
    {
        public int Rating { get; set; }
        public string Comment { get; set; }
        public BeerStyle BeerStyle { get; set; }
        public User User { get; set; }
    }
}

