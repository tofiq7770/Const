using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Const.Models;

namespace Const.Controllers
{
    internal class EmployeeController
    {
        public Employee[] GetAll()
        {
            Employee employee1 = new()
            {
                Name = "Ali",
                SureName = "Huseynov",
                Id = 1,
                Age = 19,
                Salary = 22220
            };
            Employee employee2 = new()
            {
                Name = "ALi",
                SureName = "Shukurlu",
                Id = 2,
                Age = 19,
                Salary = 2
            };
            Employee employee3 = new()
            {
                Name = "Ferid",
                SureName = "Kerimzade",
                Id = 3,
                Age = 18,
                Salary = 110
            };
            Employee employee4 = new()
            {
                Name = "Super",
                SureName = "Mario",
                Id = 4,
                Age = 40,
                Salary = 12
            };
            Employee[] employees = { employee1, employee2, employee3, employee4 };
            return employees;

        }
        public Employee[] FilteredEmployeesBySalary(decimal startsalary, decimal endsalary)
        {
            Employee[] employees = GetAll();
            return employees = employees.Where(x => x.Salary > 1000 && x.Salary < 2000).ToArray();
        }

        public Employee[] Sortemployees(string sorttext)
        {
            var employees = GetAll();
            if (sorttext == "asc")
                return employees.OrderBy(x => x.Salary).ToArray();

            return employees.OrderByDescending(x => x.Salary).ToArray();
        }
    }

}

