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
            public int EmpNo { get; set; }
            public string EmpCode { get; set; }
            public string EmpName { get; set; }
        }

        [HttpPost] // 新增 [HttpPost] 屬性修飾器
        public string New(Employee employee)
        {
            string result = $"EmpNo: {employee.EmpNo}, EmpCode: {employee.EmpCode}, EmpName: {employee.EmpName}";
            return result;
        }
    }
}