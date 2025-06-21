using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Fundamentals.Topics.Arrays
{
    internal class ExampleArray
    {

        int[] arr = new int[5];

        string[] names = new string[5];
        
        public static string[] fruits = { "apple" ,"banana","mango"};
        int[] arr2 = { 3, 324, 324, 23,11,5,5};

        public static void Test()
        {
           foreach(string i in fruits)
            {
                Console.WriteLine("Value is " + i);
            }

            Console.WriteLine("-------------------------");

           for(int i = 0; i < fruits.Length; i++)
            {
                Console.WriteLine("Value is "+ fruits[i]);
            }
        }


        public static void PrintMinimum(int[] arr)
        {
            int min = arr[0];
            for(int i =0; i<arr.Length; i++)
            {
                if(arr[i] < min)
                {
                    min = arr[i];
                }
            }
            Console.WriteLine("Minimum value is "+min);
        }

        public static void IterateMultiDimensionalArray(int[][] arr)
        {
            for(int i = 0; i<arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write(arr[i][j]+" ");
                }
                Console.WriteLine();
            }
        }

        

    }
}
