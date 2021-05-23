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
    public partial class Frida : ContentPage
    {
        public Frida()
        {
            InitializeComponent();
            var tarih = lbltarih.Text;
            kampanyapicker.Items.Add("GENEL SATIŞ");
            tarihpicker.Items.Add(tarih);
            tampicker.Items.Add("1");
            tampicker.Items.Add("2");
            tampicker.Items.Add("3");
            tampicker.Items.Add("4");
            tampicker.Items.Add("5");
            gosteripicker.Items.Add("1. Kategori 50.0");
            gosteripicker.Items.Add("2. Kategori 100.0");
            gosteripicker.Items.Add("3. Kategori 250.0");
            gosteripicker.Items.Add("4. Kategori 500.0");
            gosteripicker.Items.Add("5. Kategori 1000.0");
            bolumpicker.Items.Add("1. Blok");
            bolumpicker.Items.Add("2. Blok");
        }

        private async void Satinal_Clicked(object sender, EventArgs e)
        {

            try
            {
                if ((kampanyapicker.SelectedItem != null) && (tarihpicker.SelectedItem != null) &&
                    (tampicker.SelectedItem != null) && (gosteripicker.SelectedItem != null) && (bolumpicker.SelectedItem != null))
                {
                    await Navigation.PushAsync(new FbTest());
                }
                else
                {
                    await DisplayAlert("Başarısız", "Bilet Alınamadı.", "Tamam");
                }
            }
            catch (Exception ex)
            {

                await DisplayAlert("Hata", ex.Message.ToString(), "Tamam");
            }

        }

        private void mekansayfasi_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Mekan Lokasyonu", "Şifa/ Istanbul", "Tamam");
        }

        private void etkbilgileri_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Etkinlik Bilgileri", "Contemporary istanbul, turkiyeden " +
                "çagdas sanat galerileri ile düzenlediği 15. edisyonu ile kapılarını sanatseverlere açıyor...", "Tamam");
        }
        private void biletfiyatlari_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Bilet Fiyatlari", "-İndirimli öğrenci biletleri, öğrenci kimliği gösterilerek etkinlik ana gişesinde satın alınabilecektir." +
                "-indirimli öğrenci bilet fiyatı 80.00TL" +
                "Tam - 120.00TL", "Tamam");
        }

        private void etknotlari_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Etkinlik Notlari", "Covid-19 tedbir ve önlemleri doğrultusunda ziyaretçiler fuar alanında 2 saat " +
                "kalabilecek, bilet satışları saat aralıklarında sınırlı sayıda yapılacaktır.", "Tamam");
        }

        private void resmi_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Resmi Site", "Site Bulunmamaktadır.", "Tamam");
        }

        private void galerivideo_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Galeri ve Video", "Galeri ve Video Bulunmamaktadır.", "Tamam");
        }
    }
}
