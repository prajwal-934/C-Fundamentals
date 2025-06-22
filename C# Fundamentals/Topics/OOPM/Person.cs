using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Fundamentals.Topics.OOPM
{
    internal class Person
    {
        protected string name;
        protected int age;
        protected float salary;
        public static int noOfHands = 2;

        public Person(string name, int age, float salary) 
        {
            this.name = name;
            this.age = age;
            this.salary = salary;
        }

        public void Greet()
        {
            Console.WriteLine("Hello "+name);
        }
        
    }

    internal class Doctor : Person 
    {
        public Doctor(string name, int age, float salary) : base(name, age, salary)
        {
        }

        public static void Test()
        {
            Person person = new Person("Prajwal",34,13434.3f);
            person.Greet();
        }
    }
}
