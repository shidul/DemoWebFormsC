using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Services;
using System.Web.Services;

namespace DemoWebFormsC
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat=ResponseFormat.Json)]
        public List<Employee> getEmployee()
        {
            var abc= new List<Employee>
            {
                new Employee { empId = 1, empName = "scott", mobile = "0188" },
                new Employee { empId = 1, empName = "scott", mobile = "0188" },
                new Employee { empId = 1, empName = "scott", mobile = "0188" }
            };

            return abc;


        }
        
    }

    public class Employee
    {

        public int empId{get;set;}
        public string empName{get;set;}
        public string mobile{get;set;}
    }
}
