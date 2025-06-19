using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Fundamentals.Basic.Functions
{
    internal class ExampleFunction
    {
        //
        public string Show(string message)
        {
            return $"Hello {message}";
        }


        static void Main(string[] args)
        {
            ExampleFunction example = new ExampleFunction();
            string messageResult = example.Show("John");
            Console.WriteLine(messageResult);

        }
    }
}
