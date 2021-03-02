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
    [Route("book")]
    public class BookController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public BookController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        [HttpGet("addOneBookPage")]
        public IActionResult AddOneBook()
        {
            return View();
        }

        [HttpPost("addOneBookForm")]
        public IActionResult AddOneBookFormMethod(BookModel book)
        {
            var context = new BookishContext();
            context.BookModel.Add(book);
            context.SaveChanges();

            return RedirectToAction(nameof(AddOneBook));
        }



        [HttpGet("allTheBooks")]
        public IActionResult AllTheBooks()
        {
            var bookList = new BookListModel { };
            // bookList.BookList= new List<BookModel>();

            var context = new BookishContext();
            var shelves = context.BookModel;
            foreach (var book in shelves)
            {
                bookList.BookList.Add(book);
            }


            // {
            //     // BookList = new List<BookModel>
            //     // {
            //     //     new BookModel {
            //     //         BookTitle = "Book1",
            //     //         BookAuthor = "Christian",
            //     //         BookYear = 2010
            //     //     },
            //     //     new BookModel {
            //     //         BookTitle = "Book2",
            //     //         BookAuthor = "Hina",
            //     //         BookYear = 2014
            //     //     },
            //     //      new BookModel {
            //     //         BookTitle = "Book3",
            //     //         BookAuthor = "Mariam",
            //     //         BookYear = 1998
            //     //     }
            //     // }
            // };
            return View(bookList);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
