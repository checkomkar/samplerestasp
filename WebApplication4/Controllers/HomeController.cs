using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Script.Serialization;

namespace WebApplication4.Controllers
{
    public class Student
    {
        public string name { get; set; }
        public string number { get; set; }
    }
    public class HomeController : ApiController
    {
        [HttpPost]
        public HttpResponseMessage AddEmpDetails()
        {
            var employee = new Dictionary<string, string>  { { "name", "name1" }, { "number" , "1" } };
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            
            var response = Request.CreateResponse(HttpStatusCode.OK);            
            response.Content = new StringContent(serializer.Serialize(employee), System.Text.Encoding.UTF8, "application/json");
            
            return response;
            //write insert logic  

        }
        [HttpGet]
        public string GetEmpDetails()
        {
            return "Omkar";

        }
        [HttpDelete]
        public string DeleteEmpDetails(string id)
        {
            return "Employee details deleted having Id " + id;

        }
        [HttpPut]
        public string UpdateEmpDetails(string Name, String Id)
        {
            return "Employee details Updated with Name " + Name + " and Id " + Id;

        }
    }
}
