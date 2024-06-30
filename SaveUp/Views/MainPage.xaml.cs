using SaveUp.ViewModels;
using SaveUp.Models;

namespace SaveUp.Views;

public partial class MainPage : ContentPage
{
	private readonly MainPageViewModel _viewModel;
	public MainPage(MainPageViewModel viewModel)
	{
		_viewModel = viewModel;
		InitializeComponent();
		BindingContext = _viewModel;

        MessagingCenter.Subscribe<PopupPage, Item>(this, "DeleteItem", (sender, item) =>
        {
            _viewModel.Items.Remove(item);
        });

        MessagingCenter.Subscribe<EntryViewModel, Item>(this, "AddNewItem", (sender, arg) =>
        {
            viewModel.Items.Add(arg);
            viewModel.CalculateTotal();
        });
    }

    private async void OnAddButtonClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//Eintragen");
    }

    private async void OnItemTapped(object sender, EventArgs e)
    {
        var grid = sender as Grid;
        if (grid != null)
        {
            var item = grid.BindingContext as Item;
            if (item != null)
            {
                await Navigation.PushModalAsync(new PopupPage(item));
            }
        }
    }
}