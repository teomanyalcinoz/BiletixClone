using biletix3.ViewModels;
using biletix3.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace biletix3
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
            CurrentItem = Deneme;
            
        }

        private async void OnMenuItemClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//LoginPage");
        }

        public async void btnGirisYap_Clicked(object sender, EventArgs e)
        {
            FlyoutIsPresented = false;
            await Navigation.PushAsync(new GirisYap(btnGirisYap,this));
            
            
        }
    }
}
