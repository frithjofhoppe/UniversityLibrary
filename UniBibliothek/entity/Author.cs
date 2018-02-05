using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniBibliothek.entity
{
    public class Author
    {
        public int AuthorId { get; set; }
        public String AuthorName { get; set; }
        public int AuthorAge { get; set; }
        public ICollection<Book> Books { get; set; }
        public Author() { }
    }
}
