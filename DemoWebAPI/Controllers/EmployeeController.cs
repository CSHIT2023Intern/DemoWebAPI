using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using refs.EmployeeInformation;
using Newtonsoft.Json;

namespace DemoWebAPI.Controllers
{
    public class EmployeeController : ApiController
    {
       /*static List<object> Employee = new List<object>()
       {
           new object(){empNo=17019,eMpCode=App-01,empName="Dev_01"}
       }*/
            
        [HttpGet]
        public object Employee()
        {
            return EmployeeInfo.Get();
        }
        /*[HttpPost]
        public HttpResponseMessage Post([FromBody]object Employee)
        {
            object.Add(Employee);
            return new HttpResponseMessage(HttpStatusCode.Created)
        }*/

        [HttpPost]
        public string New(int empNo, string empCode, string empName)
        {
            string txt = $"EmpNo: {empNo}, EmpCode: {empCode}, EmpName: {empName}";
            return txt;
        }

    }

    public class Employee
    {
        public int empNo { get; set; }
        public string empCode { get; set; }
        public string empName { get; set; }
    }
}