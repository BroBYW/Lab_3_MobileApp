using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace lab2.ViewModels
{
    // Inherit from BaseViewModel
    public partial class MainPageViewModel : BaseViewModel
    {
        // Private state for the like button
        private bool _isLiked = false;

        // Observable Properties for the Like Button's state
        // The View will bind to these. When they change, the UI will
        // automatically update.
        [ObservableProperty]
        string likeButtonText = "♡";

        [ObservableProperty]
        Color likeButtonBackgroundColor = Colors.White;

        [ObservableProperty]
        Color likeButtonTextColor = Colors.Black;

        [ObservableProperty]
        Color likeButtonBorderColor = Colors.LightGray;

        public MainPageViewModel()
        {
            Title = "Pet Adoption"; // Set the title property from BaseViewModel
        }

        // This [RelayCommand] attribute turns the Like() method
        // into an ICommand property named "LikeCommand".
        [RelayCommand]
        private void Like()
        {
            _isLiked = !_isLiked;

            if (_isLiked)
            {
                // Update the observable properties. The UI will
                // change automatically.
                LikeButtonBackgroundColor = Colors.Red;
                LikeButtonTextColor = Colors.White;
                LikeButtonText = "♥"; // Filled heart
                LikeButtonBorderColor = Colors.Red;
            }
            else
            {
                LikeButtonBackgroundColor = Colors.White;
                LikeButtonTextColor = Colors.Black;
                LikeButtonText = "♡"; // Empty heart
                LikeButtonBorderColor = Colors.LightGray;
            }
        }

        // This turns the Adopt() method into an ICommand
        // named "AdoptCommand".
        [RelayCommand]
        private async Task Adopt()
        {
            // We can access the main page's DisplayAlert from anywhere
            // using Application.Current.MainPage
            if (Application.Current?.MainPage != null)
            {
                await Application.Current.MainPage.DisplayAlert("Success", "You have successfully adopted the dog", "OK");
            }
        }
    }
}