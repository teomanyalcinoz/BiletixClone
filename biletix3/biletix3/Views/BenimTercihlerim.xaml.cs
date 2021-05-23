using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using biletix3.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SQLite;
using System.IO;
using biletix3.Models;

namespace biletix3.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BenimTercihlerim : ContentPage
    {
        public List<string> favlist = new List<string>();

        public BenimTercihlerim()
        {
            InitializeComponent();
            
            
            
            //var favs = db.Table<Favlist>().ToListAsync();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            VeriCek();
        }
        async void VeriCek()
        {
            var dbpath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "UserDatabase.db");
            var db = new SQLiteAsyncConnection(dbpath);
            db.CreateTableAsync<Favori>().Wait();


            var sorgu = await db.Table<Favori>().ToListAsync();
            favlistview.ItemsSource = sorgu;


        }
    }
}