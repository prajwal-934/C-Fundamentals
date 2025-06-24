using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Fundamentals.Topics.Collections
{
    internal class ExampleStack
    {

        public static void TestStack()
        {
            List<int> li = new List<int>() { 1,4,6,8};
            Stack<int> stack = new Stack<int>(li);
            int[] arr = new int[10];

            stack.Pop();
            Console.WriteLine(String.Join(',',stack));
            stack.CopyTo(arr,3);
            Console.WriteLine(String.Join(',',arr));
            Console.WriteLine("----enumerator--");
            IEnumerator<int> enumerator = stack.GetEnumerator();
            //while(enumerator.MoveNext())
            //{
            //    Console.WriteLine(enumerator.Current);
            //}
            Console.WriteLine(enumerator.MoveNext());
            Console.WriteLine(enumerator.Current);

        }
    }
}
