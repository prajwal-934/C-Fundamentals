using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Fundamentals.Topics.Generics
{
    internal class ExampleGenerics
    {
        //public static int[] createArray(int a, int b)
        //{
        //    return new int[] { a, b };
        //}

        //public static string[] createArray(string a, string b)
        //{
        //    return new string[] { a, b };
        //}

        //generic method
        public static T[] createArray<T>(T firstElement, T secondElement)
        {
            return new T[] { firstElement, secondElement };
        }

        //multiple Generics
        public static void TestMultiGenerics<T1, T2>(T1 firstElement, T2 secondElement)
        {
            Console.WriteLine(firstElement.GetType());
            Console.WriteLine(secondElement.GetType());
        }

        public static void   TestGenerics()
        {
            Console.WriteLine(String.Join(',',createArray(323,432)));
            Console.WriteLine(String.Join(',',createArray("Eren","Armin")));
            Console.WriteLine(String.Join(',',createArray<string>("Eren","Armin")));
            TestMultiGenerics<int, string>(32, "Hello");


        }
    }
}
