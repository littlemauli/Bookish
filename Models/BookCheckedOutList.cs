using System;
using System.Collections.Generic;

namespace Bookish.Models
{
    public class BookCheckedOutListModel
     {
        public List<BookCheckedOutModel> BookCheckedOutList { get; set; }= new List<BookCheckedOutModel>();
    }
}