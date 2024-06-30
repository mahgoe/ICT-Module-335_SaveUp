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

        public DateTime CurrentDate
        {
            get => currentDate;
            set => SetProperty(ref currentDate, value);
        }

        public MainPageViewModel()
        {
            CurrentDate = DateTime.Now;

            Items = new ObservableCollection<Item>
        {
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

        public void CalculateTotal()
        {
            TotalSaved = Items.Sum(item => item.Price);
        }

        [RelayCommand]
        private void ClearItems()
        {
            Items.Clear();
        }
    }
}
