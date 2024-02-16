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
    public partial class Page3 : ContentPage
    {
        public Page3()
        {
            InitializeComponent();

            var person = new Person
            {
                Name = "Juan Dela Cruz",
                Age = 25,
                Address = "Angeles City"
            };

            BindingContext = person;
        }

        private async void Clicked_page2(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
        private async void Clicked_homepage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page1());
        }
    }
}