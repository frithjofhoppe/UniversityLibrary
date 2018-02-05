using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniBibliothek.entity
{
    public class Member
    {
        public int MemberdId { get; set; }
        public String MemberSurname { get; set; }
        public String MemberFirstname { get; set; }
        public int MemberSemester { get; set; }
        public String MemberFaculty { get; set; }
        public Member() { }
    }
}
