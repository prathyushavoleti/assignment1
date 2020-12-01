using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using bankpassbook1.Models;
namespace bankpassbook1.Controllers
{
    public class passbookController : Controller
    {
        MvcCudEntities1 BM = new MvcCudEntities1();
        
        // GET: passbook
        public ActionResult Account_Summary()
        {
            return View();
        }
        //posting data into table and fetching the data
        [HttpPost]
        public ActionResult Account_Summary(Transcation model)
        {
            BM.Transcations.Add(model);
            if (model.PayeeAccountNo == 186745004532)
            {
                return RedirectToAction("user1");
            }
            if (model.PayeeAccountNo == 132745321276)
            {
                return RedirectToAction("user2");
            }
            if (model.PayeeAccountNo == 886745004532)
            {
                return RedirectToAction("user3");
            }
            if (model.PayeeAccountNo == 032745321276)
            {
                return RedirectToAction("user4");
            }
            return View();
        }
        //fetching the data of each user by passing query
        public ActionResult user1()
        {
            var data = BM.Transcations.SqlQuery("select * from Transcations where PayeeAccountNo=186745004532");
            return View(data);
        }
        public ActionResult user2()
        {
            var data = BM.Transcations.SqlQuery("select * from Transcations where PayeeAccountNo=186745004532");
            return View(data);
        }
        public ActionResult user3()
        {
            var data = BM.Transcations.SqlQuery("select * from Transcations where PayeeAccountNo=186745004532");
            return View(data);
        }
        public ActionResult user4()
        {
            var data = BM.Transcations.SqlQuery("select * from Transcations where PayeeAccountNo=186745004532");
            return View(data);
        }
    }
}