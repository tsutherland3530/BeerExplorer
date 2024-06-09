namespace BeerExplorer.Models
{
    public class User
    {
        public string Username { get; set; }
        public List<BeerStyle> Favorites { get; set; }
        public List<Review> Reviews { get; set; }
    }
}
