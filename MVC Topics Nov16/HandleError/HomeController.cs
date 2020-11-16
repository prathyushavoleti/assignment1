using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace handleError.Controllers
{
   
    public class HomeController : Controller
    {
       
        public ActionResult Index()
        {
            
                throw new Exception("this is an exception");
           
            
        }
        public ActionResult About()
        {

            throw new Exception("this is an exception");


        }
    }
}