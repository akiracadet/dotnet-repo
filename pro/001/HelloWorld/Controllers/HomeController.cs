using System;
using Microsoft.AspNetCore.Mvc;

namespace HelloWorld.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index() {
            int hour = DateTime.Now.Hour;
            string model = hour < 12 ? "Good Morning" : "Good Afternoon";

            return View("MyView", model);
        }
    }
}
