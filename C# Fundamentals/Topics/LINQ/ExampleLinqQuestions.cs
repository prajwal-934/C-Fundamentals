using C__Fundamentals.Topics.LINQ.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Fundamentals.Topics.LINQ
{
    internal class ExampleLinqQuestions
    {

        public static void TestQuestions()
        {
            List<Company> companies = DataInit.TestDataInit();
            var result = companies.SelectMany((company)=>company.Departments).ToList();

            //get all employees
            //return all emp names
            var allEmployees = companies
                .SelectMany((company) => company.Departments)
                .SelectMany((department) => department.Employees)
                .Select((employee) => employee.FullName);


            //return all distinct by emp name objs
            var ae = companies.SelectMany((company) => company.Departments)
                .SelectMany((department) => department.Employees)
                .DistinctBy((employee) => employee.FullName);


            //get list for employess working remotely
            var remoteEmployees =
                companies
                .SelectMany((company) => company.Departments)
                .SelectMany((department) => department.Employees)
                .Where((employee) => employee.IsRemote = true);

            //get avg salary from each dept
            var AvgDeptSalary =
                companies.SelectMany((company) => company.Departments)
                .Where((department)=>department.Name == "Support")
                .Select((department) => new
                {
                    Department = department.Name,
                    AvgSalary = department.Employees.Average((employee) => employee.Salary)
                });

            //. Find departments with more than one employee
            var bigDept =
                companies.SelectMany((company) => company.Departments)
                .Where((department) => department.Employees.Count > 1)
                .Select((department) => department.Name);


            var groupedByRemote = companies
                .SelectMany(c => c.Departments)
                .SelectMany(d => d.Employees)
                .GroupBy(e => e.IsRemote);


            var groupedByAgeRange = companies
                .SelectMany(c => c.Departments)
                .SelectMany(d => d.Employees)
                .GroupBy(e =>
                    e.Age < 30 ? "Under 30" :
                    e.Age < 40 ? "30s" : "40+");

            //group by company name than dept name

            var groupDeptAndCompany =
                companies.
                Select(c => new
                {
                    c.Name,
                    Departments = c.Departments.
                    GroupBy(d => d.Name)
                });

            //SET

            var remoteEmp =
                companies.SelectMany((company) => company.Departments)
                .SelectMany(dept => dept.Employees)
                .Where(e => e.IsRemote);

            var onSiteEmp =
                companies.SelectMany((company) => company.Departments)
                .SelectMany(dept => dept.Employees)
                .Where(e => e.IsRemote == false);

            //select remote emp from finance and engg dept

            var remoteDeptEmp =
                companies
                .SelectMany((company) => company.Departments)
                .Where((dept) => dept.Name == "Finance" || dept.Name == "Engineering")
                .Select(d => new
                {
                    d.Name,
                    RemoteEmployees = d.Employees.Where(e => e.IsRemote)
                });


            var duplicates = companies
            .SelectMany(c => c.Departments)
            .SelectMany(d => d.Employees)
            .GroupBy(e => e.FullName)
            .Where(g => g.Count() > 1)
            .SelectMany(g => g);

            var test = companies.SelectMany((c) => c.Departments);
            


            Console.WriteLine("---remote---");
            foreach (var item in remoteDeptEmp)
            {
                Console.WriteLine(item.Name);
                foreach (var item1 in item.RemoteEmployees)
                {
                    Console.WriteLine(item1.ToString());
                }
            }
            var allEmp = remoteEmp.Union(onSiteEmp);

            var test1 = companies
            .SelectMany(c => c.Departments)
            .SelectMany(d => d.Employees, (d, e) => new { Dept = d.Name, Emp = e })
            .Where(x => x.Emp.IsRemote);

            foreach (var item in test1)
            {
                Console.WriteLine(item.Dept+ " Emp Details is "+ item.Emp.ToString());
            }





            Console.WriteLine("Union of emp count "+allEmp.Count());

            Console.WriteLine("Count of remote emp "+remoteEmp.Count());


            Console.WriteLine("Type of "+allEmployees.GetType());
            Console.WriteLine("----result-----");
            //foreach (var item in AvgDeptSalary)
            //{
            //    Console.WriteLine($"Department name is {item.Department} and Avg Salary is {item.AvgSalary}");
            //}

            //foreach (var boolGroup in groupedByRemote)
            //{
            //    Console.WriteLine(boolGroup.Key ?  "Working Remotely" : "Working On-Site");
            //    foreach (var item in boolGroup)
            //    {
            //        Console.WriteLine(item.ToString());
            //    }
            //}

            ////print group by age
            //foreach (var groups in groupedByAgeRange)
            //{
            //    Console.WriteLine("Age range is:"+groups.Key);
            //    foreach (var item in groups)
            //    {
            //        Console.WriteLine(item.ToString());
            //    }
            //}

            foreach (var item in groupDeptAndCompany)
            {

                Console.WriteLine("Company NAme is "+item.Name);
                foreach (var item1 in item.Departments)
                {
                    Console.WriteLine("Department name is "+ item1.Key);

                }
            }
        }
    }
}
