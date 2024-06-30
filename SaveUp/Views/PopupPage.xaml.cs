using SaveUp.Models;

namespace SaveUp.Views;

public partial class PopupPage : ContentPage
{
    public Item Item { get; set; }

    // Show Item with this details
    public PopupPage(Item item)
    {
        InitializeComponent();
        Item = item;
        NameLabel.Text = $"Name: {Item.Name}";
        PriceLabel.Text = $"Preis: {Item.Price} CHF";
    }

    // Delete Item which is selected
    private async void OnDeleteClicked(object sender, EventArgs e)
    {
        MessagingCenter.Send(this, "DeleteItem", Item);
        await Navigation.PopModalAsync();
    }

    // Cancel Button
    private async void OnCancelClicked(object sender, EventArgs e)
    {
        await Navigation.PopModalAsync();
    }
}
