﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using Newtonsoft.Json.Linq;


namespace FineUIMvc.Examples.Areas.GridOther.Controllers
{
    public class NewTabController : FineUIMvc.Examples.Controllers.BaseController
    {
        // GET: GridOther/NewTab
        public ActionResult Index()
        {
            return View();
        }

        // GET: GridOther/NewTab/Window
        public ActionResult Window()
        {
            return View();
        }


    }
}