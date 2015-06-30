using System;

using Xamarin.Forms;

namespace CustomRenderer
{
    public class App : Application
    {
        public static Size DeviceWindowSize { get; set; }

        public App()
        {
            // The root page of your application
            MainPage = new Login();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}

