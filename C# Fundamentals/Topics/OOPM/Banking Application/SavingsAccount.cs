using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Fundamentals.Topics.OOPM.Banking_Application
{
    internal class SavingsAccount : Account
    {
        private double minBalance = 1000;
        public SavingsAccount( string customerName, double initialBalance) : base( customerName, initialBalance)
        {
        }

        public override void Withdraw(double amount)
        {
            if(balance-amount > minBalance && amount > 0)
            {
                balance -= amount;
                Console.WriteLine($"Withdraw amount is {amount} and remaining balance is {balance}");
            }else if(amount < 0)
            {
                Console.WriteLine("Please enter valid amount");
            }
            else
            {
                Console.WriteLine($"Balance is insufficient please maintain minimum {minBalance}");
            }
        }
    }
}
