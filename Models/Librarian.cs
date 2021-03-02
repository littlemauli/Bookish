using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace Bookish.Models
{
    public class LibrarianModel
    {
        [Key]
        public int LibrarianId { get; set; }
        public string LibrarianName { get; set; }

        public bool LibrarianIsAdmin {get; set;}
    }


        public class LibrarianListModel
     {
        public List<LibrarianModel> LibrarianList { get; set; }
    }
}