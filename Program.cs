using System;

namespace MichaelRiveraISM4300Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.Write("Please enter your Name ");



            try
            {
                // This variable will gather data from user input
                string input = Console.ReadLine();
                WeclomeMessage(input);

            } // End of try



            catch
            {
                Console.WriteLine("Press any key to exit the program and try again ...");
                Console.ReadKey(true);
            } // End of catch


        } // End of Main



        private static void WeclomeMessage(string input)
        {

            Console.WriteLine("Hello " + input + " - Go USF! Be sure wear a mask and wash your hands!");
            Console.WriteLine("Press any key to exit the program ...");
            Console.ReadKey(true);
        }
    }
    }

