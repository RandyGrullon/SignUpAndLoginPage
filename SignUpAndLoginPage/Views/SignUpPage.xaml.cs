using SignUpAndLoginPage.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SignUpAndLoginPage.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SignUpPage : ContentPage
    {
        public SignUpPage() { 


            InitializeComponent();
            BindingContext = new SignUpPageViewModel();

        }

        private void Button_Clicked(object sender, EventArgs e)
        {
        }

        private void PasswordVisibility(object sender, EventArgs e)
        {
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
        }
         
        private void RPVisibility(object sender, EventArgs e)
        {
        }
    }
}