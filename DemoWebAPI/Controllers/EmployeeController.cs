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
        //可以讀取剛創建的資料，但並非與原始資料一起
        private static List<Employee> employees = new List<Employee>();

        //[HttpGet]
        //public object Employee1()
        //{
        //    return EmployeeInfo.Get();
        //}

        [HttpGet]
        public object Employee2()
        {
            //EmployeeInfo.Get()
            return Ok(employees); //可以讀取剛創建的資料，但並非與原始資料一起
        }


        [HttpPost]
        public IHttpActionResult POST(Employee employee)
        {
            var result = "EmpNo:" + employee.EmpNo + "," + "EmpCode:" + employee.EmpCode + "," + "EmpName:" + employee.EmpName;
            employees.Add(employee);//可以讀取剛創建的資料，但並非與原始資料一起
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
