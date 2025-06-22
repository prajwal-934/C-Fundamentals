using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Fundamentals.Topics.OOPM.Banking_Application
{
    internal abstract class Account : ITransaction
    {
        protected int accountNumber;
        protected string customerName;
        protected double balance;
        private static int accountNumberSeed = 1000;

        public Account(string customerName, double initialBalance)
        {
            if(initialBalance < 0)
            {
                throw new ArgumentException("Initial Balance must be greater than zero");
            }
            this.accountNumber = ++accountNumberSeed;
            this.customerName = customerName;
            this.balance = initialBalance;
        }

        public int GetAccountNumber() => accountNumber;
        public string GetCustomerName() => customerName;
        public double GetBalance() => balance;

        public virtual void Deposit(double amount)
        {
            if (amount > 0)
            {
                balance += amount;
                Console.WriteLine($"Deposited amount: {amount}, New Balance: {balance}");
            }
        }

        public abstract void Withdraw(double amount);

        public void DisplayAccountInfo()
        {
            Console.WriteLine("---------Account Details----------");
            Console.WriteLine($"Account Number: {accountNumber}");
            Console.WriteLine($"Customer Name : {customerName}");
            Console.WriteLine($"Balance : {balance}");
            Console.WriteLine("-----------------------------------");
        }

    }
}
