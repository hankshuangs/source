using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using XamarinDemoApp.Models;
using XamarinDemoApp.RestClient;

namespace XamarinDemoApp.Services
{
    public class EmployeeServices
    {

        public async Task<List<Employee>> GetEmployeesAsync()
        {
            RestClient<Employee> restClient = new RestClient<Employee>();
            var employeesList = await restClient.GetAsync();
            return employeesList;
        }
    }
}
