using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniBibliothek.entity;

namespace UniBibliothek.repository
{
    class GenreRepository
    {
        private static GenreRepository repository;
        LibraryContext context = new LibraryContext();
        private GenreRepository() { }
        public static GenreRepository Instance
        {
            get
            {
                if (repository == null)
                {
                    repository = new GenreRepository();
                }
                return repository;
            }
        }

        public List<Genre> findAllGenres()
        {
            var result = context.Genres;
            return result.ToList<Genre>();
        }

        public bool saveGenre(Genre genre)
        {
            Genre result = context.Genres.FirstOrDefault(g => g.GenreName.ToUpper() == genre.GenreName.ToUpper());
            if(result == null)
            {
                context.Genres.Add(genre);
                context.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
