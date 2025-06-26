using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Fundamentals.Topics.LINQ
{
    internal class ExampleLinq
    {
        public static void TestLinq()
        {
            List<Person> people = new List<Person>
            {
                new Person { Name = "Alice", Age = 30, City = "New York" },
                new Person { Name = "Bob", Age = 19, City = "Chicago" },
                new Person { Name = "Charlie", Age = 25, City = "New York" },
                new Person { Name = "David", Age = 15, City = "Seattle" }
            };

            var departments = new List<string> { "HR", "Finance", "IT" };
            var employees = new List<(string Name, string Dept)>
            {
                ("Alice", "HR"),
                ("Bob", "IT"),
                ("Charlie", "Finance")
            };

            //ex filtering

            var nyPeople  = people.Where((person) => person.City == "New York");
        
            //select
            var names = people.Select((person)=> person.Name);

            //select many
            var Info = people.Select((person)=> new {person.Name , person.Age});

            //order
            var orderPeople = people.OrderBy((person) => person.Age);

            //aggregate

            int  count = people.Count();
            int ageSum = people.Sum((person) => person.Age);
            double avgAge = people.Average(person => person.Age);
            int maxAge = people.Max(person => person.Age);

            //checking any, all, contains
            bool hasDavid = people[0].Name.Contains("Alice");
            bool isAdults = people.All((person) => person.Age > 18);
            bool hasTeen = people.Any((person) => person.Age < 18);

            //finding
            //first,single,last

            var firstResult = people.FirstOrDefault((person) => person.Age < 13) ?? new Person { Name="Guest" , Age=0, City="NoWhere"};
            var singleResult = people.Single((person) => person.Age < 16);
            var lastResult = people.Last((person) => person.Age > 16);


           // var firstResult = people.FirstOrDefault((person) => person.Age < 13) ?? new Person { Name="Guest" , Age=0, City="NoWhere"};
            Console.WriteLine(lastResult.ToString());


            //grouping
            var grouped = people.GroupBy((person) => person.City);
            Console.WriteLine("Count is "+ grouped.Count());

            Console.WriteLine("Employee Type " + employees[0].Dept);


            Console.WriteLine("---------Printing in Loop------------");

            foreach (var item in orderPeople)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
