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
        public object Employee1()
        {
            return EmployeeInfo.Get();
        }

        [HttpPost]
        public IHttpActionResult POST(Employee employee)
        {
            var result = "EmpNo:" + employee.EmpNo + "," + "EmpCode:" + employee.EmpCode + "," + "EmpName:" + employee.EmpName;
            return Ok(result);
        }

        public class Employee
        {
            public int EmpNo { get; set; }
            public string EmpCode { get; set; }
            public string EmpName { get; set; }
        }
    }
}
