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
using System.Threading;

namespace UniBibliothek
{
    public partial class Main : Form
    {
        private BackgroundWorker bw = new BackgroundWorker();
        private DbCreateForm dbCreateForm = new DbCreateForm();

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

        private void bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if ((e.Cancelled == true))
            {
                MessageBox.Show("Prozess wurde abgrebrochen", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (!(e.Error == null))
            {
                MessageBox.Show("Prozess wurde abgrebrochen\n\r" + e.Error.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                dbCreateForm.wait();
                dbCreateForm.Close();
            }
        }


        private void bw_createDB(object sender, DoWorkEventArgs e)
        {
            LibraryContext context = new LibraryContext();
            context.Database.CreateIfNotExists();
        }

        private void bw_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            
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
            memberForm.Show();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bearbeitenToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            LendindCreation lendindCreation = new LendindCreation();
            lendindCreation.Show();
        }

        private void abfragenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LendingModify lendingModify = new LendingModify();
            lendingModify.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void Main_Shown(object sender, EventArgs e)
        {
            bw.WorkerReportsProgress = true;
            bw.WorkerSupportsCancellation = true;
            bw.DoWork += new DoWorkEventHandler(bw_createDB);
            bw.ProgressChanged += new ProgressChangedEventHandler(bw_ProgressChanged);
            bw.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bw_RunWorkerCompleted);

            dbCreateForm.Show();

            if (bw.IsBusy != true)
            {
                bw.RunWorkerAsync();
            }
        }

        private void standortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LocationView locationView = new LocationView();
            locationView.Show();
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreditsForm creditsForm = new CreditsForm();
            creditsForm.Show();
        }

        private void copyrightToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
