using Microsoft.AspNetCore.Mvc;

namespace Day3.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            // هنا بيروح يرجع الاندكس بتاع ال ويب وبعد كداا يعملهم خلط فى ال IActionResulte
            // View Is Exsisting Inside Controller
            // Take Index and mix Html and C# and Response to Browser
            return View();
        }

        public IActionResult AboutUs()
        {
            return View();
        }
    }
}
