using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using BeerExplorer.Models;
using BeerExplorer.Services;

namespace BeerExplorer.ViewModels
{
    public class UserViewModel : INotifyPropertyChanged
    {
        private readonly UserService _userService;
        private User _currentUser;
        private ObservableCollection<BeerStyle> _favorites;
        private ObservableCollection<Review> _reviews;

        public UserViewModel(UserService userService)
        {
            _userService = userService;
            LoadUser("john_doe"); // Replace with actual user login in a real app
        }

        public User CurrentUser
        {
            get => _currentUser;
            set
            {
                _currentUser = value;
                OnPropertyChanged();
            }
        }

        public ObservableCollection<BeerStyle> Favorites
        {
            get => _favorites;
            set
            {
                _favorites = value;
                OnPropertyChanged();
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

        private void LoadUser(string username)
        {
            CurrentUser = _userService.GetUserByUsername(username);
            Favorites = new ObservableCollection<BeerStyle>(CurrentUser.Favorites);
            Reviews = new ObservableCollection<Review>(CurrentUser.Reviews);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
