using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Transportation.Models;

namespace Transportation.Controllers
{
    public class AdminHomeController : Controller
    {
        // GET: AdminHome
        DBTransportEntities1 db = new DBTransportEntities1();
        public ActionResult Index()
        {
            var customerCount = db.TblCustomer.Count();
            var categoryCount = db.TblCategory.Count();
            var employeeCount = db.TblEmployee.Count();
            var productCount = db.TblProduct.Count();
            var cityCount = db.TblCustomer.Select(x => x.CustomerCity).Distinct().Count();            
            ViewBag.customerCountLabel = "Müşteri Sayısı";
            ViewBag.customerCount = customerCount;
            ViewBag.categoryCountLabel = "Kategori Sayısı";
            ViewBag.categoryCount = categoryCount;
            ViewBag.employeeCountLabel = "Personel Sayısı";
            ViewBag.employeeCount = employeeCount;
            ViewBag.productCountLabel = "Ürün Sayısı";
            ViewBag.productCount = productCount;
            ViewBag.cityCountLabel = "Ulaşılan İl Sayısı";
            ViewBag.cityCount = cityCount;
            ViewBag.cityAnkara = db.TblCustomer.Where(x => x.CustomerCity == "Ankara").Count();
            ViewBag.citySakarya = db.TblCustomer.Where(x => x.CustomerCity == "Sakarya").Count();
            ViewBag.cityİstanbul = db.TblCustomer.Where(x => x.CustomerCity == "İstanbul").Count();
            ViewBag.cityİzmir = db.TblCustomer.Where(x => x.CustomerCity == "İzmir").Count();
            ViewBag.cityErzurum = db.TblCustomer.Where(x => x.CustomerCity == "Erzurum").Count();
            ViewBag.cityTrabzon = db.TblCustomer.Where(x => x.CustomerCity == "Trabzon").Count();
            ViewBag.cityBursa = db.TblCustomer.Where(x => x.CustomerCity == "Bursa").Count();
            return View();
        }
        public PartialViewResult Statistic()
        {
            return PartialView();
        }
        public PartialViewResult ProgressBar()
        {
            return PartialView();
        }

        public PartialViewResult CitiesTable()
        {
            return PartialView();
        }
    }
}