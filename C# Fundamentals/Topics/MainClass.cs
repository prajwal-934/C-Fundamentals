using C__Fundamentals.Basic.Functions;
using C__Fundamentals.Topics.Arrays;
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

       
        static void Main()
        {
            Account account1 = new SavingsAccount("Sam", 10000);
            Account account2 = new SavingsAccount("Maddy", 20000);
            Account account3 = new SavingsAccount("Rina", 30000);

            account1.Withdraw(5000);
            account1.DisplayAccountInfo();
            

        }
    }
}
