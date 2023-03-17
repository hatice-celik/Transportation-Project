using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using Transportation.Models;

namespace Transportation.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        DBTransportEntities1 db = new DBTransportEntities1();
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(TblAdmin t)
        {
            var values = db.TblAdmin.Where(x => x.Username== t.Username & x.Password == t.Password).FirstOrDefault();
            if (values != null)
            {
                FormsAuthentication.SetAuthCookie(values.Username, false);
                Session["username"] = t.Username; 
                return RedirectToAction("Index","AdminHome");
            }
            return View();
        }
    }
}