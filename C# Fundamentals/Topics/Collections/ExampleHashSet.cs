using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Fundamentals.Topics.Collections
{
    internal class ExampleHashSet
    {
        public static void TestHashSet()
        {
            List<int> li = new List<int>();
            li.Add(1);
            li.Add(3);
            li.Add(56);
            li.Add(3);
            li.Add(87);
            HashSet<int> set = new HashSet<int>(li);
            Console.WriteLine("Set Items");
            foreach (var item in set)
            {
                Console.WriteLine(item);
            }

            HashSet<int> set2 = new HashSet<int>(set);
            Console.WriteLine(set.SetEquals(set2));


            HashSet<int> set3 = set2;
            Console.WriteLine(set3.SetEquals(set));

            Console.WriteLine(set3==set);
            Console.WriteLine(set3.Equals(set));

            set3.Add(6);
            set3.Add(7);

            //set.UnionWith(set3);
            //set.IntersectWith(set3);
            set3.ExceptWith(set);

            Console.WriteLine("----union------");
            foreach (var item in set)
            {
                Console.WriteLine(item);
            }

            var small = new HashSet<int> { 1, 2 };
            var large = new HashSet<int> { 1, 2, 3, 4 };

            Console.WriteLine(small.IsSubsetOf(large));    
            Console.WriteLine(large.IsSupersetOf(small));  

        }
    }
}
