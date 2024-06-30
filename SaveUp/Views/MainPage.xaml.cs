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
	}

    private async void OnAddButtonClicked(object sender, EventArgs e)
    {
        // Annahme, dass "Eintragen" der erste Tab in deiner TabBar ist
        await Shell.Current.GoToAsync("//Eintragen");
    }

    private void OnItemTapped(object sender, EventArgs e)
    {
        var grid = sender as Grid;
        if (grid != null)
        {
            var item = grid.BindingContext as Item;
            if (item != null)
            {
                // Hier Code, um das Popup zu öffnen
                // Beispiel: Zeige Details im Popup oder navigiere zu einer Detailseite
                DisplayAlert("Produktinformation", $"Name: {item.Name}\nPreis: {item.Price:F2} CHF", "OK");
            }
        }
    }

}