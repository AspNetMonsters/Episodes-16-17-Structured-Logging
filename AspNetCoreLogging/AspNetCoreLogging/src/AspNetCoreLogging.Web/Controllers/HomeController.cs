using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using Microsoft.Extensions.Logging;

namespace AspNetCoreLogging.Web.Controllers
{
    public class HomeController : Controller
    {
        private ILogger<HomeController> _logger;

        public HomeController (ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            _logger.LogError("These are not the frameworks you're looking for...");
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult TestLogging()
        {
            return View();
        }


        public IActionResult Error()
        {
            return View();
        }
    }
}
