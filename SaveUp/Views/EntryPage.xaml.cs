using SaveUp.ViewModels;

namespace SaveUp.Views;

public partial class EntryPage : ContentPage
{
    public EntryPage()
    {
        InitializeComponent();
        BindingContext = new EntryViewModel();
    }

    private void OnSaveClicked(object sender, EventArgs e)
    {
        var viewModel = BindingContext as EntryViewModel;
        if (viewModel != null)
        {
            viewModel.SaveCommand.Execute(null);
        }
    }

    private void OnResetClicked(object sender, EventArgs e)
    {
        productNameEntry.Text = string.Empty;
        descriptionEditor.Text = string.Empty;
        priceEntry.Text = string.Empty;
        datePicker.Date = DateTime.Today;
    }
}
