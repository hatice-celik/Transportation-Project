﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Transportation.Controllers
{
    public class MessageController : Controller
    {
        // GET: Message
        public ActionResult Index()
        {
            return View();
        }
        [Authorize] //üzerinde bulunduğu metodu giriş yapmaya zorlar
        public ActionResult Index2()
        {
            return View();
        }
    }
}