using System;
using System.Collections.Generic;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of a company. Name it whatever you like.
            List<Employee> employees = new List<Employee>();

            // Create three employees
            Employee firstEmployee = new Employee();
            firstEmployee.FirstName = "Lauren";
            firstEmployee.LastName = "Maxwell";
            firstEmployee.Title = "CEO";
            firstEmployee.StartDate = new DateTime(2016, 06, 04);

            Employee secondEmployee = new Employee();
            secondEmployee.FirstName = "McGarrett";
            secondEmployee.LastName = "Maxwell";
            secondEmployee.Title = "Pet";
            secondEmployee.StartDate = new DateTime(2018, 07, 04);

            Employee thirdEmployee = new Employee();
            thirdEmployee.FirstName = "Dylan";
            thirdEmployee.LastName = "Pickle";
            thirdEmployee.Title = "COO";
            thirdEmployee.StartDate = new DateTime(2019, 09, 24);

            // Assign the employees to the company
            Company company = new Company("McGarrett's Adventures", new DateTime(2019, 09, 04));
            company.Employees.Add(firstEmployee);
            company.Employees.Add(secondEmployee);
            company.Employees.Add(thirdEmployee);


            /*
                Iterate the company's employee list and generate the
                simple report shown above
            */
            foreach (Employee employee in company.Employees)
            {
                Console.WriteLine($"{employee.FirstName} {employee.LastName} works for {company.CompanyName} as a {employee.Title}.");

            }
        }
    }
}