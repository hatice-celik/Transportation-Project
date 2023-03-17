using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Transportation.Models;

namespace Transportation.Controllers
{
    public class MainPageController : Controller
    {
        // GET: MainPage
        DBTransportEntities1 db = new DBTransportEntities1();
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult PartialHeader()
        {
            return PartialView();
        }

        public PartialViewResult PartialNavBar()
        {
            return PartialView();
        }

        public PartialViewResult PartialSlider()
        {
            return PartialView();
        }
        public PartialViewResult PartialAbout()
        {
            var values = db.TblAbout.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialDetail()
        {
            ViewBag.leftTittle1 = "Güvenli Taşımacılık";
            ViewBag.leftTittle2 = "Dünyanın Heryerine Tüm Kargolar";
            ViewBag.leftTittle3 = "Konum farketmeksizin, doğudan batıya, kuzeyden güneye en uzak noktalara uzman ekibimizle güvenli teslimat yapıyoruz.";

            ViewBag.rightTittle1 = "Taşıma Kolaylığı";
            ViewBag.rightTittle2 = "Kendi ambalajlarımız ile kargolarınızı paketliyoruz.";
            ViewBag.rightTittle3 = "Şehir İçi Dağıtım";
            ViewBag.rightTittle4 = "İstediğiniz saatte evlerinize veya belirlediğiniz adrese teslimat yapmaktayız.";
            return PartialView();
        }
    
        public PartialViewResult PartialScript()
        {
            return PartialView();
        }
        public PartialViewResult PartialMap()
        {
            return PartialView();
        }
        public PartialViewResult PartialServices()
        {
            return PartialView();
        }
        public PartialViewResult PartialTypes()
        {
            return PartialView();
        }
        public PartialViewResult PartialRating()
        {
            return PartialView();
        }
        public PartialViewResult PartialSubscribe()
        {
            return PartialView();
        }
        public PartialViewResult PartialFooter()
        {
            return PartialView();
        }

    }
}