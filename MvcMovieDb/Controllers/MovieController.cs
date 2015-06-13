﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcMovieDb.Controllers
{
    public class MovieController : Controller
    {
        //
        // GET: /Movies/

        public ActionResult Index()
        {            
            return View();
        }

        public ActionResult Details(string id)
        {
            ViewBag.Id = id;

            return View();
        }

        public ActionResult Up_Coming()
        {
            return View();
        }

        public ActionResult Now_Playing()
        {
            return View();
        }
    }
}
