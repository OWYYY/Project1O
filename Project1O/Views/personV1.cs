using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace Project1O.Views
{
    public class personV1
    {

        public ObservableCollection<product1> products { get; set; }
  


        public personV1()
        {

            products = new ObservableCollection<product1>
            {

                new product1{Name1="Leo", person1=2},

        };

        }
    }

}
