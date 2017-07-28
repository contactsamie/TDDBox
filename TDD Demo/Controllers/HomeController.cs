using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TDD_Demo.Models;
using TDDBox;

namespace TDD_Demo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(Class1 model)
        {
          model.Result =  TDDBox.Library.add(model.First, model.Second);
          ViewBag.Result = model.Result;
          ViewData.Model = model;
          return View();
        }
        
    }
}