using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Bookish.Models
{
    public class BookCheckedOutModel
    {
        [Key]
        public int CopyId {get; set;}
        //foreign key
        public int BookId { get; set; }

        public BookModel BookModel { get; set; }

        
       // foreign key Librarian
        public int LibrarianId {get; set;}

         public LibrarianModel LibrarianModel {get; set;}

        //foreign key
        public int UserId { get; set; }

        public UserModel UserModel { get; set; }



        public DateTime IssueDate { get; set; }

        public DateTime ReturnDate { get; set; }

    }
}