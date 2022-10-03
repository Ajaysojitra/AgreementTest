using Agreement_Management.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Agreement_Management.Controllers
{
    public class HomeController : Controller
    {
        db dbop = new db();

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index([Bind] Ad_login ad)
        {
            int res = dbop.logincheck(ad);
           
            if (res != 1)
            {
                Response.WriteAsync("<script>alert(Username or Password is Invalid.');</script>");
            }
            else
            {
                return RedirectToAction("Agreement_Home", "Home");


            }
            return View();
        }
        public IActionResult Agreement_Home()
        {
            return View();
        }

        public IActionResult New_User()
        {
            return View();
        }

        public IActionResult New_Agreement()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}