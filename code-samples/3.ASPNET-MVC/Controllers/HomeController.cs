using System;
using Microsoft.AspNetCore.Mvc;

namespace ConsoleApplication.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}