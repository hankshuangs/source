using System;
using System.Collections.Generic;
using System.Text;
using XamarinDemoApp.Models;

namespace XamarinDemoApp.Services
{
    public class EmployeeServices
    {

        public List<Employee> GetEmployees()
        {
            var list = new List<Employee>
            {
                new Employee
                {
                    Name = "Mohamed",
                    Department = "Marketing"
                },
                new Employee
                {
                    Name = "Hassen",
                    Department = "Sales"
                },
                new Employee
                {
                    Name = "Ahmed",
                    Department = "Finance"
                },
                new Employee
                {
                    Name = "Nader",
                    Department = "Sales"
                },
                new Employee
                {
                    Name = "Mohamed",
                    Department = "HR"
                },
                new Employee
                {
                    Name = "Saif",
                    Department = "Sales"
                },
                new Employee
                {
                    Name = "Mohamed",
                    Department = "Marketing"
                },
                new Employee
                {
                    Name = "Marwen",
                    Department = "HR"
                },
            };

            return list;
        }
    }
}
