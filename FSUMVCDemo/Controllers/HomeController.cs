namespace FSUMVCDemo.Controllers
{
    using System.Diagnostics;
    using FSUMVCDemo.Models;
    using Microsoft.AspNetCore.Mvc;

    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        // Get('/')
        public IActionResult Index()
        {
            return View();
        }
        // Get('/privacy')
        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Name(string name)
        {
            ViewData["Hello"] = "Hej på dig " + name;
            return View("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}