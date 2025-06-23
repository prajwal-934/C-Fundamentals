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
        public static int maxNoOfAccounts = 3;
        static int currentAccountCounts = 0;
        static Account[] accounts = new Account[maxNoOfAccounts];

       
        static void Main()
        {
            int choice;
            try
            {
                do
                {
                    Console.WriteLine("==========Bank Menu==============");
                    Console.WriteLine("1. Create Savings Account");
                    Console.WriteLine("2. Create Current Account");
                    Console.WriteLine("3. Deposit");
                    Console.WriteLine("4. Withdraw");
                    Console.WriteLine("5. View Account Info");
                    Console.WriteLine("6. Delete Account");
                    Console.WriteLine("7. Exit");
                    Console.WriteLine("Choose an option");
                    choice = Convert.ToInt32(Console.ReadLine());

                    switch (choice)
                    {
                        case 1: CreateAccount("Saving"); break;
                        case 2: CreateAccount("Current"); break;
                        case 3: DepositAmount(); break;
                        case 4: WithdrawAmount(); break;
                        case 5: ViewAccountDetails(); break;
                        case 6: DeleteAccount(); break;
                        case 7: Console.WriteLine("Exiting..."); break;

                        default:
                            break;
                    }

                }
                while (choice != 7);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }

        static Account FindAccount(int accountNumber)
        {

            for (int i = 0; i < maxNoOfAccounts; i++)
            {
                if (accounts[i] != null && accounts[i].GetAccountNumber() == accountNumber)
                {
                    return accounts[i];
                }
            }

            return null;
        }
        static void CreateAccount(string accountType)
        {
            string name;
            double initialBalance;
            try
            {
                if (currentAccountCounts <= maxNoOfAccounts)
                {
                    Console.WriteLine("Enter Your Name:");
                    name = Console.ReadLine();
                    Console.WriteLine("Enter initial balance");
                    initialBalance = Convert.ToDouble(Console.ReadLine());
                    if (accountType == "Saving")
                    {
                        accounts[currentAccountCounts] = new SavingsAccount(name, initialBalance);
                        Console.WriteLine($"Account created successfully your {accountType} account number is {accounts[currentAccountCounts].GetAccountNumber()}");
                        currentAccountCounts++;
                    }
                    else if (accountType == "Current")
                    {
                        accounts[currentAccountCounts] = new CurrentAccount(name, initialBalance);
                        Console.WriteLine($"Account created successfully your {accountType} account number is {accounts[currentAccountCounts].GetAccountNumber()}");
                        currentAccountCounts++;

                    }
                    else
                    {
                        Console.WriteLine("Invalid Account Type");
                    }
                }
                else
                {
                    Console.WriteLine($"Cannot create more than {maxNoOfAccounts} accounts");
                    return;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                
            }
        }
        static void DepositAmount()
        {
            Console.WriteLine("Enter account number");
            int accountNumber = Convert.ToInt32(Console.ReadLine());
            Account account = FindAccount(accountNumber);
            if (account == null)
            {
                Console.WriteLine("Account Not found");
                return;
            }
            Console.WriteLine("Enter amount to deposit");
            double depositAmount = Convert.ToDouble(Console.ReadLine());

            account.Deposit(depositAmount);
            Console.WriteLine("Deposit Successful");
   

        }

        static void WithdrawAmount()
        {
            Console.WriteLine("Enter your account number");
            int accountNumber = Convert.ToInt32(Console.ReadLine());

            Account account = FindAccount(accountNumber);
            if (account == null)
            {
                Console.WriteLine("Account not found");
                return;
            }
            double amount = Convert.ToDouble(Console.ReadLine());
            account.Withdraw(amount);
            Console.WriteLine("Amount withdrawal successful");
        }


        static void ViewAccountDetails()
        {
            Console.WriteLine("Enter your account number");
            int accountNumber = Convert.ToInt32(Console.ReadLine());

            Account account = FindAccount(accountNumber);
            if (account == null)
            {
                Console.WriteLine("Account not found");
                return;
            }

            account.DisplayAccountInfo();
        }

        static void DeleteAccount()
        {
            try
            {
                Console.WriteLine("Enter Account number to delete:");
                int accountNumber = Convert.ToInt32(Console.ReadLine());

                bool found = false;

                for (int i = 0; i < currentAccountCounts; i++)
                {
                    if (accounts[i] != null && accounts[i].GetAccountNumber() == accountNumber)
                    {
                        Console.Write("Are you sure you want to delete your account? (Y/N): ");
                        string confirmation = Console.ReadLine();

                        if (confirmation.Trim().ToUpper() == "Y")
                        {
                            accounts[i] = null;
                            Console.WriteLine("Account deleted successfully.");
                        }
                        else
                        {
                            Console.WriteLine("Account deletion canceled.");
                        }

                        found = true;
                        break;
                    }
                }

                if (!found)
                {
                    Console.WriteLine("Account not found.");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a valid account number.");
            }
        }


    }
}
