using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Bookish.Models;

namespace Bookish.Controllers
{
    [Route("accounts")]
    public class AccountsController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public AccountsController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        [HttpGet("userAccount")]
        public IActionResult AllTheUsers()
        {
            return View();
        }

        [HttpGet("librarianAccount")]
        public IActionResult AllTheLibrarians()
        {
            var librarianList = new LibrarianListModel
            {
                LibrarianList = new List<LibrarianModel>
                {
                    new LibrarianModel
                    {
                        LibrarianId = 345,
                        LibrarianName = "David",
                        LibrarianIsAdmin = true
                    }
                }
            };
            return View(librarianList);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}