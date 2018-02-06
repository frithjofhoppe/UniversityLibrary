using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace UniBibliothek.entity
{
    public class LibraryContext : DbContext
    {
        public LibraryContext() : base("name=defaultConnectionString") { }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<BookExemplar> BookExemplars { get; set; }
        public DbSet<BookLocation> BookLocations { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Lending> Lendings { get; set; }
        public DbSet<Member> Members { get; set; }
    }
}
