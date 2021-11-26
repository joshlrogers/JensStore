using System;

namespace Jens.Store.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var username = "Obi";
            var currentTime = DateTime.Now;

            if (currentTime < DateTime.Parse("12:00:00"))
            {
                Console.WriteLine($"Good Morning {username}!");
            }
            else if (currentTime < DateTime.Parse("17:00:00"))
            {
                Console.WriteLine($"Good Afternoon {username}!");
            }
            else
            {
                Console.WriteLine($"Good Evening {username}!");
            }
        }
    }
}
