using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyRedmine.Models;

namespace MyRedmine.Controllers
{
    public class NewsController : Controller
    {
        TaskContext taskContext = new TaskContext();

        public ActionResult Index()
        {
            return View();
        }
    }
}