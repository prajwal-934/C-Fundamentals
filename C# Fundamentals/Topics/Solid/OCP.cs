using C__Fundamentals.Topics.Solid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Fundamentals.Topics.Solid
{
    internal class OCP
    {
    }
    //classes , modules should be open for extension, but close for modification

    interface IAccount
    {
        double CalculateInterest(Account account);
    }

    public class Account
    {
        public string Name {  get; set; }
        public string Address { get; set; }
        public double Balance { get; set; }    

        // if we need to add new accountType it will be modifying the class solution for this is create interface
        //public double CalculateInterest(string accountType)
        //{
        //    if(accountType == "Saving")
        //    {
        //        return Balance * 0.3;
        //    }
        //    else
        //    {
        //        return Balance * 0.5;
        //    }
        //}
    }


    public class SavingAccount : IAccount
    {
        public double CalculateInterest(Account account)
        {
            return account.Balance * 0.3;
        }
    }

    public class OtherAccount : IAccount
    {
        public double CalculateInterest(Account account)
        {
            return account.Balance * 0.5;
        }
    }

    public class  CurrentAccount : IAccount
    {
        public double CalculateInterest(Account account)
        {
            return account.Balance * 0.7;
        }
    }
}