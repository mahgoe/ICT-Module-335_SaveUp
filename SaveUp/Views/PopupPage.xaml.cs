using SaveUp.Models;

namespace SaveUp.Views;

public partial class PopupPage : ContentPage
{
    public Item Item { get; set; }

    public PopupPage(Item item)
    {
        InitializeComponent();
        Item = item;
        NameLabel.Text = $"Name: {Item.Name}";
        PriceLabel.Text = $"Preis: {Item.Price} CHF";
    }

    private async void OnDeleteClicked(object sender, EventArgs e)
    {
        // Logik zum Löschen des Eintrags
        MessagingCenter.Send(this, "DeleteItem", Item);
        await Navigation.PopModalAsync();
    }

    private async void OnCancelClicked(object sender, EventArgs e)
    {
        await Navigation.PopModalAsync();
    }
}
