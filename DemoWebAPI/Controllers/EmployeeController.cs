using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using refs.EmployeeInformation;
using HttpGetAttribute = System.Web.Http.HttpGetAttribute;
using HttpPostAttribute = System.Web.Http.HttpPostAttribute;

namespace DemoWebAPI.Controllers
{
    public class EmployeeController : ApiController
    {
        [HttpGet]
        public object Employee()
        {
            return EmployeeInfo.Get();
        }

        [HttpPost]
        public object Employe()
        {
            return EmployeeInfo.New(17019,"App-01","Dev_01");
        }



    }   

       
    

}