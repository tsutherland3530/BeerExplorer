using System.Collections.Generic;
using BeerExplorer.Models;

namespace BeerExplorer.Services
{
    public class RecipeService
    {
        private List<Recipe> _recipes;

        public RecipeService()
        {
            // Initialize with some sample data
            _recipes = new List<Recipe>
            {
                new Recipe
                {
                    Name = "Spicy Chicken Wings",
                    Description = "Perfectly spicy chicken wings.",
                    Ingredients = new List<string> { "Chicken wings", "Hot sauce", "Butter" },
                    Instructions = "Mix ingredients and bake.",
                    ImagePath = "path/to/image",
                    PairedBeers = new List<BeerStyle> { /* Add relevant BeerStyles */ }
                },
                new Recipe
                {
                    Name = "Chocolate Cake",
                    Description = "Rich and moist chocolate cake.",
                    Ingredients = new List<string> { "Flour", "Sugar", "Cocoa powder", "Eggs", "Butter" },
                    Instructions = "Mix ingredients and bake.",
                    ImagePath = "path/to/image",
                    PairedBeers = new List<BeerStyle> { /* Add relevant BeerStyles */ }
                }
            };
        }

        public IEnumerable<Recipe> GetRecipesForBeer(BeerStyle beerStyle)
        {
            var recipes = new List<Recipe>();
            foreach (var recipe in _recipes)
            {
                if (recipe.PairedBeers.Contains(beerStyle))
                {
                    recipes.Add(recipe);
                }
            }
            return recipes;
        }
    }
}
