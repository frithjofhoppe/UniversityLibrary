using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniBibliothek.entity;
using System.Data.Entity;

namespace UniBibliothek.repository
{
    class AuthorRepository
    {
        private static AuthorRepository repository;
        LibraryContext context = new LibraryContext();
        private AuthorRepository() { }
        public static AuthorRepository Instance
        {
            get
            {
                if (repository == null)
                {
                    repository = new AuthorRepository();
                }
                return repository;
            }
        }

        public List<Author> findAllAuthors()
        {
            return context.Authors.ToList();
        }

        public bool createAuthorByAuthor(Author author)
        {
            bool result = true;

            Author availableAuthor = context.Authors.FirstOrDefault(item => item.AuthorName.ToUpper() == author.AuthorName.ToUpper());

            if(availableAuthor == null)
            {
                context.Authors.Add(author);
                context.SaveChanges();
            }
            else
            {
                result = false;
            }

            return result;
        }

        public bool deleteAuthorAndAssociatedBooksByAuhorId(int id, bool deleteWhereAuthorisCoauthor)
        {
            Author author = context.Authors
                .Include(item => item.Books)
                .First(item => item.AuthorId == id);

            List<Book> bookToDelete = new List<Book>();
            List<BookExemplar> exemplarToDelete = new List<BookExemplar>();

            author.Books.ToList().ForEach(item => {
                if (item.Authors.ToList().Count > 1 && deleteWhereAuthorisCoauthor)
                    bookToDelete.Add(item);

                if (item.Authors.ToList().Count == 1)
                    bookToDelete.Add(item);
            });

            bookToDelete.ForEach(item => {
                BookExemplar be = context.BookExemplars
                .Include(b => b.Book)
                .First(b => b.Book.BookId == item.BookId);
                exemplarToDelete.Add(be);
            });

            exemplarToDelete.ForEach(item => context.BookExemplars.Remove(item));
            context.SaveChanges();
            bookToDelete.ForEach(item => context.Books.Remove(item));
            context.SaveChanges();

            //List<BookExemplar> allBooks = context.BookExemplars
            //    .Include(b => b.Book)
            //    .Include(a => a.Book.Authors)
            //    .Where(a => a.Book.Authors.)
            //    .ToList();

            //if (allBooks != null) return false;

            //List<Book> toDelete = new List<Book>();

            //allBooks.ForEach(item =>
            //{
            //    if (item.Book.Authors.ToList().Count > 1 && deleteWhereAuthorisCoauthor)
            //    { context.BookExemplars.Remove(item); toDelete.Add(item.Book); }

            //    if (item.Book.Authors.ToList().Count == 1)
            //    { context.BookExemplars.Remove(item); toDelete.Add(item.Book); }
            //});
            //context.SaveChanges();

            //toDelete.ForEach(item => context.Books.Remove(item));
            //context.SaveChanges();

            context.Authors.Remove(author);
            context.SaveChanges();

            return true;
        }
    }
}
