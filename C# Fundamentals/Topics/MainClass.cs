using C__Fundamentals.Basic.Functions;
using C__Fundamentals.Topics.Arrays;
using C__Fundamentals.Topics.OOPM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Fundamentals.Basic
{
    internal class MainClass
    {
        static void Main()
        {
            Console.WriteLine();

            int[] arr = { 2, 3, 54, 6, 7, 3 };
            int[][] jaggedArray = new int[4][]{
        new int[] { 25, 45, 41, 78, 34 },
        new int[] { 4, 52, 36, 15, 27, 73 },
        new int[] { 2, 5, 28, 31, 47  },
        new int[] { 13, 53, 72  }
        }; ;

            ExampleArray.Test();

            
            ExampleArray.PrintMinimum(arr);
            ExampleArray.IterateMultiDimensionalArray(jaggedArray);
             
            Console.WriteLine("Fruits array accessed successfully." + String.Join(',', ExampleArray.fruits));
        }
    }
}
