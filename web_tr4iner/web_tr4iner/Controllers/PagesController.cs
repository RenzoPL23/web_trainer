using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace web_tr4iner.Controllers
{
    public class PagesController : Controller
    {
        // GET: Pages
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
    }
}