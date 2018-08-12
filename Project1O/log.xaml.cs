using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Project1O
{
    public partial class log : ContentPage
    {
        private Button _loginButton = null;
        private Entry _PasswordInput = null;
        private Entry _UsernameInput = null;

        public log()
        {
            _UsernameInput = new Entry { Placeholder = "Username" };
            _PasswordInput = new Entry { Placeholder = "Password", IsPassword = true };

            _loginButton = new Button
            {
                Text = "Login",
               
            };
    
        _loginButton.Clicked += LogIn;

            Content = new StackLayout
            {
                VerticalOptions = LayoutOptions.Center,
                Children =
            {
                 _UsernameInput, _PasswordInput, _loginButton,
            },
                Spacing = 15
            };
        }

        public async void LogIn(object sender, EventArgs eventsArgs)
        {
            //do authenticate stuff here
            SSO.MyAuthentication client = new SSO.MyAuthentication();

            bool isAuthenticated = client.Authenticate(_UsernameInput.Text, _PasswordInput.Text);

            if (isAuthenticated)
            {
                //Push home page to top of navigation stack
                Navigation.PushAsync(new MainPage());
            }
        }
    }
}
