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
        public static BookExemplarRepository Instance
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
            return context.BookExemplars
                .Include(bl => bl.BookLocation)
                .Include(b => b.Book)
                .Include(g => g.Book.Genre)
                .Include(a => a.Book.Authors)
                .FirstOrDefault(r => r.Book.BookId == id).BookLocation;
        }

        public List<BookExemplar> findAllBookLocations()
        {
            return context.BookExemplars
                .Include(bl => bl.BookLocation)
                .Include(b => b.Book)
                .Include(a => a.Book.Authors)
                .Include(g => g.Book.Genre)
                .ToList();
        }

        public void updateBookExemplarByBookExemplar(BookExemplar bookExemplar)
        {
            BookExemplar oExemplar = context.BookExemplars.FirstOrDefault(item => item.BookExemplarId == bookExemplar.BookExemplarId);
            Book oBook = context.Books.FirstOrDefault(item => item.BookId == bookExemplar.Book.BookId);
            Genre oGenre = context.Genres.FirstOrDefault(item => bookExemplar.Book.Genre.GenreName == item.GenreName);
            List<Author> nAuthors = new List<Author>();

            bookExemplar.Book.Authors.ToList().ForEach(item => {
                Author a = context.Authors.FirstOrDefault(aut => aut.AuthorName == item.AuthorName);
                if(a != null) nAuthors.Add(a);
            });

            oBook.BookEdition = bookExemplar.Book.BookEdition;
            oBook.BookISBN = bookExemplar.Book.BookISBN;
            oBook.BookPagination = bookExemplar.Book.BookPagination;
            oBook.BookName = bookExemplar.Book.BookName;
            oBook.Authors = nAuthors;
            oBook.Genre = oGenre;

            oExemplar.BookLocation = context.BookLocations.FirstOrDefault(item => item.BookLocationPlace == bookExemplar.BookLocation.BookLocationPlace);
            oExemplar.Book = oBook;

            context.SaveChanges();
        }

        public bool deleteExemplarAndBookByBookExemplarId(int bookExemplarId)
        { 
            BookExemplar exemplar = context.BookExemplars.Include(b => b.Book).First(item => item.BookExemplarId == bookExemplarId);
            if (exemplar == null) return false;

            Book book = context.Books.Find(exemplar.Book.BookId);
            if (book == null) return false;

            context.BookExemplars.Remove(exemplar);
            context.SaveChanges();

            context.Books.Remove(book);
            context.SaveChanges();

            return true;
        }
    }
}
