using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Transportation.Models;


namespace Transportation.Controllers
{
    [Authorize]
    public class CustomerController : Controller
    {
        // GET: Customer
        DBTransportEntities1 db = new DBTransportEntities1();
        public ActionResult Index()
        {
            //var values = db.TblCustomer.Where(x => x.CustomerCity == "taşkent").ToList();
            var values = db.TblCustomer.ToList();
            var customerCount = db.TblCustomer.Count();
            var categoryCount = db.TblCategory.Count();
            var employeeCount = db.TblEmployee.Count(); 
            var productCount=   db.TblProduct.Count();
            var cityCount = db.TblCustomer.Select(x => x.CustomerCity).Distinct().Count();
            ViewBag.customerCountLabel = "Müşteri Sayısı";
            ViewBag.customerCount = customerCount;
            ViewBag.categoryCountLabel = "Kategori Sayısı";
            ViewBag.categoryCount = categoryCount;
            ViewBag.employeeCountLabel = "Personel Sayısı";
            ViewBag.employeeCount = employeeCount;
            ViewBag.productCountLabel = "Ürün Sayısı";
            ViewBag.productCount = productCount;
            ViewBag.cityCountLabel = "Şehir Sayısı";
            ViewBag.cityCount = cityCount;
            return View(values);
        }
        public PartialViewResult Statistic()
        {
            return PartialView();
        }

        [HttpGet]
        public ActionResult AddCustomer()
        {
            return View();
        }

        [HttpPost]

        public ActionResult AddCustomer(TblCustomer tblCustomer)
        {
            db.TblCustomer.Add(tblCustomer);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult DeleteCustomer(int id)
        {
            var value = db.TblCustomer.Find(id);
            db.TblCustomer.Remove(value);
            db.SaveChanges();
            return RedirectToAction("Index");
        }


        [HttpGet]
        public ActionResult UpdateCustomer(int id) 
        {
            var value = db.TblCustomer.Find(id);
            return View(value);
        }
       
        [HttpPost]
        public ActionResult UpdateCustomer(TblCustomer tblCustomer)
        {
            var value = db.TblCustomer.Find(tblCustomer.CustomerID);
            value.CustomerName = tblCustomer.CustomerName;
            value.CustomerSurname = tblCustomer.CustomerSurname;
            value.CustomerCity = tblCustomer.CustomerCity;
            value.CustomerPhone = tblCustomer.CustomerPhone;
            db.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}