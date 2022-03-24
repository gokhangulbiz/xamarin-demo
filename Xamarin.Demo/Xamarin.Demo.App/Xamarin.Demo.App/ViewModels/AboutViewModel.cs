using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Xamarin.Demo.App.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        string buttonClickedText = string.Empty;
        public string ButtonClickedText
        {
            get { return buttonClickedText; }
            set { SetProperty(ref buttonClickedText, value); }
        }

        public AboutViewModel()
        {
            int counter = 0;
            Title = "About";
            OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://aka.ms/xamarin-quickstart"));
            ButtonCommand = new Command(() => 
                ButtonClickedText = $"Button clicked {++counter} times"
            );
        }

        public ICommand OpenWebCommand { get; }

        public ICommand ButtonCommand { get;  } 
    }
}