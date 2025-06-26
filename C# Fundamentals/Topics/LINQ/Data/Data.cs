using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Fundamentals.Topics.LINQ.Data
{
    public static class Data
    {
        public static List<Employee> GetEmployees()
        {
           List<Employee> employees = new List<Employee>();
            Employee employee = new Employee
            {
                Id = 1,
                FirstName = "Bob",
                LastName = "Jones",
                AnnualSalary = 60000,
                IsManager = true,
                DepartmentID = 1
            };
            employees.Add(employee);

            employee = new Employee
            {
                Id = 2,
                FirstName = "Eren",
                LastName = "Yeager",
                AnnualSalary = 40000,
                IsManager = false,
                DepartmentID = 2
            };
            employees.Add(employee);
            employee = new Employee
            {
                Id = 3,
                FirstName = "Armin",
                LastName = "Arlet",
                AnnualSalary = 30000,
                IsManager = false,
                DepartmentID = 3
            };
            employees.Add(employee);    
            employee = new Employee
            {
                Id = 4,
                FirstName = "Annie",
                LastName = "Arlet",
                AnnualSalary = 50000,
                IsManager = false,
                DepartmentID = 2
            };
            employees.Add(employee);
            return employees;
        }

        public static List<Department> GetDepartments()
        {
            List<Department> departments = new List<Department>();
            Department department = new Department
            {
                ID = 1,
                ShortName = "HR",
                LongName = "Human Resources"
            };
            departments.Add(department);
            department = new Department
            {
                ID = 2,
                ShortName = "FI",
                LongName = "Finance"
            };
            departments.Add(department);
            department = new Department
            {
                ID = 3,
                ShortName = "TN",
                LongName = "Technology"
            };
            departments.Add(department);
            department = new Department
            {
                ID = 4,
                ShortName = "SL",
                LongName = "Sales"
            };
            departments.Add(department);

            return departments;

        }
    }
}
