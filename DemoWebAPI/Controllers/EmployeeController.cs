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
        public object Employee()
        {
            return EmployeeInfo.Get();
        }

        // 下列兩種方法，在實際建置使用時，擇一宣告撰寫即可
        // 方法一:
        // 加入[HttpPost]特徵
        // 回傳 string 型態
        [HttpPost]
        public string Employee(Employee emp)
        {
            return EmployeeInfo.New(emp.empNo, emp.empCode, emp.empName);
        }

        // 方法二:
        // 回傳資料型態使用 IHttpActionResult
        // 方法名稱宣告為Post 
        public IHttpActionResult Post(Employee emp)
        {
            return Ok(EmployeeInfo.New(emp.empNo, emp.empCode, emp.empName));
        }

        // 較不好的方式
        // 呼叫時使用 parameters，參數會在url後面，用[QueryString]的方式呈現
        [HttpPost]
        public string New(int empNo, string empCode, string empName)
        {
            string txt = $"EmpNo: {empNo}, EmpCode: {empCode}, EmpName: {empName}";
            return txt;
        }

    }
}
