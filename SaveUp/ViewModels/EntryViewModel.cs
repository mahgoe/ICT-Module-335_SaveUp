using CommunityToolkit.Mvvm.ComponentModel;
using SaveUp.Models;
using System.Windows.Input;

namespace SaveUp.ViewModels
{
    public class EntryViewModel : ObservableObject
    {
        private string productName;
        private string description;
        private DateTime dateSaved = DateTime.Today;
        private decimal price;

        public string ProductName
        {
            get => productName;
            set => SetProperty(ref productName, value);
        }

        public string Description
        {
            get => description;
            set => SetProperty(ref description, value);
        }

        public DateTime DateSaved
        {
            get => dateSaved;
            set => SetProperty(ref dateSaved, value);
        }

        public decimal Price
        {
            get => price;
            set => SetProperty(ref price, value);
        }

        public ICommand SaveCommand { get; }

        public EntryViewModel()
        {
            SaveCommand = new Command(SaveData);
        }

        // Create new Item with the Data thats filled
        private void SaveData()
        {
            
            var newItem = new Item
            {
                Name = ProductName,
                Price = Price
            };

            // Messaging the MainPage with the new Item
            MessagingCenter.Send(this, "AddNewItem", newItem);

            // Clears the Page Entries
            ProductName = string.Empty;
            Description = string.Empty;
            Price = 0;
            DateSaved = DateTime.Today;
        }
    }
}
