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
    public partial class HotTicket : ContentPage
    {
        public HotTicket()
        {
            InitializeComponent();
        }
        async void row0_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new amadeus());
        }

        async void row1_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Fahrenheit());
        }

        async void row2_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Cghbunlar());
        }

        async void row3_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Cennetbahcesi());
        }

        async void row4_clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Satinal());
        }

        async void row5_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Thinkhouse());
        }

    }
}