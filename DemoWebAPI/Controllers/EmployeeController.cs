using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using refs.EmployeeInformation;

namespace DemoWebAPI.Controllers
{
    public class EmployeeController : ApiController
    {
        List<Employee> employees = new List<Employee>();
        [HttpGet]
        public object Employee()
        {
            employees = EmployeeInfo.Get();
            return employees;
        }
        
        [HttpPost]
        public string New(int empNO, string empCode, string empName)
        {
            return "post";
            /*Employee newEmployee = new Employee(empNo, empCode, empName);
            EmployeeData.Employees.Add(newEmployee);
            string result = $"\"EmpNo\":{empNo},\"empCode\":\"{empCode}\",\"empName\":\"{empName}\"";
            return result;*/
        }
    }    
}
