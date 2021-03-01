using System;
using System.Collections.Generic;

namespace Bookish.Models
{
        public class Book
    {
        public int BookId {get ; set;}
        public string Title {get ; set;}
        public string Author {get ; set;}
        public int Year {get ; set;}

        public int TotalNumberOfCopies {get; set;}

        public int NumberOfAvailableCopies {get; set;}

        public int NumberOfBorrowedCopies{get; set;}

         string showBook(){
           return $"{Title} by {Author} published in{Year}";
        }
    }
}