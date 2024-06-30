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

        public MainPageViewModel()
        {
            Items = new ObservableCollection<Item>
        {
            new Item { Name = "Süssigkeiten", Price = 4.00m },
            new Item { Name = "Kaffee", Price = 3.00m },
            new Item { Name = "Zigaretten", Price = 9.40m }
        };
            Items.CollectionChanged += (s, e) => CalculateTotal();
            CalculateTotal();
        }

        private void CalculateTotal()
        {
            TotalSaved = Items.Sum(item => item.Price);
        }
    }
}
