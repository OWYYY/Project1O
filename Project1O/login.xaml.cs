using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Project1O
{
    public partial class login : ContentPage
    {
        public login()
        {
            InitializeComponent();
        }

        private async void SignIn(object sender,EventArgs e){

            usernames user = new usernames(Entry_username.Text, Entry_password.Text);

            await Navigation.PushAsync(new MainPage());

        }
    }
}
