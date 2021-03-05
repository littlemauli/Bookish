using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Bookish.Models;
using Bookish.Data;

namespace Bookish.Controllers
{
    [Route("library")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet("privacy")]
        public IActionResult Privacy()
        {
            return View();
        }


         [HttpGet("ShowLibrarianCommand")]
        public IActionResult ShowLibrarianCommand()
        {
            return View();
        }

        [HttpGet("ShowMemberCommand")]
        public IActionResult ShowMemberCommand()
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
