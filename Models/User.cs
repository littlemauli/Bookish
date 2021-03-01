
using System;
using System.Collections.Generic;

namespace Bookish.Models
{
    public class UserModel
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public int UserDOB { get; set; }
        public int AmountBorrowedByUser { get; set; }
    }
}