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
        private int age;
        public Address address;
        public int Age
        {
            get { return age; }
            set { age = value; }
        }


        public Employee(string employeeId, string name, int salary, string department , Address address)
        {
            this.employeeId = employeeId;
            this.name = name;
            this.salary = salary; 
            this.department = department;
            this.address = address;
        }



        public void DisplayName()
        {
            Console.WriteLine("Employee Name is " + name);
            address.ShowAddress();
        }






        public void DisplaySalary()
        {
            Console.WriteLine("Employee salary is " + salary);
        }


    }
}
