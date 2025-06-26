using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Fundamentals.Topics.Delegates
{
    internal class ExampleDelegates
    {
        delegate  int Calculator(int a, int b);

        public static int Add(int a, int b)
        {
            return a + b;
        }
        public static int Multiply(int a, int b)
        {
            return a * b;
        }


        public static void TestDelegates()
        {
            Calculator adder = Add;
            Calculator multiply = Multiply;
            Calculator sub = (int a, int b) => a - b;
            Console.WriteLine(adder(10,12));
            Console.WriteLine(multiply(10,12));
            Console.WriteLine(sub(20,10));

            Action<string> greet = (name) => Console.WriteLine($"Hello {name}");
            greet("Erren");

            Func<int, int, int> mod = (a, b) => a % b;

            Console.WriteLine(mod(10,2));

            Predicate<int> isEven = (num) => num%2==0;
            Console.WriteLine(isEven(32));
        }
    }
}
