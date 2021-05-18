using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using testprojekt.Models;
using testprojekt.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace testprojekt.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        async void SignInPrecedure(object sender, EventArgs e) 
        {
            User user = new User(Entry_Username.Text, Entry_Password.Text);
            if (user.CheckInformation())
            {
               await DisplayAlert("Login", "Login Success", "OK");
                await Shell.Current.GoToAsync(nameof(AboutPage));
            }
            else 
            {
                await DisplayAlert("Login", "Login Not Correct, Invalid username or Password.", "OK");
            }
        }
    }
}