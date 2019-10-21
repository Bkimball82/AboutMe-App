using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AboutMe
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ContactPage : ContentPage
    {
        public ContactPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            if (nameEntry.Text == "" || nameEntry.Text == null)
            {
                await DisplayAlert("Error!", "Please Enter a Name", "OK");
                return;
            }

            if (emailEntry.Text == "" || emailEntry.Text == null)
            {
                await DisplayAlert("Error!", "Please Enter a Email", "OK");
                return;
            }

            if (phoneEntry.Text == "" || phoneEntry.Text == null)
            {
                await DisplayAlert("Error!", "Please Enter a Phone Number", "OK");
                return;
            }

            if (questionEntry.Text == "" || questionEntry.Text == null)
            {
                await DisplayAlert("Error!", "Please Enter a Question", "OK");
                return;
            }


            await DisplayAlert("Thanks", "Your message was sent", "OK");

            Navigation.PopAsync();
        }
    }
}