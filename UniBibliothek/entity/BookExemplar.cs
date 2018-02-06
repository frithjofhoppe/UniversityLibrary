using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace UniBibliothek.entity
{
    public class BookExemplar
    {
        public int BookExemplarId { get; set; }
        [Required]
        public Book Book { get; set; }
        public BookLocation BookLocation { get; set; }
        public Lending Lending { get; set; }

        public BookExemplar() { }
    }
}
