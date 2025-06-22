using C__Fundamentals.Basic.Functions;
using C__Fundamentals.Topics.Arrays;
using C__Fundamentals.Topics.ExceptionHandling;
using C__Fundamentals.Topics.OOPM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace C__Fundamentals.Basic
{

    internal class MainClass

    {

       
        static void Main()
        {
            Address address = new Address("34 Mhow", "Bhopal", "Madhya Pradesh", 343442);
            Employee employee = new Employee("Emp123", "John", 32434, "IT", address);
            employee.DisplayName();
            Doctor.Test();
            Outer.Inner2.Test();

            Outer.Inner2 inner = new Outer.Inner2();
            inner.Run();


            string str = "Hel,lo";
            Console.WriteLine("----------Strings--------");
            Console.WriteLine(str.ToLower());
            Console.WriteLine(str.Replace("o","e"));
            Console.WriteLine(String.Concat(str," Wor,ld"));
            string[] s2 = str.Split(',');
            Console.WriteLine("Split strings.....");
            foreach(string s3 in s2)
            {
                Console.WriteLine(s3);
            }

            ExceptionExample.Test();
            TestUserDefinedException.TestException();

           

        }
    }
}
