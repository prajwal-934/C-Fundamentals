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
            int choice = 0;
            var input=0;
            do
            {
                Console.WriteLine("----------MENU----------");
                Console.WriteLine("1. Add Elements");
                Console.WriteLine("2. Remove Elements");
                Console.WriteLine("3. List Elements");
                Console.WriteLine("4. Number of Elements");
                Console.WriteLine("5. Exit");

                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        input = Convert.ToInt32(Console.ReadLine());
                        list.Add(input);
                        break;
                    case 2:
                        input = Convert.ToInt32(Console.ReadLine());
                        list.Remove(input);
                        break;
                    case 3:
                        Console.WriteLine("Elements: "+ String.Join(",",list.ToArray()));
                        break;
                    case 4:
                        Console.WriteLine("Total number of element is "+list.Count);
                        break;
                    case 5:
                        Console.WriteLine("Exiting...");
                        break;
                }

            }
            while (choice!=5);
        }
        
        
        

    }
}
