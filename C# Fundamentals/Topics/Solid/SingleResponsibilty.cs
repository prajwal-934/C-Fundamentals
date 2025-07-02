using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Fundamentals.Topics.Solid
{
    internal class SingleResponsibilty
    {
    }

    public class Employee
    {
        public string GetDetails()
        {
            return "Employee Name is John and salart is 213123";
        }

        public string GetDepartment()
        {
            return "IT";
        }

       // public string SaveToDB() { }
       //saving to db is not responsibility of Employee Class
    }
}
