using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniBibliothek.entity;

namespace UniBibliothek.repository
{
    class LocationRepository
    {
        private static LocationRepository repository;
        LibraryContext context = new LibraryContext();
        private LocationRepository() { }
        public static LocationRepository Instance
        {
            get
            {
                if (repository == null)
                {
                    repository = new LocationRepository();
                }
                return repository;
            }
        }

        public List<BookLocation> findAllBookLocations()
        {
            return context.BookLocations.ToList();
        }
    }
}
