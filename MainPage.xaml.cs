using Microsoft.Maui.Controls;
using System;

namespace lab2
{
    public partial class MainPage : ContentPage
    {
        // This variable is for your Like button
        bool isLiked = false;

        public MainPage()
        {
            InitializeComponent();
        }

        // This is your existing method for the Like button
        private void OnLikeClicked(object? sender, EventArgs e)
        {
            isLiked = !isLiked;

            if (isLiked)
            {
                LikeBtn.BackgroundColor = Colors.Red;
                LikeBtn.TextColor = Colors.White;
                LikeBtn.Text = "♥"; // Filled heart
                LikeBtn.BorderColor = Colors.Red;
            }
            else
            {
                LikeBtn.BackgroundColor = Colors.White;
                LikeBtn.TextColor = Colors.Black;
                LikeBtn.Text = "♡"; // Empty heart
                LikeBtn.BorderColor = Colors.LightGray;
            }
        }

        // 
        // ADD THIS NEW METHOD FOR THE ADOPTION BUTTON
        //
        private async void OnAdoptionClicked(object? sender, EventArgs e)
        {
            // This line displays the pop-up message
            await DisplayAlert("Success", "You have successfully adopted the dog", "OK");
        }
    }
}