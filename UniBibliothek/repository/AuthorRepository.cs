using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniBibliothek.entity;

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
    }
}
