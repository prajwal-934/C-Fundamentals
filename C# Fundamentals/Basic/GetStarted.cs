using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Fundamentals.Basic
{
    internal class GetStarted
    {
        //Things covered in this file:
        //    variable and data types
        //    conditional statements
        //    Loops
        //    methods
        static void Main()
        {
            Console.WriteLine("Hello World 2");

            //data types
            int age = 25;
            double price = 19.99;
            char grade = 'A';
            string name = "Alice";
            bool isPresent = true;
            
            //string manupulation 
            int x = 10;
            int y = 20;
            int result = x + y;
            string user = "Alice";
            Console.WriteLine("Result "+ result);

            //placeholders
            Console.WriteLine("{0} + {1} = {2}", x, y, result);

            //control Statements
            Conditional();
            Loops();
            SwitchCase();
            GreetUser(user);
            Console.WriteLine("Sum of x and y is " + Sum(x, y));
            Console.WriteLine("Goodbye User");
        }

        static void Conditional()
        {
            int x = 10;
            int y = 20;
            if (x < y)
            {
                Console.WriteLine("X is less than Y");
            }
            else if (y < x)
            {
                Console.WriteLine("Y is less than X");
            }
            else
            {
                Console.WriteLine("X and Y both are same");
            }
        }
        static void Loops()
        {
            string[] fruits = ["Apple","Mango","Orange"];
            //for Loop
            Console.WriteLine("For Loop");
            for(int i = 0; i< 10; i++)
            {
                Console.WriteLine(i);
            }

            //while
            Console.Write("While Loop");
            int x = 15;
            while (x > 10) {
                Console.WriteLine(x);
                x--;
            }

            //do while
            Console.WriteLine("Do While");
            int y = 5;

            do {
                Console.WriteLine(y);
                y++;
            }while (y < 10);

            //forEach
            Console.WriteLine("For Each Loop");
            foreach (string fruite in fruits) { 
                Console.WriteLine(fruite);
            }

        }

        static void SwitchCase()
        {
            string input = "Two";

            switch (input)
            {
                case "One":
                    Console.WriteLine("Value is 1");
                    break;
                case "Two":
                    Console.WriteLine("Value is 2");
                    break;
                case "Three":
                    Console.WriteLine("Value is 3");
                    break;
                default:
                    Console.WriteLine("No value found");
                    break;
            }

        }

        static void GreetUser(string username) {
            Console.WriteLine("Hello " + username);
        }

        static int Sum(int input1 , int input2) { 
            return input1 + input2;
        }


    }
}
