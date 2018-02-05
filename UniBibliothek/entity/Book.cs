using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniBibliothek.entity
{
    public class Book
    {
        public int BookId { get; set; }
        public String BookName { get; set; }
        public String BookISBN { get; set; }
        public int BookPagination { get; set; }
        public int BookEdition { get; set; }
        public Genre Genre { get; set; }
        public ICollection<Author> Authors { get; set; }
        public BookExemplar BookExemplar { get; set; }

        public Book() { }
    }
}
