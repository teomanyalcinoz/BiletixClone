using biletix3.ViewModels;
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
    public partial class FbTest : ContentPage
    {
        public FbTest()
        {
            InitializeComponent();
            BindingContext = new StudentsViewModel();
        }
    }
}