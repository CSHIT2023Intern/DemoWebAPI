using refs.EmployeeInformation;
using System.Web.Http;

{
    public class EmployeeController : ApiController
    {
        //  private static List<Employee> employees = new List<Employee>(); // 儲存新增的員工資料
        //  範例一 查尋資料
        [HttpGet]
        public object Employee()
        {
            return EmployeeInfo.Get();
        }

        // GET，查詢新增員工資訊
        /*       [HttpGet]
               public IEnumerable<Employee> Employee()
               {
                   return employees;
               }
       */
        // POST，新增員工資訊
        [HttpPost]
        /*public IHttpActionResult PostEmployee(Employee employee)
        {
            employees.Add(employee); // 將新增的員工資料加入到列表中
            return Ok(employee);
        }
        */
        //方法一:
        // 加入[HttpPost]特徵
        // 回傳 string 型態
        /*
         public string Employee(Employee emp)
         {
             return EmployeeInfo.New(emp.empNo, emp.empCode, emp.empName);
         }
       */
        // 方法二:
        // 回傳資料型態使用 IHttpActionResult
        // 方法名稱宣告為Post 

        public IHttpActionResult Post(Employee emp)
        {
            return Ok(EmployeeInfo.New(emp.empNo, emp.empCode, emp.empName));
        }

    }
    // 反序列化類別
    ///api/Employee
    // {"EmpNo":"0","EmpCode":"App-01","EmpName":"Dev_02"}
    /* public class Employee
     {
         public int EmpNo { get; set; }
         public string EmpCode { get; set; }
         public string EmpName { get; set; }
     }
    */
}

