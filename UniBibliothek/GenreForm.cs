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

namespace UniBibliothek
{
    public partial class GenreForm : Form
    {
        public GenreForm()
        {
            InitializeComponent();
        }

        private void GenreForm_Load(object sender, EventArgs e)
        {
            updateGenres();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnGenreSuchen_Click(object sender, EventArgs e)
        {
            var selected = listBoxGenres.SelectedItem;
            if (selected != null)
            {
                if (selected.ToString().Length > 0)
                {
                    listBokksAfterGenres.Items.Clear();
                    BookRepository.Instance.findBooksByGenre(new entity.Genre() { GenreName = selected.ToString() }).ForEach(book =>
                    {
                        listBokksAfterGenres.Items.Add(book.BookName);
                    });
                }
            }
        }

        private void listBokksAfterGenres_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String trimTxt = txtGenreToCreate.Text.Trim();
            if(trimTxt.Length > 2)
            {
                if(!GenreRepository.Instance.saveGenre(new entity.Genre() { GenreName = trimTxt }))
                {
                    MessageBox.Show("Genre " + trimTxt + " exisitert bereits","Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    updateGenres();
                }
            }
            txtGenreToCreate.Clear();
        }

        private void updateGenres()
        {
            listBoxGenres.Items.Clear();
            GenreRepository.Instance.findAllGenres().ForEach(genre => {
                listBoxGenres.Items.Add(genre.GenreName);
            });
        }
    }
}
