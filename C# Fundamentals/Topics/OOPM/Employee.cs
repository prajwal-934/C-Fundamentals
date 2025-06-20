using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Fundamentals.Topics.OOPM
{
    internal class Employee
    {
        public string employeeId;
        public string name;
        public int salary;
        public string department;


        public void displayName()
        {
            Console.WriteLine("Employee Name is " + name);
        }

        public void displaySalary()
        {
            Console.WriteLine("Employee salary is " + salary);
        }


    }
}
