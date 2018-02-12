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

            context.Authors.Remove(author);
            context.SaveChanges();

            return true;
        }

        public bool updateAutorByAuthor(Author author)
        {
            Author existing = context.Authors.FirstOrDefault(item => item.AuthorId == author.AuthorId);
            Author changed = context.Authors.FirstOrDefault(item => item.AuthorName == author.AuthorName);

            if (existing == null) return false;
            if (author.AuthorName != existing.AuthorName)
            {
                if (changed != null) return false;
            }

            existing.AuthorName = author.AuthorName;
            existing.AuthorAge = author.AuthorAge;

            context.SaveChanges();

            return true;
        }
    }
}
