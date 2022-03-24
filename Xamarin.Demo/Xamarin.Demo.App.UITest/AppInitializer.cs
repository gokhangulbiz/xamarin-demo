using System;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace Xamarin.Demo.App.UITest
{
    public class AppInitializer
    {
        public static IApp StartApp(Platform platform)
        {
            switch (platform)
            {
                case Platform.Android:
                    return ConfigureApp.Android
                        .InstalledApp("com.companyname.xamarin.demo.app")
                        .StartApp();
                case Platform.iOS:
                    return ConfigureApp.iOS.
                        InstalledApp("com.companyname.Xamarin.Demo.App")
                        .StartApp();
                default:
                    throw new NotImplementedException();
            }
        }
    }
}