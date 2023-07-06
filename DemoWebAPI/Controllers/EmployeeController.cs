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
        //public class Employee
        //{
        //    public int empNo { get; set; }
        //    public string empCode { get; set; }
        //    public string empName { get; set; }
        //}
        //public static List<Employee> _employee = new List<Employee>();
        [HttpGet]
        public object Employee()
        {
            return EmployeeInfo.Get();
        }

        //public object EmployeeGet()
        //{
        //    Employee _employee = new Employee();
        //    var employeeData = EmployeeInfo.Get();
        //    List<Employee> employees = employeeData.Select(e => new Employee
        //    {
        //        empNo = e.empNo,
        //        empCode = e.empCode,
        //        empName = e.empName,

        //    }).ToList();
        //    return employees;
        //}

        [HttpPost]
        public string Employee(Employee emp)
        {
            return EmployeeInfo.New(emp.empNo, emp.empCode, emp.empName);
        }

        //public IHttpActionResult Post([FromBody] Employee employee)
        //{

        //    string result = $"EmpNo: {employee.empNo}, EmpCode: {employee.empCode}, EmpName: {employee.empName}";
        //    return Ok(result);
        //}

        //public IHttpActionResult Insert([FromBody] Employee parameter)
        //{
        //    _employee.Add(new Employee
        //    {
        //        empNo = parameter.empNo,
        //        empCode = parameter.empCode,
        //        empName = parameter.empName
        //    });
        //    string result = $"EmpNo: {parameter.empNo}, EmpCode: {parameter.empCode}, EmpName: {parameter.empName}";
        //    return Ok(result);
        //}
    }
}
