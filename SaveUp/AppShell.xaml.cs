﻿namespace SaveUp
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await Shell.Current.GoToAsync("//Start");
        }

    }
}
