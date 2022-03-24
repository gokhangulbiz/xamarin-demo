using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace Xamarin.Demo.App.UITest
{
    [TestFixture(Platform.Android)]
    [TestFixture(Platform.iOS)]
    public class Tests
    {
        IApp app;
        Platform platform;

        static readonly Func<AppQuery, AppQuery> InitialMessage = c => c.Marked("LabelStart").Text("Start developing now");
        static readonly Func<AppQuery, AppQuery> Button = c => c.Marked("MyButton");
        static readonly Func<AppQuery, AppQuery> DoneMessage = c => c.Marked("MyLabel").Text("Button clicked 1 times");


        public Tests(Platform platform)
        {
            this.platform = platform;
        }

        [SetUp]
        public void BeforeEachTest()
        {
            app = AppInitializer.StartApp(platform);
        }

        [Test]
        public void WelcomeTextIsDisplayed()
        {
            // Arrange - Nothing to do because the queries have already been initialized.
            AppResult[] result = app.Query(InitialMessage);
            Assert.IsTrue(result.Any(), "The initial message string isn't correct - maybe the app wasn't re-started?");

            // Act
            app.Tap(Button);

            // Assert
            result = app.Query(DoneMessage);
            Assert.IsTrue(result.Any(), "The 'clicked' message is not being displayed.");
        }
    }
}
