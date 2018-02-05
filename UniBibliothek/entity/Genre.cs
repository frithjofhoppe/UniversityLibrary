﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniBibliothek.entity
{
    public class Genre
    {
        public int GenreId { get; set; }
        public String GenreName { get; set; }
        public ICollection<Book> Books { get; set; }
        public Genre() { }
    }
}
