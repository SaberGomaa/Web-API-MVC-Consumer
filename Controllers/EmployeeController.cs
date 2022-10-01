using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using Web_API_MVC_Consumer.Models;

namespace Web_API_MVC_Consumer.Controllers
{
    public class EmployeeController : Controller
    {
        
        public HttpClient client = new HttpClient();

        public EmployeeController()
        {
            client.BaseAddress =new Uri("http://127.0.0.1:82/api/");
        }


    // GET: Employee
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult view()
        {
            var result = client.GetAsync("employee").Result;
            if (result.IsSuccessStatusCode)
            {
                var emps = result.Content.ReadAsAsync<List<Employee>>().Result;
                return View(emps);
            }
            else
            {
                return RedirectToAction("index");
            }
        }

        public ActionResult Edit(int Id)
        {
            return View(); 
        }

    }
}