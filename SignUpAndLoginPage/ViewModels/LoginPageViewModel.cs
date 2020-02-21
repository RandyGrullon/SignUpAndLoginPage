using SignUpAndLoginPage.Models;
using SignUpAndLoginPage.Views;
using SignUpAndLoginPage.Views.ContentTabbed;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace SignUpAndLoginPage.ViewModels
{
   public class LoginPageViewModel : INotifyPropertyChanged
    {
        public User UserL { get; set; }
        public ICommand LValidateCommand { get; set; }
        public ICommand LoginToSignUpCommand { get; set; }
        public ICommand VisibleCommand { get; set; }
        public string ImageVisible { get; set; }
        public bool IsVisible { get; set; }
        
        public LoginPageViewModel()
        {
            UserL = new User();

            LValidateCommand = new Command(async()=>
            {
                if (string.IsNullOrEmpty(UserL.Username) || (string.IsNullOrEmpty(UserL.Password)))
                {
                    await App.Current.MainPage.DisplayAlert("Alert", "You have been alerted!", "ok");
                }
                else
                {
                    await App.Current.MainPage.Navigation.PushAsync(new MenuTabbedPage());
                }
            });

            LoginToSignUpCommand = new Command(async()=>
            {
                await App.Current.MainPage.Navigation.PushAsync(new SignUpPage());
            }
            );
            IsVisible = true;
            ImageVisible = "eye";

            VisibleCommand  = new Command(()=> 
            {
                IsVisible = !IsVisible;
                ImageVisible = IsVisible ? "Eye" : "Neye";
            });

           

           

        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
