using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Fundamentals.Topics.Collections
{

    internal class ExampleDictionary
    {

        public static void TestDictionary()
        {
            Dictionary<int, string> phoneBook = new Dictionary<int, string>();
            phoneBook.Add(324324, "Prajwal");
            phoneBook.Add(112223, "John");
            phoneBook.Add(334444, "Eren");

            Console.WriteLine("Contain Key? "+phoneBook.ContainsKey(112223));
            phoneBook.Remove(334444);
            foreach (var item in phoneBook.Values)
            {
                Console.WriteLine("Values of phoneBook"+item);
            }

            Console.WriteLine("Accessing phoneBook " + phoneBook[112223]);
            var updated = phoneBook[112223] = "Sam";
            Console.WriteLine("Updated Value is "+updated);
            Console.WriteLine("Count of phoneBook "+phoneBook.Count);
            phoneBook[23424]="Hello";
            Console.WriteLine("-----Dict----------");
            foreach (var item in phoneBook.Values)
            {
                Console.WriteLine("Values of phoneBook" + item);
            }
            Console.WriteLine("Accessing value " + phoneBook[344]);
        }
    }
}
