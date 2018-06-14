using System;

namespace _6._14._18
{
    class Program
    {
        static void Main(string[] args)
        {
            Greeting();
            int num = returnAnInt(35, 105);
            Console.WriteLine(num);
            Learning();
            Fun();
            Console.ReadKey();

        }

        public static void Greeting ()
        {
            Console.WriteLine("Good Morning!");
        }

        private static void Learning()
        {
            Console.WriteLine("C# is Fun.");
        

        }

        public static int returnAnInt(int x, int y)
        {
            
            return x-y;            
        }

        public static void Fun ()
        {
            Console.WriteLine("Creating C# is interesting.");
        }
    }
}




