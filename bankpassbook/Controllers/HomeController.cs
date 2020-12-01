using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BankPassbook;
using BankPassbook.Models;

namespace BankPassbook.Controllers
{
    public class HomeController : Controller
    {
        Bank_ManagementEntities BM = new Bank_ManagementEntities();
        List<account> a = new List<account>();
        // GET: Home
        public ActionResult Index()
        {
            return View(BM.accounts);
        }
        public ActionResult Index1()
        {
            return View(BM.accountSummaries);
        }
        public ActionResult login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult login(login model)
        {
            if (model.Acc_No == 100112345678 && model.Password == "prathyu@123")
            {
                return RedirectToAction("Account_Summary");
            }
            if(model.Acc_No== 100112345679 && model.Password == "harika123")
            {
                return RedirectToAction("Account_Summary");
            }
            if (model.Acc_No == 100112345680 && model.Password == "Ahanth123")
            {
                return RedirectToAction("Account_Summary");
            }
            if (model.Acc_No == 100112345681 && model.Password == "haritha123")
            {
                return RedirectToAction("Account_Summary");
            }
            if (model.Acc_No == 100112345682 && model.Password == "sindhu123")
            {
                return RedirectToAction("Account_Summary");
            }
            else
                return View();
        }
        public ActionResult Account_Summary()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Account_Summary(accountSummary models)
        {
            if (models.accountNumber == 100000006 )
            {
                return RedirectToAction("user1");
            }
            if (models.accountNumber == 100000007)
            {
                return RedirectToAction("user2");
            }
            if (models.accountNumber == 100000008 )
            {
                return RedirectToAction("user3");
            }
            if (models.accountNumber == 100000009 )
            {
                return RedirectToAction("user4");
            }
           
            if (models.accountNumber == 100000010 )
            {
                return RedirectToAction("user5");
            }
            if (models.accountNumber == 100000011 )
            {
                return RedirectToAction("user6");
            }
            if (models.accountNumber == 100000012)
            {
                return RedirectToAction("user7");
            }
            if (models.accountNumber == 100000013)
            {
                return RedirectToAction("user8");
            }
            if (models.accountNumber == 100000014 )
            {
                return RedirectToAction("user9");
            }
            if (models.accountNumber == 100000015)
            {
                return RedirectToAction("user10");
            }
            
            return View();
        }
        public ActionResult user1()
        {
            var data = BM.accounts.SqlQuery("select * from accounts where Acc_no=100000006 ");
            return View(data);
        }
        public ActionResult user2()
        {
            var data = BM.accounts.SqlQuery("select * from accounts where Acc_no=100000007 ");
            return View(data);
        }
        public ActionResult user3()
        {
            var data = BM.accounts.SqlQuery("select * from accounts where Acc_no=100000008 ");
            return View(data);
        }
        public ActionResult user4()
        {
            var data = BM.accounts.SqlQuery("select * from accounts where Acc_no=100000009 ");
            return View(data);
        }
        public ActionResult user5()
        {
            var data = BM.accounts.SqlQuery("select * from accounts where Acc_no=100000010 ");
            return View(data);
        }
        public ActionResult user6()
        {
            var data = BM.accounts.SqlQuery("select * from accounts where Acc_no=100000011 ");
            return View(data);
        }
        public ActionResult user7()
        {
            var data = BM.accounts.SqlQuery("select * from accounts where Acc_no=100000012 ");
            return View(data);
        }
        public ActionResult user8()
        {
            var data = BM.accounts.SqlQuery("select * from accounts where Acc_no=100000013 ");
            return View(data);
        }
        public ActionResult user9()
        {
            var data = BM.accounts.SqlQuery("select * from accounts where Acc_no=100000014 ");
            return View(data);
        }
        public ActionResult user10()
        {
            var data = BM.accounts.SqlQuery("select * from accounts where Acc_no=100000015 ");
            return View(data);
        }

    }

}


