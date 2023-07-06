using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Newtonsoft.Json;
using refs.EmployeeInformation;

namespace DemoWebAPI.Controllers
{
    public class EmployeeController : ApiController
    {
        private static List<Employee> employees = new List<Employee>(); // 儲存新增的員工資料
/*      範例一 查尋資料
        [HttpGet]
        public object Employee()
        {
            return EmployeeInfo.Get();
        }
*/
        // GET，查詢新增員工資訊
        [HttpGet]
        public IEnumerable<Employee> Employee()
        {
            return employees;
        }
        // POST，新增員工資訊
        [HttpPost]
        public IHttpActionResult PostEmployee([FromBody] Employee employee)
        {
            employees.Add(employee); // 將新增的員工資料加入到列表中
            return Ok(employee);
        }
    }
    // 反序列化類別
    ///api/Employee
    // {"EmpNo":"0","EmpCode":"App-01","EmpName":"Dev_02"}
    public class Employee
    {
        public int EmpNo { get; set; }
        public string EmpCode { get; set; }
        public string EmpName { get; set; }
    }
}

