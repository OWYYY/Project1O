using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project1O.Views;
using Xamarin.Forms;

namespace Project1O
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

        }



        private void Remove_clicked(object sender, EventArgs e)
        {

            var button = sender as Button;

            var product = button.BindingContext as product;

            var vm = BindingContext as personView;

            vm?.remeoveCommand.Execute(product);
        }

        private async void Buttonclick(object sender, EventArgs e)
        {

            await Navigation.PushAsync(new MyPage2());


        }

        private async void Buttonclick1(object sender, EventArgs e)
        {

            await Navigation.PushAsync(new MyPage2());


        }

    }

}