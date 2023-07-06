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
        [HttpGet]
        public object Employee()
        {
            return EmployeeInfo.Get();
        }

        [HttpPost]
        public string CreateEmployee(Employee employee)
        {
            int empNo = employee.empNo;
            string empCode = employee.empCode;
            string empName = employee.empName;

            string result = EmployeeInfo.New(empNo, empCode, empName);

            return result;
        }
    }
}
