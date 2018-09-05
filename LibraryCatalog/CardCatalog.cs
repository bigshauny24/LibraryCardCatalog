using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryCatalog
{
    class CardCatalog
    {
        public List<Book> Books { get; set; }/*access modifier, type, name, get set*/

        public CardCatalog()
        {
            Books = new List<Book>();
        }
        

    }
}

