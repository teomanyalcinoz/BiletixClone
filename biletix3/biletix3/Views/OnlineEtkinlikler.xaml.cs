using biletix3.Views.etkinlikler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace biletix3.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OnlineEtkinlikler : ContentPage
    {
        public OnlineEtkinlikler()
        {
            InitializeComponent();
        }

        private async void Celile_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Celile());
        }

        private async void fahrenheit_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Fahrenheit());
        }
        private async void frida_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Frida());
        }

        private async void birdelinin_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Birdelinin());
        }

        private async void kibar_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Kibar());

        }

        private async void boyaci_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Boyaci());
        }

        private async void ahududu_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Satinal());
        }
    }
}