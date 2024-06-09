using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using BeerExplorer.Models;

namespace BeerExplorer.Services
{
    public class DataService
    {
        private readonly string _dataPath = "Data/data.json"; // Update the path as needed

        public List<BeerStyle> LoadBeerStyles()
        {
            var jsonData = File.ReadAllText(_dataPath);
            return JsonConvert.DeserializeObject<List<BeerStyle>>(jsonData);
        }
    }
}


