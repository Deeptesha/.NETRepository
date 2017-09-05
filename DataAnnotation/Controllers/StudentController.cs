using DataAnnotation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DataAnnotation.Controllers
{
    public class StudentController : Controller
    {
        // GET: Customer
        [HttpGet]
        public ActionResult Index ()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Student objstudent)
        {
            return View();
        }

    }
}