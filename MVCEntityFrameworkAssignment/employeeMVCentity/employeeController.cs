using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using employeeMVC.Models;
namespace employeeMVC.Controllers
{
    public class employeeController : Controller
    {
        employeecontext db = new employeecontext();
        public ViewResult Index1()
        {
            return View(db.EmployeeTable.ToList());
        }
        // GET: employee
        public ActionResult Index()
        {
            return View();
        }
    }
}