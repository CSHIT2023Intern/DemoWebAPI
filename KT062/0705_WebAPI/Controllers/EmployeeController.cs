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
        [HttpGet]
        public object Employee()
        {
            return EmployeeInfo.Get();
        }
    }
}
