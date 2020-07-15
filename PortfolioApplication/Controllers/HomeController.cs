using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PortfolioApplication.Models;

namespace PortfolioApplication.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        #region Views
        public IActionResult Index() => View();
        [Route("/{action}")]
        public IActionResult Privacy() => View();
        [Route("/{action}")]
        public IActionResult Projects() => View();
        [Route("/{action}")]
        public IActionResult About() => View();
        [Route("/{action}")]
        public IActionResult Contact() => View();
        #endregion

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
