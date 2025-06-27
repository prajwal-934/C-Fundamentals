using C__Fundamentals.Basic.Functions;
using C__Fundamentals.Topics.Arrays;
using C__Fundamentals.Topics.Collections;
using C__Fundamentals.Topics.Delegates;
using C__Fundamentals.Topics.ExceptionHandling;
using C__Fundamentals.Topics.Generics;
using C__Fundamentals.Topics.LINQ;
using C__Fundamentals.Topics.LINQ.Data;
using C__Fundamentals.Topics.OOPM;
using C__Fundamentals.Topics.OOPM.Banking_Application;
using C__Fundamentals.Topics.Practice_Problems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace C__Fundamentals.Basic
{

    internal class MainClass
    {
     

       
        public static void Main()
        {
            List<Company> companies =  DataInit.TestDataInit();
            Console.WriteLine($"count of companies is {companies.Count}");
            ExampleLinqQuestions.TestQuestions();
        }



    }
}
