using System;
using System.ComponentModel;
using System.Linq;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using static System.Net.Mime.MediaTypeNames;

namespace testprojekt.Views
{
    public partial class AboutPage : ContentPage
    {
        public AboutPage()
        {
            InitializeComponent();
        }

        void Handle_Clicked(object sender, EventArgs e)
        {
            if (Connectivity.NetworkAccess != NetworkAccess.Internet)
            {
                DisplayAlert("No Internet", "Check your Wifi/Internet connection", "OK");
                return;
            }

            if (Connectivity.NetworkAccess == NetworkAccess.Internet)
            {
                DisplayAlert("Internet fine", "Your Wifi/Internet connection is working fine.", "OK");
                return;
            }
        }


        
        
        

        private async void Button_Clicked(object sender, EventArgs e)
        {
            var locales = await TextToSpeech.GetLocalesAsync();
            var german = locales.FirstOrDefault(l => l.Language.Equals("ita", StringComparison.InvariantCultureIgnoreCase));
            await TextToSpeech.SpeakAsync("Papa ist ein geiler Typ", new SpeechOptions
            {
                Locale = german ?? locales.FirstOrDefault()
            });   
        }
    }
}