using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UniBibliothek.entity;
using System.Collections.Generic;

namespace UniBibliothek
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void bearbeitenToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void abrufeToolStripMenuItem_Click(object sender, EventArgs e)
        {

            BookForm bookForm = new BookForm();
            bookForm.Show();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using(var con = new LibraryContext())
            {
                Member m = new Member()
                {
                    MemberFirstname = "Max",
                    MemberSurname = "Mustermann",
                    MemberFaculty = "PHBern",
                    MemberSemester = 2
                };

                con.Members.Add(m);
                con.SaveChanges();
            }
        }

        private void hinzufügenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GenreForm genreForm = new GenreForm();
            genreForm.Show();
        }

        private void entfernenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AuthorForm authorForm = new AuthorForm();
            authorForm.Show();
        }

        private void mitgliedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MemberForm memberForm = new MemberForm();

        }
    }
}
