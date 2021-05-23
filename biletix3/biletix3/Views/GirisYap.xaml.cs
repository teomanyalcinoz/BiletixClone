using biletix3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SQLite;

namespace biletix3.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GirisYap : TabbedPage
    {
        public Button Button { get; }
        public AppShell Apps { get; }

        public GirisYap(Button button,AppShell apps)
        {
            InitializeComponent();
            CinsiyetPicker.Items.Add("Erkek");
            CinsiyetPicker.Items.Add("Kadın");
            Init();
            Button = button;
            Apps = apps;
        }

        void Init()
        {

            BackgroundColor = Constants.BackgroundColor;

            EntryMailGiris.Completed += (s, e) => Entry_Password.Focus();
        }
        
        

        private void Button_Logout(object sender, EventArgs e)
        {
            Button.Text = "Giriş Yap";
            Button.Clicked -= Button_Logout;
            Button.Clicked += Apps.btnGirisYap_Clicked;
            Apps.FlyoutIsPresented = false;
            DisplayPromptAsync("Çıkış", "Çıkış Başarılı", "Tamam");

        }

        private void Kayit_Clicked(object sender, EventArgs e)            //Kayıt Ol
        {
            var dbpath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "UserDatabase.db");
            var db = new SQLiteAsyncConnection(dbpath);
            db.CreateTableAsync<User>();

            var item = new User()
            {
                Email = entryMail.Text,
                Password = pass1.Text,
                Isim = entryIsim.Text,
                Soyisim = entrySoy.Text,
                Cinsiyet = CinsiyetPicker.SelectedIndex,
                Telno = TelNo.Text,
                Dogum = DateTime.Date.ToString()
            };
            db.InsertAsync(item);
            DisplayAlert("Tebrikler", "Kayit Basarili", "Tamam");



            OrtaligiTemizle();


        }
        private void OrtaligiTemizle()
        {
            entryMail.Text = "";
            pass1.Text = "";
            pass2.Text = "";
            entryIsim.Text = "";
            entrySoy.Text = "";
            TelNo.Text = "";
            CinsiyetPicker.SelectedItem = null;
            checkB1.IsChecked = false;
            checkB2.IsChecked = false;
            checkB3.IsChecked = false;
        }

        async void Girisyap_Clicked(object sender, EventArgs e)         //Giriş Yap
        {
            var dbpath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "UserDatabase.db");
            var db = new SQLiteConnection(dbpath);
            var myquery = db.Table<User>().Where(u => u.Email.Equals(EntryMailGiris.Text) && u.Password.Equals(Entry_Password.Text)).FirstOrDefault();

            if (myquery != null)
            {
                await DisplayAlert("Tebrikler", "Basari ile giris yaptiniz.", "Tamam");
                Button.Text = "Çıkış Yap";
                Button.Clicked -= Apps.btnGirisYap_Clicked;
                Button.Clicked += Button_Logout;
                await Navigation.PopAsync(true);
            }
            else
            {
                await DisplayAlert("Hata", "Hatali Email ya da Sifre", "Tamam");
            }
        }
    }
}