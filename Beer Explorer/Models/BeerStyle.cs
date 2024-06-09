using Beer_Explorer.Models;

namespace BeerExplorer.Models
{
    public class BeerStyle
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Origin { get; set; }
        public string TasteProfile { get; set; }
        public List<FoodPairing> FoodPairings { get; set; }
    }
}
