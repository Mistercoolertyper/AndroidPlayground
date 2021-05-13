using System;
using System.Collections.Generic;
using System.ComponentModel;
using testprojekt.Models;
using testprojekt.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace testprojekt.Views
{
    public partial class NewItemPage : ContentPage
    {
        public Item Item { get; set; }

        public NewItemPage()
        {
            InitializeComponent();
            BindingContext = new NewItemViewModel();
        }
    }
}