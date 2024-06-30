using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using SaveUp.Models;
using System.Collections.ObjectModel;


namespace SaveUp.ViewModels
{
    public partial class MainPageViewModel : ObservableObject
    {
        [ObservableProperty]
        ObservableCollection<Item> items;

        [ObservableProperty]
        decimal totalSaved;

        private DateTime currentDate;

        // Date for the main Page
        public DateTime CurrentDate
        {
            get => currentDate;
            set => SetProperty(ref currentDate, value);
        }

        // Constructor for ViewModel
        public MainPageViewModel()
        {
            CurrentDate = DateTime.Now;

            Items = new ObservableCollection<Item>
        {
                // Dummy Entrys
            new Item { Name = "Süssigkeiten", Price = 4.00m },
            new Item { Name = "Kaffee", Price = 3.00m },
            new Item { Name = "Zigaretten", Price = 9.40m }
        };
            Items.CollectionChanged += (s, e) => CalculateTotal();
            CalculateTotal();
            MessagingCenter.Subscribe<EntryViewModel, Item>(this, "AddNewItem", (sender, arg) =>
            {
                if (arg != null && !string.IsNullOrWhiteSpace(arg.Name))
                {
                    Items.Add(arg);
                }
            });
        }

        // Calculate all Prices 
        public void CalculateTotal()
        {
            TotalSaved = Items.Sum(item => item.Price);
        }

        // Delete all Entries
        [RelayCommand]
        private void ClearAllEntries()
        {
            Items.Clear();
        }
    }
}
