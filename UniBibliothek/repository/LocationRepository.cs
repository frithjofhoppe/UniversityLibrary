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

        public bool updateLocationByLocation(BookLocation location)
        {
            BookLocation existing = context.BookLocations.FirstOrDefault(item => item.BookLocationId == location.BookLocationId);
            if (existing == null) return false;

            BookLocation modified = context.BookLocations.FirstOrDefault(item => item.BookLocationPlace.ToUpper() == location.BookLocationPlace.ToUpper());
            if (modified != null) return false;

            existing.BookLocationPlace = location.BookLocationPlace;
            context.SaveChanges();

            return true;
        }

        public bool deleteLocationByLocationId(int id)
        {
            BookLocation existing = context.BookLocations.FirstOrDefault(item => item.BookLocationId == id);
            if (existing == null) return false;
            context.BookLocations.Remove(existing);
            context.SaveChanges();
            return true;
        }

        public bool createLocationByLocation(BookLocation bookLocation)
        {
            BookLocation existing = context.BookLocations.FirstOrDefault(item => item.BookLocationPlace.ToUpper() == bookLocation.BookLocationPlace.ToUpper());
            if (existing != null) return false;

            BookLocation toSave = new BookLocation()
            {
                BookLocationPlace = bookLocation.BookLocationPlace
            };

            context.BookLocations.Add(toSave);
            context.SaveChanges();

            return true;
        }
    }
}
