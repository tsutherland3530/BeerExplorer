using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Beer_Explorer.Services;
using BeerExplorer.Models;
using BeerExplorer.Services;

namespace BeerExplorer.ViewModels
{
    public class BeerDetailViewModel : INotifyPropertyChanged
    {
        private BeerStyle _selectedBeerStyle;
        private ObservableCollection<Review> _reviews;
        private ObservableCollection<Recipe> _recipes;
        private readonly BeerService _beerService;
        private readonly UserService _userService;

        public BeerDetailViewModel(BeerService beerService, UserService userService)
        {
            _beerService = beerService;
            _userService = userService;
            _reviews = new ObservableCollection<Review>();
            _recipes = new ObservableCollection<Recipe>();
        }

        public BeerStyle SelectedBeerStyle
        {
            get => _selectedBeerStyle;
            set
            {
                _selectedBeerStyle = value;
                OnPropertyChanged();
                LoadReviews();
                LoadRecipes();
            }
        }

        public ObservableCollection<Review> Reviews
        {
            get => _reviews;
            set
            {
                _reviews = value;
                OnPropertyChanged();
            }
        }

        public ObservableCollection<Recipe> Recipes
        {
            get => _recipes;
            set
            {
                _recipes = value;
                OnPropertyChanged();
            }
        }

        private void LoadReviews()
        {
            Reviews.Clear();
            var reviews = _userService.GetReviewsForBeer(SelectedBeerStyle);
            foreach (var review in reviews)
            {
                Reviews.Add(review);
            }
        }

        private void LoadRecipes()
        {
            Recipes.Clear();
            foreach (var pairing in SelectedBeerStyle.FoodPairings)
            {
                foreach (var recipe in pairing.Recipes)
                {
                    Recipes.Add(recipe);
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
