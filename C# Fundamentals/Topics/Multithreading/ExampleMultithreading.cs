using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Fundamentals.Topics.Multithreading
{
    internal class ExampleMultithreading
    {

        public static void TestMultiThreading()
        {



            Task task = new Task(() =>
            {
                Console.WriteLine("Running task in seprate thread..");
                int result = add(34, 2);
                Console.WriteLine("Result is " + result);
            });

            task.Start();

            Console.WriteLine("Main Thread");

            static int add(int a  , int b)
            {
                return a + b;
            }



        }
    }
}
