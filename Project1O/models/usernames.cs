using System;
using Xamarin.Forms;

namespace Project1O
{
    public class usernames
    {
        public int ID { get; set; }

        public string username { get; set; }

        public string password { get; set; }

        public usernames(){}


        public usernames(string username,string password){

            this.username = username;

            this.password = password;

        }
        public bool checkname(){


            if (!this.username.Equals("") && !this.password.Equals(""))
                return true;
            else
                return false; 

        }


        public usernames(Entry entry_username, Entry entry_password)
        {
        }
    }
}
