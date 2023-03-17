using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Transportation.Models;

namespace Transportation.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        DBTransportEntities1 db = new DBTransportEntities1();
        public ActionResult Index()
        {
            var values = db.TblCategory.ToList();
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
            ViewBag.cityCountLabel = "Şehir Sayısı";
            ViewBag.cityCount = cityCount;
            return View(values);
        }

        public PartialViewResult Statistic()
        {
            return PartialView();
        }


        [HttpGet]
        public ActionResult AddCategory()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddCategory(TblCategory tblCategory)
        {
            db.TblCategory.Add(tblCategory);
            db.SaveChanges(); // adonet-> executenonquery
            return View();
        }

        public ActionResult DeleteCategory(int id) 
        { 
            var value= db.TblCategory.Find(id);
            db.TblCategory.Remove(value);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult UpdateCategory(int id)
        {
            var value = db.TblCategory.Find(id);
            return View(value);
        }

        [HttpPost]
        public ActionResult UpdateCategory(TblCategory tblCategory)
        {
            var value = db.TblCategory.Find(tblCategory.CategoryID);
            value.CategoryName = tblCategory.CategoryName;
            db.SaveChanges();
            return RedirectToAction("Index");
        }


    }
}
//attribute-> üstünde bulundupualanın ne iş yapacağını bildirir.