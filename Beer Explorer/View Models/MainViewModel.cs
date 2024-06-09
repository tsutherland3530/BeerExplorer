using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using BeerExplorer.Models;
using BeerExplorer.Services;

namespace BeerExplorer.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private string _searchQuery;
        private ObservableCollection<BeerStyle> _beerStyles;
        private readonly BeerService _beerService;

        public MainViewModel()
        {
            var dataService = new DataService(); // Instantiate DataService
            _beerService = new BeerService(dataService); // Pass DataService to BeerService
            SearchCommand = new RelayCommand(SearchBeers);
            _beerStyles = new ObservableCollection<BeerStyle>(_beerService.GetAllBeerStyles());
        }

        public string SearchQuery
        {
            get => _searchQuery;
            set
            {
                _searchQuery = value;
                OnPropertyChanged();
            }
        }

        public ObservableCollection<BeerStyle> BeerStyles
        {
            get => _beerStyles;
            set
            {
                _beerStyles = value;
                OnPropertyChanged();
            }
        }

        public ICommand SearchCommand { get; }

        private void SearchBeers()
        {
            var results = _beerService.SearchBeerStyles(SearchQuery);
            BeerStyles.Clear();
            foreach (var beer in results)
            {
                BeerStyles.Add(beer);
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
