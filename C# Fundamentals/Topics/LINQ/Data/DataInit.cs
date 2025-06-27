using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Fundamentals.Topics.LINQ.Data
{
    internal static class DataInit
    {
        public static List<Company> TestDataInit()
        {
            var companies = new List<Company>
            {
                new Company
                {
                    Name = "TechCorp",
                    Departments = new List<Department>
                    {
                        new Department
                        {
                            Name = "Engineering",
                            Manager = "Alice",
                            Employees = new List<Employee>
                            {
                                new Employee { FullName = "Evan Stone", Age = 28, Salary = 75000, IsRemote = true },
                                new Employee { FullName = "Jill Smith", Age = 35, Salary = 88000, IsRemote = false },
                                new Employee { FullName = "Omar Aziz", Age = 42, Salary = 99000, IsRemote = false }
                            }
                        },
                        new Department
                        {
                            Name = "HR",
                            Manager = "Bob",
                            Employees = new List<Employee>
                            {
                                new Employee { FullName = "Sara Jones", Age = 30, Salary = 60000, IsRemote = true },
                                new Employee { FullName = "Yuki Tanaka", Age = 32, Salary = 64000, IsRemote = true }
                            }
                        }
                    }
                },
                new Company
                {
                    Name = "BizGroup",
                    Departments = new List<Department>
                    {
                        new Department
                        {
                            Name = "Finance",
                            Manager = "Karen",
                            Employees = new List<Employee>
                            {
                                new Employee { FullName = "Tom Wells", Age = 45, Salary = 95000, IsRemote = false },
                                new Employee { FullName = "Nina Zhang", Age = 29, Salary = 67000, IsRemote = true },
                                new Employee { FullName = "Priya Kapoor", Age = 40, Salary = 88000, IsRemote = false }
                            }
                        },
                        new Department
                        {
                            Name = "Marketing",
                            Manager = "Daniel",
                            Employees = new List<Employee>
                            {
                                new Employee { FullName = "Lucas Green", Age = 27, Salary = 72000, IsRemote = true },
                                new Employee { FullName = "Mei Lin", Age = 33, Salary = 83000, IsRemote = true }
                            }
                        }
                    }
                },
                new Company
                {
                    Name = "InnoSoft",
                    Departments = new List<Department>
                    {
                        new Department
                        {
                            Name = "Product",
                            Manager = "Lena",
                            Employees = new List<Employee>
                            {
                                new Employee { FullName = "Samuel Cruz", Age = 38, Salary = 90000, IsRemote = true },
                                new Employee { FullName = "Maya Patel", Age = 26, Salary = 68000, IsRemote = true }
                            }
                        },
                        new Department
                        {
                            Name = "Support",
                            Manager = "Mark",
                            Employees = new List<Employee>
                            {
                                new Employee { FullName = "Victor Blanco", Age = 34, Salary = 58000, IsRemote = false },
                                new Employee { FullName = "Emily Carter", Age = 41, Salary = 69000, IsRemote = true }
                            }
                        }
                    }
                }
            };
            return companies;
        }
    }
}
