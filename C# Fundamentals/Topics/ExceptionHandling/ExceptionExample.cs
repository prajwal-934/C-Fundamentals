using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Fundamentals.Topics.ExceptionHandling
{
    internal class ExceptionExample
    {
        public static void Test()
        {
            try
            {
                int a = 10;
                int b = 0;
                int x = a / b;
            }
            catch (Exception e) { Console.WriteLine(e.Message); }
            finally { Console.WriteLine("Finally block is executed"); }
        }
    }
}
