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
        List<BookExemplar> exemplars = new List<BookExemplar>();
        BookExemplar selected = new BookExemplar();
        public BookForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool hasChanged = false;
            bool isInputValid = true;

            String txtGenre = "", txtName = "", txtISBN = "", txtLocation = "";
            int edition = 0, pagination = 0, exemplar = 0;
            try
            {
                txtGenre = listBoxGenreModify.SelectedItem.ToString().Trim();
                txtName = txtModifyName.Text.Trim();
                txtISBN = txtModifyISBN.Text.Trim();
                txtLocation = comboModifyLocation.SelectedItem.ToString().Trim();
                edition = 0;
                Int32.TryParse(txtModifyEdition.Text.Trim(), out edition);
                pagination = 0;
                Int32.TryParse(txtModifyPagination.Text.Trim(), out pagination);
                exemplar = Int32.Parse(txtModifyExemplar.Text);
            }
            catch (Exception error)
            {

            }

            if (txtGenre.Length == 0) isInputValid = false;
            if (txtName.Length < 5) isInputValid = false;
            if (!Regex.IsMatch(txtISBN, @"^\d{3}\-{1}\d{1}\-{1}\d{1,4}\-{1}\d{4,10}\-{1}\d{1}$")) isInputValid = false;
            if (txtLocation.Length == 0) isInputValid = false;
            if (pagination == 0) isInputValid = false;
            if (edition < 1) isInputValid = false;

            if (txtModifyEdition.Text != selected.Book.BookEdition.ToString()) hasChanged = true;
            if (txtModifyISBN.Text != selected.Book.BookISBN) hasChanged = true;
            if (txtModifyName.Text != selected.Book.BookName) hasChanged = true;
            if (txtModifyPagination.Text != selected.Book.BookPagination.ToString()) hasChanged = true;
            if (comboModifyLocation.SelectedText != selected.BookLocation.BookLocationPlace) hasChanged = true;

            if (listBoxGenreModify.SelectedItem.ToString() != selected.Book.Genre.GenreName) hasChanged = true;

            List<String> selectedAuthorsString = listBoxModifyAuthor.SelectedItems.Cast<String>().ToList();
            List<Author> selectedAuthors = new List<Author>();

            selected.Book.Authors.ToList().ForEach(item => {
                var found = selectedAuthorsString.Find(i => i == item.AuthorName);
                if (found == null)
                {
                    hasChanged = true;
                }
            });

            selectedAuthorsString.ForEach(item => {
                selectedAuthors.Add(new Author() {
                    AuthorName = item
                });
                });

            BookExemplar toUpdate = selected;

            toUpdate.Book.BookEdition = edition;
            toUpdate.Book.BookISBN = txtISBN;
            toUpdate.BookLocation.BookLocationPlace = txtLocation;
            toUpdate.Book.Genre.GenreName = txtGenre;
            toUpdate.Book.BookName = txtName;
            toUpdate.Book.BookISBN = txtISBN;
            toUpdate.Book.BookId = selected.Book.BookId;
            toUpdate.Book.BookPagination = pagination;
            toUpdate.Book.Authors = selectedAuthors;
            
            if(hasChanged && isInputValid)
            {
                BookExemplarRepository.Instance.updateBookExemplarByBookExemplar(toUpdate);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void BookForm_Load(object sender, EventArgs e)
        {
            loadExemplars();
            loadGenres();
            //loadBooks();
            loadLocations();
            loadAuthors(); 
        }

        private void loadBooks()
        {
            books = BookRepository.Instance.findAllBooks();
            books.ForEach(b => listBoxBookModify.Items.Add(b.BookName));
            listBoxBookModify.Items.Clear();
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

        private void loadExemplars()
        {
            exemplars = BookExemplarRepository.Instance.findAllBookLocations();
            listBoxBookModify.Items.Clear();
            exemplars.ForEach(x => listBoxBookModify.Items.Add(x.Book.BookName + "-" + x.BookExemplarId));
        }

        private void listBoxBookModify_SelectedValueChanged(object sender, EventArgs e)
        {
            String selected = listBoxBookModify.SelectedItem.ToString();
            if (selected.Length != 0)
            {
                string[] splitted = selected.Split('-');

                BookExemplar search = exemplars.Find(x => x.BookExemplarId == Int32.Parse(splitted[1]));
                this.selected = search;
                if (search != null)
                {
                    txtModifyName.Text = search.Book.BookName;
                    //txtModifyEdition.Text = search.BookExemplar.ToString();
                    listBoxGenreModify.SelectedItem = search.Book.Genre.GenreName;
                    listBoxModifyAuthor.ClearSelected();
                    List<Author> list = search.Book.Authors.ToList();
                    list.ForEach(x => {
                        int index = listBoxModifyAuthor.FindString(x.AuthorName);
                        if(index > -1) listBoxModifyAuthor.SetSelected(index, true);
                        });
                    txtModifyISBN.Text = search.Book.BookISBN;
                    txtModifyPagination.Text = search.Book.BookPagination.ToString();
                    txtModifyEdition.Text = search.Book.BookEdition.ToString();
                    txtModifyExemplar.Text = search.BookExemplarId.ToString();
                    comboModifyLocation.SelectedItem = search.BookLocation.BookLocationPlace;
                }
            }        
        }

        

        private void button5_Click(object sender, EventArgs e)
        {
            bool isInputValid = true;
            String txtGenre = "", txtName = "", txtISBN = "", txtLocation = "";
            int edition = 0, pagination = 0;
            List<Author> authors = new List<Author>();
            try
            {
                txtGenre = listBoxGenreCreate.SelectedItem.ToString().Trim();
                txtName = txtCreateName.Text.Trim();
                txtISBN = txtCretaeISBN.Text.Trim();
                txtLocation = comboCreateLocation.SelectedItem.ToString().Trim();
                edition = 0;
                Int32.TryParse(txtCreateEdition.Text.Trim(), out edition);
                pagination = 0;
                Int32.TryParse(txtCreatePagination.Text.Trim(), out pagination);

                listBoxCreateAuthor.SelectedItems.OfType<String>().ToList().ForEach(item =>
                   authors.Add(new Author()
                   {
                       AuthorName = item
                   })
                    );
            }catch(Exception error)
            {
                
            }

            if (txtGenre.Length == 0) isInputValid = false;
            if (txtName.Length < 5) isInputValid = false;
            if (!Regex.IsMatch(txtISBN, @"^\d{3}\-{1}\d{1}\-{1}\d{1,4}\-{1}\d{4,10}\-{1}\d{1}$")) isInputValid = false;
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

            txtCreateEdition.Clear();
            txtCreateName.Clear();
            txtCretaeISBN.Clear();
            txtCreatePagination.Clear();

            if (isInputValid)
            {
                if (!answer)
                {
                    MessageBox.Show("Ein Fehler ist bei der Speicherung aufgeterten", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Das Buch \"" + txtName + "\" wurde erfolgreich erstellt", "Abgeschlossen", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadExemplars();
                }
            }
            else
            {
                MessageBox.Show("Überprüfen sie ihre Daten", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void modifyListBox(object sender, EventArgs e)
        {

        }

        private void modiyTextChanged(object sender, EventArgs e)
        {

        }

        private void btnModifyDelete_Click(object sender, EventArgs e)
        {
            if (selected.Book != null) {
                DialogResult res = MessageBox.Show("Wollen sie das Buch \"" + selected.Book.BookName + "\" wirklich löschen?\n\rDie Daten können nicht wiederhergestellt werden", "Löschen", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if(res == DialogResult.Yes)
                {
                    if (BookExemplarRepository.Instance.deleteExemplarAndBookByBookExemplarId(selected.BookExemplarId))
                    {
                        MessageBox.Show("Eintrag wurde erolgreich gelöscht", "Abgeschlossen", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadExemplars();
                    }
                    else
                    {
                        MessageBox.Show("Beim Löschen trat ein Fehler auf", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else
            {
                MessageBox.Show("Es wurde kein Buch ausgewählt", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadExemplars();
            }
        }
    }
}
