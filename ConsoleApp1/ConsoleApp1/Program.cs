using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int money = 100000;
            int year = 1;
            float x = 3.0f;
            double y = 4.5d;
            bool yes = true;
            Console.WriteLine(money);
            Console.WriteLine(year);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(yes);
            Console.ReadKey();

            Console.WriteLine("I want to earn {0} dollars the {1}st year I am employed. I hope to work at least {2} years there.", money, year, x);
            Console.ReadKey();

            string thoughts = "I like C# better than JavaScript.";
            Console.WriteLine(thoughts);
            Console.ReadKey();

            Console.Write("Please enter in your desired job after i.c.stars:");
            string name = Console.ReadLine();
            Console.WriteLine(name);
            Console.ReadKey();

            Console.WriteLine(10 > 100);
            Console.WriteLine("pineapple" == "apple");
            Console.WriteLine("sunshine" == "sunshine");
            Console.WriteLine(2516 > 2000);
            Console.ReadKey();



        }
    }
    
}
