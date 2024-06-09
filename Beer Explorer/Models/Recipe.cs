namespace BeerExplorer.Models
{
    public class Recipe
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public List<string> Ingredients { get; set; }
        public string Instructions { get; set; }
        public string ImagePath { get; set; }
        public List<BeerStyle> PairedBeers { get; set; }
    }
}
