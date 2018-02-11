using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniBibliothek.entity;
using System.Data.Entity;

namespace UniBibliothek.repository
{
    public class MemberRepository
    {
        private static MemberRepository repository;
        LibraryContext context = new LibraryContext();
        private MemberRepository() { }
        public static MemberRepository Instance
        {
            get
            {
                if(repository == null)
                {
                    repository = new MemberRepository();
                }
                return repository;
            }
        }

        public List<Member> findAllMembers()
        {
            return context.Members
                .ToList();
        }

        public bool createMember(Member member)
        {
            Member existing = context.Members.FirstOrDefault(item => item.MemberFirstname.ToUpper() == member.MemberFirstname.ToUpper() && item.MemberSurname.ToUpper() == member.MemberSurname.ToUpper());

            if (existing != null) return false;

            context.Members.Add(member);
            context.SaveChanges();

            return true;
        }
        
        public bool updateMemberByMember(Member member)
        {
            Member toUpdate = context.Members.FirstOrDefault(item => item.MemberId == member.MemberId);

            if (toUpdate == null) return false;

            toUpdate.MemberSemester = member.MemberSemester;
            toUpdate.MemberFirstname = member.MemberFirstname;
            toUpdate.MemberSurname = member.MemberSurname;
            toUpdate.MemberFaculty = member.MemberFaculty;

            context.SaveChanges();

            return true;
        }

        public bool deleteMemberById(int id)
        {
            return true;
        }
    }
}
