using refs.EmployeeInformation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DemoWebAPI.Controllers
{
    public class EmployeeController : ApiController
    {
        [HttpGet]
        public object KT069()
        {
            return EmployeeInfo.Get();
        }

        [HttpPost]
        public IHttpActionResult PostEmployee([FromBody] Employee employee)
        {
            string result = $"EmpNo: {employee.EmpNo}, EmpCode: {employee.EmpCode}, EmpName: {employee.EmpName}";
            return Ok(result);
        }
    }

    public class Employee
    {
        public int EmpNo { get; set; }
        public string EmpCode { get; set; }
        public string EmpName { get; set; }
    }
}