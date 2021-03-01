using System;
using System.Collections.Generic;

namespace Bookish.Models
{
        public class BookModel
    {
        public int BookId {get ; set;}
        public string BookTitle {get ; set;}
        public string BookAuthor {get ; set;}
        public int BookYear {get ; set;}

        public int BookTotalCopies {get; set;}

        public int BookAvailableCopies {get; set;}

        public int BookBorrowedCopies{get; set;}

        public string DisplayBook()
        {
           return $"{BookTitle} was written by {BookAuthor} and published in {BookYear}. The library holds usually {BookTotalCopies} copies, but only {BookAvailableCopies} copies are available now. ";
        }

        // public override string ToString()
        // {
        //    return $"{BookTitle} was written by {BookAuthor} and published in {BookYear}. The library holds usually {BookTotalCopies} copies, but only {BookAvailableCopies} copies are available now. ";
        // }
    }
}