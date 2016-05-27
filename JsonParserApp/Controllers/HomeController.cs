using JsonParserApp.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JsonParserApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        //Receiving posted JSON object
        [HttpPost]
        public ActionResult JsonParser(ResumeModel model)
        {
            if (model != null)
            {
                return View(model);
            }
            else
            {
                return Json("An Error Has occoured");
            }

        }
    }
}