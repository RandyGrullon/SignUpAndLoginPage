using SignUpAndLoginPage.Models;
using SignUpAndLoginPage.Views.ContentViews;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace SignUpAndLoginPage.ViewModels
{
    public class DiscoveryPageViewModel : INotifyPropertyChanged 
    {
        public Color ColorHotels { get; set; }
        public Color ColorDining { get; set; }
        public Color ColorCafe { get; set; }
        public Color ColorNearby { get; set; }
        public Color ColorFastFood { get; set; }
        public Color ColorFeaturedFoods { get; set; }

        public ICommand ColorCommand { get; set; }
        public GeneralItems Hotels { get; set; }
        public GeneralItems Dining { get; set; }
        public GeneralItems Cafe { get; set; }
        public GeneralItems Nearby { get; set; }
        public GeneralItems FastFood { get; set; }
        public GeneralItems FeaturedFoods { get; set; }
        public DiscoveryPageViewModel()
        {
            Hotels = new GeneralItems()
            {
                ImageView = "cerveza",LabelTitle = "Bars and Hotels",LabelSubTitle = "42 Place"
            };

            Dining = new GeneralItems()
            {
                ImageView = "bandeja",LabelTitle = "Fine Dining",LabelSubTitle = "15 Place"
            };

            Cafe = new GeneralItems()
            {
                ImageView = "mapa",LabelTitle = "Nearby",LabelSubTitle = "34 Place"
            };

            Nearby = new GeneralItems()
            {
                ImageView = "tienda", LabelTitle = "Cafe",LabelSubTitle = "42Place"
            };

            FastFood = new GeneralItems()
            {
                ImageView = "comida",LabelTitle = "FastFood",LabelSubTitle = "29 Place"
            };

            FeaturedFoods = new GeneralItems()
            {
                ImageView = "pizza",LabelTitle = "Featured Foods",LabelSubTitle = "21 Place"
            };

            ColorCommand = new Command((ChangeColor)=>
            {
                #region Colores 
                ColorHotels = Color.White;
                ColorDining = Color.White;
                ColorCafe = Color.White;
                ColorNearby = Color.White;
                ColorFastFood = Color.White;
                ColorFeaturedFoods = Color.White;
                #endregion

                if (ChangeColor.ToString() == "Hotels")
                {
                    ColorHotels = Color.Orange;
                }
                else if (ChangeColor.ToString() == "Dining")
                {
                    ColorDining = Color.Orange;
                }
                else if (ChangeColor.ToString() == "Cafe")
                {
                    ColorCafe = Color.Orange;
                }
                else if (ChangeColor.ToString() == "Nearby")
                {
                    ColorNearby = Color.Orange;
                }
                else if (ChangeColor.ToString() == "FastFood")
                {
                    ColorFastFood = Color.Orange;
                }
                else if (ChangeColor.ToString() == "FeaturedFoods")
                {
                    ColorFeaturedFoods = Color.Orange;
                }
            });
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
