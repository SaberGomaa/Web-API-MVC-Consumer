﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using Web_API_MVC_Consumer.Models;

namespace Web_API_MVC_Consumer.Controllers
{
    public class DepartmentController : Controller
    {
        // GET: Department
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult view()
        {
            HttpClient client = new HttpClient();
            var result = client.GetAsync("http://localhost:82/api/department").Result;

            if (result.IsSuccessStatusCode)
            {
                var depts = result.Content.ReadAsAsync<List<Department>>().Result;
                return View(depts);
            }
            else
            {
                return RedirectToAction("NotFound");
            }

        }
        public ActionResult Edit(int Id)
        {
            HttpClient client = new HttpClient();
            var result = client.GetAsync($"http://127.0.0.1:82/api/department/{Id}").Result;

            if (result.IsSuccessStatusCode)
            {
                var dept = result.Content.ReadAsAsync<Department>().Result;
                return View(dept);
            }
            else
            {
                return View("view");
            }
        }
    }
}