using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Transportation.Models;

namespace Transportation.Controllers
{
    public class SettingsController : Controller
    {
        // GET: Settings
        DBTransportEntities1 db = new DBTransportEntities1();
        [HttpGet]
        public ActionResult Index()
        {
            var values = Session["username"];
            var userValue = db.TblAdmin.Where(x => x.Username == values).FirstOrDefault();
            return View(userValue);
        }

        [HttpPost]
        public ActionResult Index(TblAdmin tblAdmin)
        {
            return View();
        }
    }
}