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
            return context.Books.Include(b => b.Genre).ToList();
        }

        public bool createBook(Book book,Genre genre, List<Author> authors, BookLocation location)
        {
            bool result = true;

            Book toSaveBook = new Book
            {
                BookName = book.BookName,
                BookISBN = book.BookISBN,
                BookEdition = book.BookEdition,
                BookPagination = book.BookPagination
            };

            //context.SaveChanges();

            int id = toSaveBook.BookId;

            Genre toSaveGenre = context.Genres.FirstOrDefault(g => g.GenreName == genre.GenreName);

            if(toSaveGenre != null)
            {
                toSaveBook.Genre.GenreId = toSaveGenre.GenreId;
            }

            authors.ForEach(author => {
                Author temp = context.Authors.FirstOrDefault(a => a.AuthorName == author.AuthorName);
                if(temp != null) { toSaveBook.Authors.Add(new Author() { AuthorId = temp.AuthorId }); }
                else { result = false; }
            });

            if (result)
            {
                context.Books.Add(toSaveBook);
                context.SaveChanges();
            }

            return result;
        }
    }
}
