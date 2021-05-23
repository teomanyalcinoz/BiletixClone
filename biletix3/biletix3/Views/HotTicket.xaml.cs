using biletix3.Views.etkinlikler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using biletix3.Models;

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

        private async void amadeusfav_Clicked(object sender, EventArgs e)
        {
            var str = (sender as ImageButton).BindingContext as string; 
            var dbpath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "UserDatabase.db");
            var db = new SQLiteAsyncConnection(dbpath);
            db.CreateTableAsync<Favori>().Wait();

            var item = new Favori
            {
                etkinlikadi = str
            };
            var sonuc = await db.QueryAsync<Favori>("select * from Favori where etkinlikadi=?", str);
            

            if ( sonuc.Count == 0) {
                await db.InsertAsync(item);
            }
            else
            {
                await db.QueryAsync<Favori>("delete from Favori where etkinlikadi=?", str);
            }

        }

        private void ImageButton_Clicked(object sender, EventArgs e)
        {

        }
    }
}