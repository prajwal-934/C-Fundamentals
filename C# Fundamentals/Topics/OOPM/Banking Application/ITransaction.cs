using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Fundamentals.Topics.OOPM.Banking_Application
{
    internal interface ITransaction
    {
        public void Deposit(int amount);
        public void Withdraw(int amount);
    }
}
