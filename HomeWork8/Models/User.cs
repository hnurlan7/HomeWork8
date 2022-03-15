using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork8.Models
{
    internal class User
    {
        public string Username { get; set; }
        private int _age;

        public int Age
        {
            get
            {
                if (_age < 0)
                {
                    Console.WriteLine("yas 0dan kicik ola bilmez");
                }
                return _age;
            }
            set
            {
                //if (value > 0)
                //{
                //    _age = value;
                //}
                _age = value;
            }
        }

        public bool result;
        private string password(string _password)
        {
            foreach (string pass in _password)


            {
                result = Char.IsUpper(pass);
            }
            if (result != true)
            {
                return "En az 1boyuk herf daxil olunmalidir";

            }
            return _password;
        }
        public string Password { get; set; }




        public User(string username, int _age, string password)
        {
            this.Username = username;
            this.Password = password;
            this.Age = _age;
        }
        public void getInfo()
        {
            Console.WriteLine($"{Username} {_age} {Password}");
        }



    }
}
