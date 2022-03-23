using System.ComponentModel;
using Xamarin.Demo.App.ViewModels;
using Xamarin.Forms;

namespace Xamarin.Demo.App.Views
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