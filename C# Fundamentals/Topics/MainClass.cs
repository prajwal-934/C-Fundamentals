using C__Fundamentals.Basic.Functions;
using C__Fundamentals.Topics.OOPM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Fundamentals.Basic
{
    internal class MainClass
    {

        static void Main()
        {
            
            Employee john = new Employee();
            john.salary = 90000;
            john.name = "John";
            john.displaySalary();
            john.displayName();

        }

    }
}
