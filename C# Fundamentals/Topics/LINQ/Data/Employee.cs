using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Fundamentals.Topics.LINQ.Data
{
    public class Employee
    {
        public string FullName { get; set; }
        public int Age { get; set; }
        public decimal? Salary { get; set; }
        public bool IsRemote { get; set; }

        public  override string ToString()
        {
            var salaryText = Salary.HasValue ? Salary.Value.ToString("C") : "N/A";
            return $"FullName: {FullName}, Age: {Age}, Salary: {Salary:C}, IsRemote: {IsRemote}";
        }
         
        
    }
}
