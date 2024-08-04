using BeerExplorer.Controllers;
using BeerExplorer.Data;
using BeerExplorer.Models;
using Microsoft.EntityFrameworkCore;
using Xunit;

namespace BeerExplorer.Tests
{
    public class BeerStyleTests
    {
        [Fact]
        public void CanAddBeerStyle()
        {
            var options = new DbContextOptionsBuilder<BeerContext>()
                .UseInMemoryDatabase(databaseName: "TestDatabase")
                .Options;

            using (var context = new BeerContext(options))
            {
                var controller = new BeerStylesController(context);
                var beerStyle = new BeerStyle
                {
                    Name = "Test IPA",
                    Description = "A test IPA beer.",
                    OriginStory = "Test Origin",
                    ABV = "6.5%"
                };

                controller.Create(beerStyle);

                Assert.Single(context.BeerStyles);
                Assert.Equal("Test IPA", context.BeerStyles.First().Name);
            }
        }

        // Add more unit tests as needed
    }
}
