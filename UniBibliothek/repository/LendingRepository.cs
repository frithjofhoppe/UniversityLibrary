using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniBibliothek.entity;
using UniBibliothek.repository;
using System.Data.Entity;

namespace UniBibliothek.repository
{
    public class LendingRepository
    {
        private static LendingRepository repository;
        LibraryContext context = new LibraryContext();
        private LendingRepository() { }
        public static LendingRepository Instance
        {
            get
            {
                if(repository == null)
                {
                    repository = new LendingRepository();
                }
                return repository;
            }
        }

        public List<Lending> findAllLendings()
        {
            return context.Lendings
                .Include(m => m.Member)
                .Include(ex => ex.BookExemplar)
                .ToList();
        }

        public bool createLendingByLending(Lending lending)
        {
            return true;
        }
    }
}
