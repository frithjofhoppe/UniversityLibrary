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

namespace UniBibliothek
{
    public partial class AuthorForm : Form
    {
        private List<Author> authors = new List<Author>();
        private Author selected = new Author();

        public AuthorForm()
        {
            InitializeComponent();
        }

        private void AuthorForm_Load(object sender, EventArgs e)
        {
            loadAuthors();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void loadAuthors()
        {
            listBoxModifyAuthor.Items.Clear();
            this.authors = AuthorRepository.Instance.findAllAuthors();
            this.authors.ForEach(item => {
                listBoxModifyAuthor.Items.Add(item.AuthorName);
            });
        }

        private void btnCreateEntry_Click(object sender, EventArgs e)
        {
            String author = "";
            int age = 0;
            bool isValid = true;

            try
            {
                author = txtCreateName.Text.Trim();
                Int32.TryParse(txtCreateAge.Text, out age);
            } catch (Exception exception) { }

            if (author.Length < 2) isValid = false;
            if (age < 1) isValid = false;

            if (isValid)
            {
                Author toCreate = new Author()
                {
                    AuthorName = author,
                    AuthorAge = age
                };

                if (AuthorRepository.Instance.createAuthorByAuthor(toCreate))
                {
                    MessageBox.Show("Der Author \"" + author + "\" wurde erfolgreich erstellt", "Abgeschlosen", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadAuthors();
                }
                else
                {
                    MessageBox.Show("Author \"" + author + "\" exisitert bereits", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }    
            }
            else
            {
                MessageBox.Show("Überprüfen sie ihre Daten", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            txtCreateAge.Clear();
            txtCreateName.Clear();
        }

        private void listBoxModifyAuthor_SelectedValueChanged(object sender, EventArgs e)
        {
            Author a = authors.FirstOrDefault(item => item.AuthorName == listBoxModifyAuthor.SelectedItem.ToString());

            if (a != null)
            {
                this.selected = a;
                txtModfiyAge.Text = a.AuthorAge.ToString();
                txtModifyName.Text = a.AuthorName;
            }
        }

        private void btnDeleteEntry_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Wollen sie den Autor \"" + selected.AuthorName + "\" wirklich löschen?\n\rAlle zugehörigen Bücher können nicht wiederhergestellt werden", "Löschen", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (res == DialogResult.Yes)
            {
                if (AuthorRepository.Instance.deleteAuthorAndAssociatedBooksByAuhorId(selected.AuthorId))
                {
                    MessageBox.Show("Eintrag wurde erolgreich gelöscht", "Abgeschlossen", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadAuthors();
                }
                else
                {
                    MessageBox.Show("Beim Löschen trat ein Fehler auf", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
