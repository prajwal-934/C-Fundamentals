using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Fundamentals.Topics.LINQ
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string City { get; set; }

        public string ToString()
        {
            return $"Name: {Name}, Age: {Age}, City: {City}";
        }
    }



}
