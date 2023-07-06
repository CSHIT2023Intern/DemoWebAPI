using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using refs.EmployeeInformation;

namespace _0705_WebAPI.Controllers
{
    public class EmployeeController : ApiController
    {
        // Get
        [HttpGet]
        public object Employee()
        {
            return EmployeeInfo.Get();
        }

        // 建立一個Employee's List
        private readonly List<Employee> employeeList = new List<Employee>
        {
        };

        // Post
        [HttpPost]
        public string Post([FromBody]Employee employee)
        {
            // 新增employee
            employeeList.Add(employee);
            //var newEmp = EmployeeInfo.New(int empNo, string empCode, string empName)->string;
            var newEmp = $"EmpNo: {employee.empNo}, EmpCode: {employee.empCode}, EmpName: {employee.empName}";
            return newEmp;
        }
    }
    public class Employee
    {
        public int empNo { get; set; }
        public string empCode { get; set; }
        public string empName { get; set; }
    }
}
