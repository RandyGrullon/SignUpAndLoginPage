using SignUpAndLoginPage.ViewModel;
using SignUpAndLoginPage.Views.ContentViews;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SignUpAndLoginPage.Views.ContentTabbed
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DiscoveryPage : ContentPage
    {
        public DiscoveryPage()
        {
            InitializeComponent();
            BindingContext = new DiscoveryPageViewModel();
        }
        private void Seleccion(object sender, EventArgs e)
        {
            var TapColor = (GeneralContentView)sender;
            if (TapColor.BackgroundColor == Color.Default)
            {
                TapColor.BackgroundColor = Color.Orange;
            }
            else
            {
                TapColor.BackgroundColor = Color.Default;
            }
        }
    }
}