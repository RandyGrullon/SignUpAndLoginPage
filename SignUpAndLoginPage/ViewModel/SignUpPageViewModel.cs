using SignUpAndLoginPage.Models;
using SignUpAndLoginPage.Views;
using SignUpAndLoginPage.Views.ContentTabbed;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace SignUpAndLoginPage.ViewModel
{
    public class SignUpPageViewModel : INotifyPropertyChanged 
    {
        public User UserL { get; set; }
        public ICommand SValidateCommand { get; set; }
        public ICommand SignUpToLoginCommand { get; set; }
        public ICommand VisibleCommand { get; set; }
        public string ImageVisible { get; set; }
        public bool IsVisible { get; set; }

        public SignUpPageViewModel()
        {
            UserL = new User();

            SValidateCommand = new Command(async () =>
            {
                if (string.IsNullOrEmpty(UserL.Gmail) || (string.IsNullOrEmpty(UserL.Username)) || (string.IsNullOrEmpty(UserL.Password)) || (string.IsNullOrEmpty(UserL.Repassword)))
                {
                    await App.Current.MainPage.DisplayAlert("Alert", "You have been alerted!", "ok");
                }
                else
                {
                    await App.Current.MainPage.Navigation.PushAsync(new MenuTabbedPage());
                }
            });

            SignUpToLoginCommand = new Command(async () =>
            {
                await App.Current.MainPage.Navigation.PopToRootAsync();
            }
            );

            IsVisible = true;
            ImageVisible = "eye";

            VisibleCommand = new Command(() =>
            {
                IsVisible = !IsVisible;
                ImageVisible = IsVisible ? "Eye" : "Neye";
            });
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }   
}
