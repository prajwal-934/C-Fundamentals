using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Fundamentals.Topics.Collections
{
    internal class ExampleQueue
    {
       public static void TestQueue()
       {
            List<string> li = new List<string>() { "eren", "mikasa", "erwin","reiner" };
            Queue<string> queue = new Queue<string>(li);
            var result = queue.ToArray();
            Console.WriteLine("Capacity: "+queue.EnsureCapacity);
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            queue.Dequeue();
            Console.WriteLine(String.Join(',',queue));
            Console.WriteLine(queue.Peek());
            Console.WriteLine(queue.Contains("erwin"));

        }

    }
}
