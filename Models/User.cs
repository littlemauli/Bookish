
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace Bookish.Models
{
    public class UserModel
    {
        [Key]
        public int UserId { get; set; }
        public string UserName { get; set; }
        public DateTime UserDOB { get; set; }
        public int AmountBorrowedByUser { get; set; }
    }
}