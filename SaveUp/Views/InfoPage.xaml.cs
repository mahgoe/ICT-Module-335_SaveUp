using SaveUp.ViewModels;

namespace SaveUp.Views;

public partial class InfoPage : ContentPage
{
    public InfoPage()
    {
        InitializeComponent();
        BindingContext = new InfoPageViewModel();
    }
}
