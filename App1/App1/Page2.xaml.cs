using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page2 : ContentPage
    {
        public Page2()
        {
            InitializeComponent();
        }
        private async void Clicked_page1(object sender, EventArgs e)
        {                     
            await Navigation.PopAsync();
        }

        private async void Clicked_page3(object sender, EventArgs e)
        { 
            await Navigation.PushAsync(new Page3()); 
        }

        void OnSliderValueChanged(object sender, ValueChangedEventArgs args)
        {
            double value = args.NewValue;
            rotatingLabel.Rotation = value;
            displayRotation.Text = String.Format("The Slider value is {0}", value);
            
        }
    }
}