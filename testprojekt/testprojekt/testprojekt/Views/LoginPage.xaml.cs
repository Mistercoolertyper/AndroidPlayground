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

        void SignInPrecedure(object sender, EventArgs e) 
        {
            User user = new User(Entry_Username.Text, Entry_Password.Text);
            if (user.CheckInformation())
            {
                DisplayAlert("Login", "Login Success", "OK");
            }
            else 
            {
                DisplayAlert("Login", "Login Not Correct, empty username or password.", "OK");
            }
        }
    }
}