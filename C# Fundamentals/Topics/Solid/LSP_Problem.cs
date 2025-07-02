using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Fundamentals.Topics.Solid
{
    internal class LSP_Problem
    {

        public static void TestLSPIssue()
        {
            Emp emp = new Emp();
            Emp permanentEmp = new PermanentEmployee();
            Emp contractEmp = new ContractualEmployee();

            Console.WriteLine(emp.CalculateSalary());
            Console.WriteLine(emp.CalculateBonus());

            Console.WriteLine(permanentEmp.CalculateSalary());
            Console.WriteLine(permanentEmp.CalculateBonus());

            Console.WriteLine(contractEmp.CalculateSalary());
            Console.WriteLine(contractEmp.CalculateBonus());
        }
        //the lsp states that an object of a child class must be able to replace an object of the parent class without breaking the appilcaiton.
    }
    //scerio - we have permanent employee and contractual employee but conractural employee should not have any bonouses
    //Naming Employee to Emp due to namespace conflict

    public class Emp
    {
        public virtual int CalculateSalary()
        {
            return 100000;
        }

        public virtual int CalculateBonus()
        {
            return 500;
        }

    }

    public class PermanentEmployee : Emp
    {
        public override int CalculateSalary()
        {
            return 200000;
        }

        public override int CalculateBonus()
        {
            return 1500;
        }
    }

    public class ContractualEmployee : Emp
    {
        public override int CalculateSalary()
        {
            return 20000;
        }

        public override int CalculateBonus()
        {
            throw new NotImplementedException();
        }
    }

    


    }
