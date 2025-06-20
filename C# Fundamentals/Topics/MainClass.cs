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
            
            Employee john = new Employee("#0001","John",3000,"IT");            
            john.displaySalary();
            john.displayName();

        }

    }
}
