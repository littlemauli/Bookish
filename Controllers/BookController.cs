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
    [Route("library")]
    public class BookController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public BookController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("allTheBooks")]
        public IActionResult AllTheBooks()
        {
            var bookList = new BookListViewModel {
                BookList = new List<Book> {
                    new Book {
                        Title = "Book1",
                        Author = "Christian",
                        Year = 2010
                    },
                    new Book {
                        Title = "Book2",
                        Author = "Hina",
                        Year = 2014
                    },
                     new Book {
                        Title = "Book3",
                        Author = "Mariam",
                        Year = 1998
                    },
                }
            };
            return View(bookList);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
