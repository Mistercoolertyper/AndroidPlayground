using System;
using System.ComponentModel;
using System.Linq;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace testprojekt.Views
{
    public partial class AboutPage : ContentPage
    {
        public AboutPage()
        {
            InitializeComponent();
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