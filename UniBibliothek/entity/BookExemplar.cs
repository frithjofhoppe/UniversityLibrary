using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniBibliothek.entity
{
    public class BookExemplar
    {
        public int BookExemplarId { get; set; }
        public BookLocation BookLocation { get; set; }
        public Book Book { get; set; }
        public BookExemplar() { }
    }
}
