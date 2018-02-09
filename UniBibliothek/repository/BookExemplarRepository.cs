using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniBibliothek.entity;
using System.Data.Entity;

namespace UniBibliothek.repository
{
    public class BookExemplarRepository
    {
        LibraryContext context = new LibraryContext();

        private static BookExemplarRepository repository;
        public static BookExemplarRepository instance
        {
            get
            {
                if(repository == null)
                {
                    repository = new BookExemplarRepository();
                }
                return repository;
            }
        }
        private BookExemplarRepository() { }

        public BookLocation findBookLocationByBookId(int id)
        {
            return context.BookExemplars.Include(bl => bl.BookLocation).Include(b => b.Book).FirstOrDefault(r => r.Book.BookId == id).BookLocation;
        }
    }
}
