using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Transportation.Models;

namespace Transportation.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        DBTransportEntities1 db = new DBTransportEntities1();
        public ActionResult Index()
        {
            var values = db.TblEmployee.ToList();
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
        public ActionResult AddEmployee()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddEmployee(TblEmployee tblEmployee) 
        {
            db.TblEmployee.Add(tblEmployee);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult UpdateEmployee(int id) 
        {
            var value=db.TblEmployee.Find(id);  
            return View(value); 
        }

        [HttpPost]
        public ActionResult UpdateEmployee(TblEmployee tblEmployee)
        {
            var value = db.TblEmployee.Find(tblEmployee.EmployeeID);
            value.EmployeeName = tblEmployee.EmployeeName;  
            value.EmployeeSurname = tblEmployee.EmployeeSurname;    
            value.Employeeimage = tblEmployee.Employeeimage;    
            value.EmployeeDescription = tblEmployee.EmployeeDescription;
            db.SaveChanges();
            return RedirectToAction("Index");
                
        }
    }
}