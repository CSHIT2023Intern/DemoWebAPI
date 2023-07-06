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

        // Post 新增employee
        [HttpPost]
        // 方法一 回傳 string 型態
        public string Employee(Employee emp)
        {
            return EmployeeInfo.New(emp.empNo, emp.empCode, emp.empName);
        }

        // 方法二 回傳資料型態使用 IHttpActionResult
        /*public IHttpActionResult Post(Employee emp)
        {
            return Ok(EmployeeInfo.New(emp.empNo, emp.empCode, emp.empName));
        }*/

        // 建立一個Employee's List
        /*private readonly List<Employee> employeeList = new List<Employee>
        {
        };

        [HttpPost]
        public string Post([FromBody] Employee emp)
        {
            // 新增employee
            employeeList.Add(emp);
            var newemp = $"Empno: {emp.empNo}, Empcode: {emp.empCode}, Empname: {emp.empName}";
            return newemp;
        }*/
    }

    // Employee class
    public class Employee
    {
        public int empNo { get; set; }
        public string empCode { get; set; }
        public string empName { get; set; }
    }
}
