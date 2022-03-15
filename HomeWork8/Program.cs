using System;
using HomeWork8.Models;

namespace HomeWork8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new User("user", -20, "pass");
            Console.WriteLine(user.Age);
        }
    }
}