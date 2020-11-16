using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FirstDBApproach.Models;

namespace FirstDBApproach.Controllers
{
    public class HomeController : Controller
    {
        Database1Entities db = new Database1Entities();
        // GET: Home
        public ActionResult Index()
        {
            return View(db.tblcategories);
        }
        public ViewResult Index1()
        {
            return View(db.tblProducts);
        }
    }
}