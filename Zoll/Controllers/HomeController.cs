using System;
using System.Web.Mvc;

namespace Zoll.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}