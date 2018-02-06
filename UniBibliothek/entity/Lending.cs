using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace UniBibliothek.entity
{
    public class Lending
    {
        public int LendingId { get; set; }
        public DateTime LendingDate { get; set; }
        public DateTime LendingReturn { get; set; }
        public Member Member { get; set; }
        [Required]
        public BookExemplar BookExemplar { get; set; }
        public Lending() { }
    }
}
