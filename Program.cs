using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Hello World!");
            Console.WriteLine("Welcome to day two.");
            // This will 'call' the GetTheTime method
            GetTheTime();
        }



        private static void GetTheTime()
        {

            String currentTime = DateTime.Now.ToShortTimeString();
            Console.WriteLine("Hello World!");


        }
    }
}
