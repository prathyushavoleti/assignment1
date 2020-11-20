using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WEBMVC.Models;
using System.Net.Http;
namespace WEBMVC.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            IEnumerable<EmployeeModel> emplist;
            HttpResponseMessage response = GlobalVariables.webhttpclient.GetAsync("Employee").Result;
            emplist = response.Content.ReadAsAsync<IEnumerable<EmployeeModel>>().Result;
            return View(emplist);
        }
        public ActionResult AddOrEdit(int id=0)
        {
            if(id==0)
            return View(new EmployeeModel());
            else
            {
                HttpResponseMessage response = GlobalVariables.webhttpclient.GetAsync("Employee"+id.ToString()).Result;
                return View(response.Content.ReadAsAsync<EmployeeModel>().Result);
            }
        }
        [HttpPost]
        public ActionResult AddOrEdit(EmployeeModel emp)
        {
            if (emp.EmployeeID == 0)
            {
            HttpResponseMessage response = GlobalVariables.webhttpclient.PostAsJsonAsync("Employee", emp).Result;
            TempData["SuccessMessage"] = "Saved Successfully";
            }
            else
            {
                HttpResponseMessage response = GlobalVariables.webhttpclient.PutAsJsonAsync("Employee"+emp.EmployeeID,emp).Result;
                TempData["SuccessMessage"] = "Updated Successfully";

            }
            return RedirectToAction("Index");
           
        }
        public ActionResult Delete(int id)
        {
            HttpResponseMessage response = GlobalVariables.webhttpclient.DeleteAsync("Employee/"+id.ToString()).Result;
            TempData["SuccessMessage"] = "Deleted Successfully";
            return RedirectToAction("Index");
        }
    }
}