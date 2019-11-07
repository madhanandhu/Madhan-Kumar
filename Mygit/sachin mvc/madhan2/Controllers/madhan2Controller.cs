using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using madhan2.Models;

namespace madhan2.Controllers
{
    public class madhan2Controller : Controller
    {
        // GET: madhan2
        public ActionResult HOME()
        {
            
            return View();
        }
        public ActionResult ABOUT()
        {
            
            return View();
        }
        public ActionResult ADDRESS()
        {
            
            return View();
        }
        public ActionResult ACHIVE()
        {
            
            return View();
        }
        public ActionResult DATA(Madhan obj)
        {
            madhanEntities db = new madhanEntities();
            db.Madhans.Add(obj);
            db.SaveChanges();
            return View();
        }
    }
}