using C__Fundamentals.Basic.Functions;
using C__Fundamentals.Topics.Arrays;
using C__Fundamentals.Topics.Collections;
using C__Fundamentals.Topics.ExceptionHandling;
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
        public static int maxNoOfAccounts = 3;
        static int currentAccountCounts = 0;
        static Account[] accounts = new Account[maxNoOfAccounts];

       
        public static void Main()
        {
            ExampleArrayList.TestArrayList();

        }



    }
}
