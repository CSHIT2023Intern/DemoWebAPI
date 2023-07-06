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
        public string New(int empNo, string empCode, string empName)
        {
            string newEmp = $"EmpNo: {empNo}, EmpCode: {empCode}, EmpName: {empName}";
            return newEmp;
        }

        // 建立一個Employee's List
        /*private readonly List<Employee> employeeList = new List<Employee>
        {
        };*/

        // Post
        /*[httppost]
        public string post([frombody] employee employee)
        {
            // 新增employee
            employeelist.add(employee);
            var newemp = $"empno: {employee.empno}, empcode: {employee.empcode}, empname: {employee.empname}";
            return newemp;
        }*/
    }
    public class Employee
    {
        public int empNo { get; set; }
        public string empCode { get; set; }
        public string empName { get; set; }
    }
}
