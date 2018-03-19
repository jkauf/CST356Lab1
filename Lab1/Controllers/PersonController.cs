using Lab1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab1.Controllers
{
    public class PersonController : Controller
    {
        // GET: Person
        public ActionResult Index()
        {
            Person person = new Person();
            ViewBag.Title = "Person";
            ViewBag.FirstName = person.FirstName = "Julian";
            ViewBag.LastName = person.LastName = "Kaufman";

            return View();
        }
    }
}