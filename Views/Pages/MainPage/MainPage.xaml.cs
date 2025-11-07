using lab2.ViewModels;
using Microsoft.Maui.Controls;
using System;

namespace lab2
{
    public partial class MainPage : ContentPage
    {
        // Remove the isLiked field and the event handlers

        // Inject the ViewModel into the constructor
        public MainPage(MainPageViewModel viewModel)
        {
            InitializeComponent();

            // Set the BindingContext for the page
            BindingContext = viewModel;
        } 
    }
}