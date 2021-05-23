using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace biletix3.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Fav : ContentPage
    {
        private readonly string[] sourceItems = new[] {"Amadeus","Ahududu","Fahreneit 451","Çok Güzel Hareketler Bunlar","Cennet Bahçesi","Lazarus"
        ,"Bir Delinin Hatıra Defteri","Kibarlık Delisi","Hoşgeldin Boyacı"};

        public ObservableCollection<string> MyItems { get; set; }
        public Fav()
        {
            InitializeComponent();
            MyItems = new ObservableCollection<string>(sourceItems);
            BindingContext = this;

        }

        private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            var searchTerm = e.NewTextValue;

            if (string.IsNullOrWhiteSpace(searchTerm))
            {
                searchTerm = string.Empty;
            }
            searchTerm = searchTerm.ToLowerInvariant();
            var filteredItems = sourceItems.Where(value =>
            
            value.ToLowerInvariant().Contains(searchTerm)).ToList();

            if (string.IsNullOrWhiteSpace(searchTerm))
            {
                filteredItems = sourceItems.ToList();
            }

            foreach (var value in sourceItems)
            {
                if (!filteredItems.Contains(value))
                {
                    MyItems.Remove(value);
                }
                else if (!MyItems.Contains(value))
                {
                    MyItems.Add(value);
                }
            }
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Satinal());
        }
    }
}