using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Transportation.Models;

namespace Transportation.Controllers
{
    public class StatisticController : Controller
    {
        // GET: Statistic
        DBTransportEntities1 db = new DBTransportEntities1();
        public ActionResult Index()
        {
            //viewbag - viewdata - tempdata
            var value1 = db.TblCustomer.Count();
            ViewBag.v1 = value1;
            ViewBag.customerCount = db.TblCustomer.Count();
            ViewBag.cityAnkara = db.TblCustomer.Where(x => x.CustomerCity == "Ankara").Count();
            ViewBag.categoryCount = db.TblCategory.Count();
            ViewBag.select = db.TblCustomer.Where(x => x.CustomerID == 1).Select(y => y.CustomerCity).FirstOrDefault();
            return View();
        }
    }
}