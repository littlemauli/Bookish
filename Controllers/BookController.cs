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

        [HttpPost("addOneBookToDB")]
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

            return View(bookList);
        }


        [HttpGet("bookCheckout")]
        public IActionResult BookCheckout()
        {
            return View();
        }

        [HttpPost("bookCheckoutPost")]
        public IActionResult BookCheckoutPost(BookCheckedOutModel item){
         var context = new BookishContext();

            var bookOut =context.BookModel.Find(item.BookId);
             bookOut.BookBorrowedCopies +=1;
             bookOut.BookAvailableCopies -=1;

            var userOut =context.UserModel.Find(item.UserId);
            userOut.AmountBorrowedByUser +=1;

            context.BookCheckedOutModel.Add(item);

           context.SaveChanges();

          return RedirectToAction(nameof(BookCheckout));
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
