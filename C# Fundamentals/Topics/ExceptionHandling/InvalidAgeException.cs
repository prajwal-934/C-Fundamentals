using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Fundamentals.Topics.ExceptionHandling
{
    internal class InvalidAgeException: Exception
    {
        public int Age { get; set; }  
        public InvalidAgeException(string message , int enteredAge):base(message)
        {
            Age = enteredAge;
        }

    }

    public class TestUserDefinedException
    {
        static void Validate(int age)
        {
            if(age < 18)
            {
                throw new InvalidAgeException("Age can not be less than 18", 18);
            }
        }

        public static void TestException()
        {
            try
            {
                Validate(61);
            }
            catch (InvalidAgeException e)
            {
                Console.WriteLine($"Exception: {e.Message}");
                Console.WriteLine($"Entered Age: {e.Age}");
               
            }
        }
    }
}
