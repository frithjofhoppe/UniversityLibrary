using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static UniBibliothek.entity.Genre;
using UniBibliothek.entity;
using System.ComponentModel;
using System.Data.Entity;


namespace UniBibliothek.repository
{
    public class BookRepository
    {
        private static BookRepository repository;
        LibraryContext context = new LibraryContext();
        private BookRepository() { }
        public static BookRepository Instance
        {
            get
            {
                if(repository == null)
                {
                    repository = new BookRepository();
                }
                return repository;
            }
        }
        
        public List<Book> findBooksByGenre(Genre genre)
        {
            Genre result = context.Genres.FirstOrDefault(g => g.GenreName == genre.GenreName);
            var list = context.Books.Include(b => b.Genre).Where(b => b.Genre.GenreId == result.GenreId);
            return list.ToList();
        }

        public List<Book> findAllBooks()
        {
            return context.Books.Include(b => b.Genre).Include(a=> a.Au).ToList();
        }

        public bool createBook(Book book,Genre genre, List<Author> authors, BookLocation location)
        {
            bool result = true;

            Genre g = context.Genres.FirstOrDefault(x => x.GenreName == genre.GenreName);

            List<Author> a = new List<Author>();

            authors.ForEach(x => {
                a.Add(context.Authors.FirstOrDefault(y => y.AuthorName == x.AuthorName));
            });

            //context.Entry(a).State = EntityState.Unchanged;

            Book b = new Book() {
                BookName = book.BookName,
                BookEdition = book.BookEdition,
                BookISBN = book.BookISBN,
                BookPagination = book.BookPagination,
                Authors = a,
                Genre = g
            };

            context.Books.Add(b);
            context.SaveChanges();

            int id = b.BookId;

            Book b2 = context.Books.FirstOrDefault(x => x.BookId == id);

            BookLocation bl = context.BookLocations.FirstOrDefault(x => x.BookLocationPlace == location.BookLocationPlace);

            if(b2 != null)
            {
                BookExemplarRepository be = new BookExemplarRepository()
                {
                    Book = b2,
                    BookLocation = bl
                };

                context.BookExemplars.Add(be);
                context.SaveChanges();
            }
            else
            {
                result = false;
            }

            return result;
        }
    }
}
