using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Fundamentals.Topics.OOPM
{
    internal class Employee
    {
         string employeeId;
         string name;
         int salary;
         string department;

        public Employee(string employeeId , string name,  int salary , string department)
        {
            this.employeeId = employeeId;
            this.name = name;
            this.salary = salary;
            this.department = department;
        } 


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
