using System.Collections.Generic;
using BeerExplorer.Models;

namespace BeerExplorer.Services
{
    public class BeerService
    {
        private List<BeerStyle> _beerStyles;

        public BeerService(DataService dataService)
        {
            _beerStyles = dataService.LoadBeerStyles();
        }

        public BeerStyle GetBeerStyleByName(string name)
        {
            return _beerStyles.Find(beer => beer.Name == name);
        }

        public IEnumerable<BeerStyle> GetAllBeerStyles()
        {
            return _beerStyles;
        }

        public IEnumerable<BeerStyle> SearchBeerStyles(string query)
        {
            if (string.IsNullOrEmpty(query))
                return _beerStyles;

            return _beerStyles.FindAll(beer => beer.Name.ToLower().Contains(query.ToLower()));
        }
    }
}
