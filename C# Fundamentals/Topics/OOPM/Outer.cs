using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Fundamentals.Topics.OOPM
{
    internal class Outer
    {
        internal class Inner 
        {
          private static int age = 34;
          protected static void PrintDetails()
            {
                Console.WriteLine($"Age is " + age);
            }  
        }

        internal class Inner2 : Inner
        {
            public static void Test()
            {
                PrintDetails();
            }

            public void Run()
            {
                Console.WriteLine("Running child class");
            }
        }

    }
}
