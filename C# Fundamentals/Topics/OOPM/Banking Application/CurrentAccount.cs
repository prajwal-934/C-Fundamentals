using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Fundamentals.Topics.OOPM.Banking_Application
{
    internal class CurrentAccount : Account
    {
        public CurrentAccount( string customerName, double initialBalance) : base(customerName, initialBalance)
        {
        }

        public override void Withdraw(double amount)
        {
            if(amount <= balance)
            {
                balance -= amount;
                Console.WriteLine($"Withdraw amount is {amount} and remaining balance is {balance}");
            }else if(amount < 0)
            {
                Console.WriteLine($"Please enter valid amount value");
            }
            else
            {
                Console.WriteLine("Insufficient balance");
            }
        }
    }
}
