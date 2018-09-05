using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryCatalog
{
    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Published { get; set; }
        public string ISBN { get; set; }

        public Book()
        {
            Title = "";
            Author = "";
            Published = "";
            ISBN = "";

        }

        public Book(string title, string author, string year, string isbn)
        {
            Title = title;
            Author = author;
            Published = year;
            ISBN = isbn;
        }



    }
}
