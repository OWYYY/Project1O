using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace Project1O.Views
{
    public class personView
    {
        public ObservableCollection<product> products { get; set; }

        public Command<product> remeoveCommand{

            get
            {
                return new Command<product>((product) =>
                {

                    products.Remove(product);
                });
            }
        }


        public personView()
        {

            products = new ObservableCollection<product>(new[]
            {

                new product{Name="Owen", person=1, Title="Page1"},
                new product{Name="Owen", person=1, Title="Page1"},
                new product{Name="Owen", person=1, Title="Page1"},
                new product{Name="Owen", person=1, Title="Page1"},

        });
        
        }
    }
}    