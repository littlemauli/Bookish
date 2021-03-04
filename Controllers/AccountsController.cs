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
    [Route("accounts")]
    public class AccountsController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public AccountsController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        [HttpGet("userAccountSearch")]
        public IActionResult UserSearch()
        {
            return View();
        }

        [HttpGet("userAccountSearchPost")]
        public IActionResult SearchOneUser(string search)
        {
            var context = new BookishContext();
            List<UserModel> users;
            if (!String.IsNullOrEmpty(search))
            {
                DateTime dob;
                if (DateTime.TryParse(search, out dob))
                {
                    users = context.UserModel.Where(x => x.UserDOB == dob).ToList();
                }
                else
                {
                    users = context.UserModel.Where(x => x.UserName == search).ToList();
                }
            }
            else
            {
                users = context.UserModel.ToList();
            }
            var userlist = new UserListModel { UserList = users };

            return View(userlist);

        }


        [HttpGet("addOneUserPage")]
        public IActionResult AddOneUser()
        {
            return View();
        }

        [HttpPost("addOneUserToDB")] //can we leave this empty since its not taking us to a page?
        public IActionResult AddOneUserFormMethod(UserModel user)
        {
            var context = new BookishContext();
            context.UserModel.Add(user);
            context.SaveChanges();

            return RedirectToAction(nameof(AddOneUser));
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            Console.WriteLine(id);
            var context = new BookishContext();
            var user = context.UserModel.Find(id);
            if (user != null)
            {
                context.UserModel.Remove(user);
                context.SaveChanges();
            }
            return RedirectToAction(nameof(UserSearch));
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