using System;
using Xamarin.Demo.App.Services;
using Xamarin.Demo.App.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;

namespace Xamarin.Demo.App
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
            AppCenter.Start("android=4c4ee9c0-5c31-4fdd-a04d-c05e4407674f;" +
                  "uwp=c1fb4e58-13b0-4342-8006-2e4b00664a7b;" +
                  "ios=9027157c-b730-4dba-bb3a-d42e8f0a8a38;",
                  typeof(Analytics), typeof(Crashes));
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
