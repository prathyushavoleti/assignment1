using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using CRUD_Operations.context;

namespace CRUD_Operations.Controllers
{
    public class studentController : Controller
    {
        CRUDDatabaseEntities db = new CRUDDatabaseEntities();
        // GET: student
        public ActionResult student(student s)
        {
           

                return View(s);
            
        }
        [HttpPost]
        public ActionResult Addstudent(student model)
        {
           
                
                
                student addst = new student();
            if (ModelState.IsValid)
            {
                addst.ID = model.ID;
                addst.Name = model.Name;
                addst.Email = model.Email;
                addst.Description = model.Description;
                addst.Mobile = model.Mobile;
                if (model.ID == 0)
                {
                    db.students.Add(addst);
                    db.SaveChanges();
                }
                else
                {
                    db.Entry(addst).State = EntityState.Modified;
                    db.SaveChanges();
                }


            }
            ModelState.Clear();
            return View("student");
        }
        public ActionResult studentlist()
        {
            var res = db.students.ToList();
            return View(res);
        }
        public ActionResult Delete(int id)
        {
            var res = db.students.Where(x => x.ID == id).First();
            db.students.Remove(res);
            db.SaveChanges();
            var list = db.students.ToList();


            return View("studentlist",list);
        }

    }
}