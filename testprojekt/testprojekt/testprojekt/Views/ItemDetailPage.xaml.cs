using System.ComponentModel;
using testprojekt.ViewModels;
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
    }
}