using System;
using System.Collections.Generic;

namespace Bookish.Models
{
     public class BookOut
    {
        public string Title {get ; set;}
        public string Author {get ; set;}
        public int Year {get ; set;}

        public int CheckedOutByLibrarian {get; set;}

        public int BorrowedByUser{get; set;}

    }
}