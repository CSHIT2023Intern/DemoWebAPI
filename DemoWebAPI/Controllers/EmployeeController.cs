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
        private static List<Employee> employees = new List<Employee>();

        [HttpGet]
        public IHttpActionResult GetAllEmployees()
        {
            var allEmployees = EmployeeInfo.Get();
            var combinedEmployees = allEmployees.Concat(employees).ToList();
            return Ok(combinedEmployees);
        }

        [HttpGet]
        public IHttpActionResult GetEmployeeById(int id)
        {
            var allEmployees = EmployeeInfo.Get();
            var employee = allEmployees.Concat(employees).FirstOrDefault(e => e.empNo == id);
            if (employee == null)
            {
                return NotFound();
            }
            return Ok(employee);
        }

        [HttpPost]
        public IHttpActionResult CreateEmployee(Employee employee)
        {
            employees.Add(employee);
            return CreatedAtRoute("DefaultApi", new { id = employee.empNo }, employee);
        }

        [HttpPut]
        public IHttpActionResult UpdateEmployee(int id, Employee updatedEmployee)
        {
            var employee = employees.Find(e => e.empNo == id);
            if (employee == null)
            {
                return NotFound();
            }
            employee.empCode = updatedEmployee.empCode;
            employee.empName = updatedEmployee.empName;
            return Ok(employee);
        }

        [HttpDelete]
        public IHttpActionResult DeleteEmployee(int id)
        {
            var employee = employees.Find(e => e.empNo == id);
            if (employee == null)
            {
                return NotFound();
            }
            employees.Remove(employee);
            return Ok();
        }
    }
}
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Net;
//using System.Net.Http;
//using System.Web.Http;
//using refs.EmployeeInformation;

//namespace DemoWebAPI.Controllers
//{
//    public class EmployeeController : ApiController
//    {
//        //public class Employee
//        //{
//        //    public int empNo { get; set; }
//        //    public string empCode { get; set; }
//        //    public string empName { get; set; }
//        //}
//        //public static List<Employee> _employee = new List<Employee>();
//        [HttpGet]
//        public object Employee()
//        {
//            return EmployeeInfo.Get();
//        }

//        //public object EmployeeGet()
//        //{
//        //    Employee _employee = new Employee();
//        //    var employeeData = EmployeeInfo.Get();
//        //    List<Employee> employees = employeeData.Select(e => new Employee
//        //    {
//        //        empNo = e.empNo,
//        //        empCode = e.empCode,
//        //        empName = e.empName,

//        //    }).ToList();
//        //    return employees;
//        //}

//        [HttpPost]
//        public string Employee(Employee emp)
//        {
//            return EmployeeInfo.New(emp.empNo, emp.empCode, emp.empName);
//        }

//        //public IHttpActionResult Post([FromBody] Employee employee)
//        //{

//        //    string result = $"EmpNo: {employee.empNo}, EmpCode: {employee.empCode}, EmpName: {employee.empName}";
//        //    return Ok(result);
//        //}

//        //public IHttpActionResult Insert([FromBody] Employee parameter)
//        //{
//        //    _employee.Add(new Employee
//        //    {
//        //        empNo = parameter.empNo,
//        //        empCode = parameter.empCode,
//        //        empName = parameter.empName
//        //    });
//        //    string result = $"EmpNo: {parameter.empNo}, EmpCode: {parameter.empCode}, EmpName: {parameter.empName}";
//        //    return Ok(result);
//        //}
//    }
//}
