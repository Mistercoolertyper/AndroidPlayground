using System;
using System.ComponentModel;
using System.Linq;
using testprojekt.Models;
using testprojekt.ViewModels;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace testprojekt.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }

        private async void Button_Clicked(object sender, System.EventArgs e)
        {
            var model = (ItemDetailViewModel)BindingContext;

            var locales = await TextToSpeech.GetLocalesAsync();
            var german = locales.FirstOrDefault(l => l.Name.Equals(model.Text, StringComparison.InvariantCultureIgnoreCase));
            await TextToSpeech.SpeakAsync("Papa ist ein geiler Typ", new SpeechOptions
            {
                Locale = german ?? locales.FirstOrDefault()
            });
        }
    }
}