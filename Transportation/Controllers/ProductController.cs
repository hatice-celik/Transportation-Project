using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Transportation.Models;

namespace Transportation.Controllers
{
    public class ProductController : Controller
    {
        // GET: Category
        DBTransportEntities1 db = new DBTransportEntities1();
        public ActionResult Index()
        {
            var values = db.TblProduct.ToList();
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
        public ActionResult AddProduct()
        {
            List<SelectListItem> values = (from x in db.TblCategory
                                           select new SelectListItem
                                           {
                                               Text = x.CategoryName,
                                               Value = x.CategoryID.ToString()
                                           }).ToList();
            ViewBag.v = values;   
            return View();
        }
        [HttpPost]
        public ActionResult AddProduct(TblProduct tblProduct)
        {
            db.TblProduct.Add(tblProduct);
            db.SaveChanges(); // adonet-> executenonquery
            return RedirectToAction("Index");
        }
        
        public ActionResult DeleteProduct(int id)
        {
            var value = db.TblProduct.Find(id);
            db.TblProduct.Remove(value);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult UpdateProduct(int id)
        {
            var value = db.TblProduct.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateProduct(TblProduct tblProduct)
        {
            var value = db.TblProduct.Find(tblProduct.ProductID);
            value.ProductName = tblProduct.ProductName;
            value.ProductSizeType = tblProduct.ProductSizeType;
            value.ProductSize = tblProduct.ProductSize;
            value.ProductDescription= tblProduct.ProductDescription;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
           

    }
}