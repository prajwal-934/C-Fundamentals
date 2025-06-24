using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace C__Fundamentals.Topics.Collections
{
    internal class ExampleList
    {
         class Student {
            
             public int Id { get; set; }
             public string Name { get; set; }
             public int Age { get; set; }

            public Student(int id, string name, int age)
            {
                Id = id;
                Name = name;
                Age = age;

            }
            public override string ToString()
            {
                return $"Name: {Name}, Age: {Age}, ID: {Id}";
            }
        }
        public static void TestList()
        {
            List<int> list = new List<int>();
            list.Capacity = 3;
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.AddRange([34,324,3,43,25,23,4]);    
            list.Reverse();
            list.ForEach(x => Console.WriteLine(x)); 
            
            Console.WriteLine(list.Capacity);

            List<string> result = list.ConvertAll((item)=>item.ToString());
            result.ForEach(x => {

                Console.WriteLine($"type of {x} is {x.GetType()}");
            });


            Console.WriteLine("Students list");
            Student s1 = new(1001,"John",12);
            Student s2 = new(1002,"Sam",14);
            Student s3 = new(1003, "Alex", 9);

            List<Student> students = new List<Student>();
            students.AddRange([s1, s2, s3]);
            students.Sort((a,b)=>b.Age.CompareTo(a.Age));
            students.ForEach(student => {
                Console.WriteLine(student.Age);
            });

            Student resultStudent = students.Find((student) => student.Age == 14);
            Console.WriteLine("Result List");
            Console.WriteLine(resultStudent.ToString());
            
            
            
    
        }


    }

    
}
