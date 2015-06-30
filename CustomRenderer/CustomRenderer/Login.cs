using System;

using Xamarin.Forms;

namespace CustomRenderer
{
    public class Login : ContentPage
    {
        public Login()
        {
            var quarter = App.DeviceWindowSize.Width / 4;
            var btnLogin = new NewButton()
            {
                Text = "Login",
            };
            var txtUsername = new Entry
            {
                Placeholder = "Enter your username",
                WidthRequest = 3 * quarter
            };
            var txtPassword = new Entry
            {
                Placeholder = "Enter your password",
                IsPassword = true,
                WidthRequest = 3 * quarter
            };
            btnLogin.Clicked += delegate
            {
                if (!string.IsNullOrEmpty(txtUsername.Text) && !string.IsNullOrEmpty(txtPassword.Text))
                    LoginUser(txtUsername.Text, txtPassword.Text);
            };
            Content = new StackLayout()
            {
                Orientation = StackOrientation.Vertical,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                VerticalOptions = LayoutOptions.CenterAndExpand,
                Padding = new Thickness(10),
                Children =
                {
                    new StackLayout
                    {
                        Orientation = StackOrientation.Horizontal,
                        Children = { new Label(){ Text = "Username", WidthRequest = quarter }, txtUsername }
                    },
                    new StackLayout
                    {
                        Orientation = StackOrientation.Horizontal,
                        Children = { new Label(){ Text = "Password", WidthRequest = quarter }, txtPassword }
                    },
                    btnLogin
                }
            };
        }

        void LoginUser(string username, string password)
        {
            // we will do something here a bit later
        }
    }
}


