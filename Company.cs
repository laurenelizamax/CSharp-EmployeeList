using System;
using System.Collections.Generic;

namespace Classes
{
    class Company
    {
        public string CompanyName { get; set; }
        public DateTime DateFounded { get; set; }
        public List<Employee> Employees { get; }

        public Company(string companyName, DateTime dateFounded)
        {
            CompanyName = companyName;
            DateFounded = dateFounded;
            Employees = new List<Employee>();
        }

    }

}