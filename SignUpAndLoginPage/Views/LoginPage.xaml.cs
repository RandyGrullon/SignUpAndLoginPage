using SignUpAndLoginPage.ViewModel;
using SignUpAndLoginPage.Views.ContentTabbed;
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
    public partial class LoginPage : ContentPage
    {

        public LoginPage()
        {
            InitializeComponent();
            BindingContext = new LoginPageViewModel();
           
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            

        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            
        }

        private void Pvisibility(object sender, EventArgs e)
        {

        }

        
        }
    }
