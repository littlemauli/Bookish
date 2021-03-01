using System;
using System.Collections.Generic;

namespace Bookish.Models
{
    public class LibrarianModel
    {
        public int LibrarianId { get; set; }
        public string LibrarianName { get; set; }

        public bool LibrarianIsAdmin {get; set;}
    }


        public class LibrarianListModel
     {
        public List<LibrarianModel> LibrarianList { get; set; }
    }
}