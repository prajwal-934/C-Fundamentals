using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace C__Fundamentals.Basic.Functions
{
    internal class ExampleFunction
    {
    
        //Non Static
        public string Show(string message)
        {
            return $"Hello {message}";
        }

        //static method
        public static string Greet(string person) {
            return $"Hello {person}";
        }

        //ref methods
        public static void DoubleValue(ref  int num)
        {
            num *= 2;
        }


        //out
        static void GetCoordinates(out int x, out int y)
        {
            x = 10;
            y = 20;
        }


        //params
        public static void PrintNumbers(params string[] names)
        {
            foreach(string name in names)
            {
                Console.WriteLine(name);
            }
        }
        //optional reference
        public static void GreetOptional(string name = "Guest")
        {
            Console.WriteLine("Hello, " + name);
        }


        //class runner function
        public static void Run()
        {
            int number = 10;
            int a, b;
            DoubleValue(ref number);
            Console.WriteLine(number);

            GetCoordinates(out a, out b);
            Console.WriteLine($"{a}, {b}");

            PrintNumbers("John", "Doe", "Sam");
            GreetOptional();
            GreetOptional("Prajwal");

        }

    }
}
