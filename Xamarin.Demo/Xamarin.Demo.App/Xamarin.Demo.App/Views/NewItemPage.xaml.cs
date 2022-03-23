using System;
using System.Collections.Generic;
using System.ComponentModel;
using Xamarin.Demo.App.Models;
using Xamarin.Demo.App.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Xamarin.Demo.App.Views
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