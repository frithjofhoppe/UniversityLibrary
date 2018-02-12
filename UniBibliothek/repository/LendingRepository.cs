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
                .Include(b => b.BookExemplar.Book)
                .ToList();
        }

        public bool deleteLendingByLendingId(int id)
        {
            Lending existing = context.Lendings.FirstOrDefault(item => item.LendingId == id);
            if (existing == null) return false;

            context.Lendings.Remove(existing);
            context.SaveChanges();

            return true;
        }

        public bool updateLendingByLending(Lending lending)
        {
            Lending existing = context.Lendings.FirstOrDefault(item => item.)
        }

        public bool createLendingByLending(Lending lending)
        {
            Lending existing = context.Lendings
                .Include(be => be.BookExemplar)
                .FirstOrDefault(item => item.BookExemplar.BookExemplarId == lending.BookExemplar.BookExemplarId);
            if (existing != null) return false;

            BookExemplar bookExemplar = context.BookExemplars.FirstOrDefault(item => item.BookExemplarId == lending.BookExemplar.BookExemplarId);
            if (bookExemplar == null) return false;

            Member member = context.Members.FirstOrDefault(item => item.MemberId == lending.Member.MemberId);
            if (member == null) return false;

            Lending toSave = new Lending()
            {
                BookExemplar = bookExemplar,
                LendingDate = lending.LendingDate,
                LendingReturn = lending.LendingReturn,
                Member = member
            };

            context.Lendings.Add(toSave);
            context.SaveChanges();

            return true;
        }
    }
}
