﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using Newtonsoft.Json.Linq;


namespace FineUIMvc.Examples.Areas.GridDataUrl.Controllers
{
    public class IFrameController : FineUIMvc.Examples.Controllers.BaseController
    {
        // GET: GridDataUrl/IFrame
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Window1_Close()
        {
            Alert.Show("触发了窗体的关闭事件！");

            return UIHelper.Result();
        }

    }
}