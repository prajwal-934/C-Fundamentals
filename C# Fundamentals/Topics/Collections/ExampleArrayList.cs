using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Fundamentals.Topics.Collections
{
    internal class ExampleArrayList
    {

        public static void TestArrayList()
        {
            ArrayList list = new ArrayList();
            ArrayList list2 = new ArrayList();
            list.Capacity = 4;
            
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            list.Add(5);
            list.Reverse();
            //ArrayList newList = (ArrayList)list.Clone();
            var result = list.Contains("Hi");
            Console.WriteLine(result);
            var returnedList = list.GetRange(0, 3);
            //list.AddRange(newList);
            Console.WriteLine(String.Join(",",returnedList.ToArray()));
            Console.WriteLine("Count is "+list.Count);
            Console.WriteLine("Index is "+list.IndexOf("Hi"));
            list.Sort();

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
        
        
        

    }
}
