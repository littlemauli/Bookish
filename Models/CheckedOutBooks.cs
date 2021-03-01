using System;
using System.Collections.Generic;

namespace Bookish.Models
{
     public class BookCheckedOutModel
    {
        public string BookTitle {get ; set;}
        public string BookAuthor {get ; set;}
        public int BookYear {get ; set;}

        public int BookCheckedOutByLibrarian {get; set;}

        public int BookBorrowedByUser{get; set;}

       public DateTime BookCheckedOut {get; set;}

       public DateTime BookToBeReturned {get;set;}

    }
}