using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SignUpAndLoginPage.Views.ContentViews
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GeneralContentView : ContentView
    {
        public GeneralContentView()
        {
            InitializeComponent();
        }
        public string LabelTitle
        {
            get => (string)GetValue(GeneralContentView.LabelTitleProperty);
            set => SetValue(GeneralContentView.LabelTitleProperty, value);
        }
        public static readonly BindableProperty LabelTitleProperty = BindableProperty.Create(nameof(LabelTitle), typeof(string), typeof(GeneralContentView), null);
        public string LabelSubTitle
        {
            get => (string)GetValue(GeneralContentView.LabelSubTitleProperty);
            set => SetValue(GeneralContentView.LabelSubTitleProperty, value);
        }

        public static readonly BindableProperty LabelSubTitleProperty = BindableProperty.Create(nameof(LabelSubTitle), typeof(string), typeof(GeneralContentView), null);

        public ImageSource ImageView
        {
            get => (ImageSource)GetValue(GeneralContentView.ImageViewProperty);
            set => SetValue(GeneralContentView.ImageViewProperty, value);
        }

        public static readonly BindableProperty ImageViewProperty = BindableProperty.Create(nameof(ImageView), typeof(ImageSource), typeof(GeneralContentView), default(ImageSource));
    }
}