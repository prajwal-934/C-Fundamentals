using C__Fundamentals.Basic.Functions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Fundamentals.Basic
{
    internal class MainClass
    {
        //Things covered in this file:
        //    variable and data types
        //    conditional statements
        //    Loops
        //    methods
        static void Main()
        {
            //Functions
            ExampleFunction fun = new ExampleFunction();
            string result = fun.Show("John");
            Console.WriteLine(result);
            ExampleFunction.Run();

        }

    }
}
