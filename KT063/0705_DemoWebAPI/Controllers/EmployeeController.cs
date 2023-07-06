using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using refs.EmployeeInformation;

namespace _0705_DemoWebAPI.Controllers
{
    public class EmployeeController : ApiController
    {
        [HttpGet]
        public object Employee1()
        {
            return EmployeeInfo.Get();
        }

        public class Employee
        {
            public int empNo { get; set; }
            public string empCode { get; set; }
            public string empName { get; set; }
        }

        [HttpPost]
        public string New(Employee employee)
        {
            string result = $"EmpNo: {employee.empNo}, EmpCode: {employee.empCode}, EmpName: {employee.empName}";
            return result;
        }
    }
}