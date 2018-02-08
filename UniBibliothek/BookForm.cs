using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UniBibliothek.repository;
using UniBibliothek.entity;
using System.Text.RegularExpressions;

namespace UniBibliothek
{
    public partial class BookForm : Form
    {
        List<Book> books = new List<Book>();
        public BookForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void BookForm_Load(object sender, EventArgs e)
        {
            loadGenres();
            loadBooks();
            loadLocations();
            loadAuthors();
        }

        private void loadBooks()
        {
            books = BookRepository.Instance.findAllBooks();
            books.ForEach(b => listBoxBookModify.Items.Add(b.BookName));
        }

        public void loadLocations()
        {
            LocationRepository.Instance.findAllBookLocations().ForEach(loc => {
                comboCreateLocation.Items.Add(loc.BookLocationPlace);
                comboModifyLocation.Items.Add(loc.BookLocationPlace);
            });
        }

        private void loadAuthors()
        {
            AuthorRepository.Instance.findAllAuthors().ForEach(a => {
                listBoxModifyAuthor.Items.Add(a.AuthorName);
                listBoxCreateAuthor.Items.Add(a.AuthorName);
            });
        }

        private void loadGenres()
        {
            listBoxGenreModify.Items.Clear();
            listBoxGenreCreate.Items.Clear();
            GenreRepository.Instance.findAllGenres().ForEach(genre => {
                listBoxGenreModify.Items.Add(genre.GenreName);
                listBoxGenreCreate.Items.Add(genre.GenreName);
            });
        }

        private void listBoxBookModify_SelectedValueChanged(object sender, EventArgs e)
        {
            String selected = listBoxBookModify.SelectedItem.ToString();
            if (selected.Length != 0)
            {
                Book search = books.Find(b => b.BookName == selected);
                if (search != null)
                {
                    txtModifyName.Text = search.BookName;
                    //txtModifyEdition.Text = search.BookExemplar.ToString();
                    listBoxGenreModify.SelectedItem = search.Genre.GenreName;
                    search.Authors.ToList().ForEach(x => listBoxModifyAuthor.SelectedItem = x.AuthorName);
                    txtModifyISBN.Text = search.BookISBN;
                    txtModifyPagination.Text = search.BookPagination.ToString();
                    txtModifyEdition.Text = search.BookEdition.ToString();
                    listBoxGenreCreate.SelectedItem = search.Genre.GenreName;
                }
            }        
        }

        private void button5_Click(object sender, EventArgs e)
        {
            bool isInputValid = true;
            String txtGenre = listBoxGenreCreate.SelectedItem.ToString().Trim();
            String txtName = txtCreateName.Text.Trim();
            String txtISBN = txtCretaeISBN.Text.Trim();
            String txtLocation = comboCreateLocation.SelectedItem.ToString().Trim();
            int edition = 0;
            Int32.TryParse(txtCreateEdition.Text.Trim(), out edition);
            int pagination = 0;
            Int32.TryParse(txtCreatePagination.Text.Trim(), out pagination);
            List<Author> authors = new List<Author>();

            listBoxCreateAuthor.SelectedItems.OfType<String>().ToList().ForEach( item =>
                authors.Add(new Author() {
                    AuthorName = item
                })
                );

            if (txtGenre.Length == 0) isInputValid = false;
            if (txtName.Length < 5) isInputValid = false;
            if (!Regex.IsMatch(txtISBN, @"^\d{3}\-{1}\d{1}\-{1}\d{3}\-{1}\d{5}\-{1}\d{1}$")) isInputValid = false;
            if (txtLocation.Length == 0) isInputValid = false;
            if (pagination == 0) isInputValid = false;
            if (edition < 1) isInputValid = false;

            bool answer = false;

            if (isInputValid)
            {

                answer = BookRepository.Instance.createBook(
                   new Book()
                   {
                       BookEdition = edition,
                       BookName = txtName,
                       BookISBN = txtISBN,
                       BookPagination = pagination
                   }, new Genre()
                   {
                       GenreName = txtGenre
                   }, authors
                   , new BookLocation()
                   {
                       BookLocationPlace = txtLocation
                   }
                   );
            }

            if (!answer) MessageBox.Show("Fehler is aufgeteten", "Fehler");
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }
    }
}
