using BeerExplorer.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace BeerExplorer.Data
{
    public static class DbInitializer
    {
        public static void Initialize(BeerContext context)
        {
            context.Database.EnsureCreated();

            if (context.BeerStyles.Any())
            {
                return;
            }

            var beerStyles = new List<BeerStyle>
            {
                new BeerStyle
                {
                    Name = "American IPA",
                    Description = "A hoppy beer style within the broader category of pale ale.",
                    OriginStory = "United States",
                    ABV = "7.0%",
                    FoodPairings = new List<FoodPairing>
                    {
                        new FoodPairing { Food = "Spicy Tacos", Description = "The bitterness of the IPA cuts through the spiciness." }
                    }
                },
                new BeerStyle
                {
                    Name = "Imperial IPA",
                    Description = "A stronger, hoppier version of an IPA.",
                    OriginStory = "United States",
                    ABV = "8.0%",
                    FoodPairings = new List<FoodPairing>
                    {
                        new FoodPairing { Food = "Spicy Curry", Description = "The intense hop bitterness complements the bold flavors of curry." }
                    }
                },
                new BeerStyle
                {
                    Name = "New England IPA",
                    Description = "A hazy, juicy IPA with low bitterness.",
                    OriginStory = "United States",
                    ABV = "6.5%",
                    FoodPairings = new List<FoodPairing>
                    {
                        new FoodPairing { Food = "Fish Tacos", Description = "The citrusy hop flavors complement the fresh flavors of fish tacos." }
                    }
                },
                new BeerStyle
                {
                    Name = "Brut IPA",
                    Description = "A dry, highly carbonated version of an IPA.",
                    OriginStory = "United States",
                    ABV = "6.5%",
                    FoodPairings = new List<FoodPairing>
                    {
                        new FoodPairing { Food = "Sushi", Description = "The dryness and effervescence complement the delicate flavors of sushi." }
                    }
                },
                new BeerStyle
                {
                    Name = "Belgian IPA",
                    Description = "Combines the hoppy character of an IPA with the fruity, spicy flavors of Belgian yeast.",
                    OriginStory = "Belgium",
                    ABV = "6.8%",
                    FoodPairings = new List<FoodPairing>
                    {
                        new FoodPairing { Food = "Mussels", Description = "The yeast character of the IPA complements the briny mussels." }
                    }
                },
                new BeerStyle
                {
                    Name = "Black IPA",
                    Description = "A dark beer with the hop-forward character of an IPA.",
                    OriginStory = "United States",
                    ABV = "7.5%",
                    FoodPairings = new List<FoodPairing>
                    {
                        new FoodPairing { Food = "Grilled Steak", Description = "The roasted malt and hop bitterness pair well with a juicy steak." }
                    }
                },
                new BeerStyle
                {
                    Name = "Session IPA",
                    Description = "A lower-alcohol, more sessionable version of an IPA.",
                    OriginStory = "United States",
                    ABV = "4.5%",
                    FoodPairings = new List<FoodPairing>
                    {
                        new FoodPairing { Food = "Light Salads", Description = "The lower ABV and hoppy character complement light salads." }
                    }
                },
                new BeerStyle
                {
                    Name = "West Coast IPA",
                    Description = "An IPA with a clear appearance and a strong hop bitterness.",
                    OriginStory = "United States",
                    ABV = "7.0%",
                    FoodPairings = new List<FoodPairing>
                    {
                        new FoodPairing { Food = "Grilled Chicken", Description = "The strong hop bitterness complements the flavors of grilled chicken." }
                    }
                },
                new BeerStyle
                {
                    Name = "Double IPA",
                    Description = "A stronger, hoppier version of an IPA, also known as Imperial IPA.",
                    OriginStory = "United States",
                    ABV = "8.5%",
                    FoodPairings = new List<FoodPairing>
                    {
                        new FoodPairing { Food = "Spicy Wings", Description = "The intense hop bitterness and higher ABV complement spicy wings." }
                    }
                },
                new BeerStyle
                {
                    Name = "Milkshake IPA",
                    Description = "A hazy IPA brewed with lactose to give it a creamy texture.",
                    OriginStory = "United States",
                    ABV = "6.0%",
                    FoodPairings = new List<FoodPairing>
                    {
                        new FoodPairing { Food = "Fruit Tart", Description = "The fruity flavors of the IPA pair well with the sweetness of the tart." }
                    }
                }
            };

            context.BeerStyles.AddRange(beerStyles);
            context.SaveChanges();
        }
    }
}
