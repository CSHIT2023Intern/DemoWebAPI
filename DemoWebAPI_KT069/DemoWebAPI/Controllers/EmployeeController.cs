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
        private static List<Employee> employees = new List<Employee>(); // 用于保存 Employee 数据

        [HttpGet]
        public object GetEmployees()
        {
            return employees;
        }

        [HttpPost]
        public IHttpActionResult PostEmployee([FromBody] Employee employee)
        {
            employees.Add(employee); // 将 Employee 对象添加到集合中
            return Ok(employee); // 返回添加的 Employee 对象作为响应
        }

        [HttpPut]
        public IHttpActionResult PutEmployee(int id, [FromBody] Employee updatedEmployee)
        {
            // 在集合中查找要更新的 Employee
            Employee employeeToUpdate = employees.FirstOrDefault(e => e.EmpNo == id);

            if (employeeToUpdate == null)
            {
                return NotFound(); // 如果找不到对应的 Employee，则返回 404 Not Found
            }

            // 更新 Employee 的属性
            employeeToUpdate.EmpCode = updatedEmployee.EmpCode;
            employeeToUpdate.EmpName = updatedEmployee.EmpName;

            return Ok(employeeToUpdate); // 返回更新后的 Employee 对象作为响应
        }
    }

    public class Employee
    {
        public int EmpNo { get; set; }
        public string EmpCode { get; set; }
        public string EmpName { get; set; }
    }
}