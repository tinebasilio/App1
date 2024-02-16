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
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
        }
        private async void Clicked_page2(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page2());
        }
        private async void Clicked_page3(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page3());
        }

        private void MyCodeClicked(object sender, EventArgs e)
        {
            myEntry.Text = "Welcome to my World";
            myEntry.TextColor = Color.Green;
        }
    }
}