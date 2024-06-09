using Beer_Explorer.Models;

namespace BeerExplorer.Models
{
    public class FoodPairing
    {
        public string Food { get; set; }
        public string Reason { get; set; }
        public List<Recipe> Recipes { get; set; }
    }
}
