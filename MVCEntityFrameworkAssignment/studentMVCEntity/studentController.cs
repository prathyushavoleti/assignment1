using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using studentEntity.Models;
namespace studentEntity.Controllers
{
    public class studentController : Controller
    {
        StudentContext sc = new StudentContext();
        public ViewResult Index1()
        {
            return View(sc.StudentTable.ToList());
        }
        // GET: student
        public ActionResult Index()
        {
            return View();
        }
    }
}