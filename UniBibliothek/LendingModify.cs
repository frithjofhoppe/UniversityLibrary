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
using UniBibliothek.repository;

namespace UniBibliothek
{
    public partial class LendingModify : Form
    {
        private List<Lending> lendings = new List<Lending>();
        private List<BookExemplar> bookExemplars = new List<BookExemplar>();
        private List<Member> members = new List<Member>();
        private Member member = new Member();
        private BookExemplar bookExemplar = new BookExemplar();
        private Lending lending = new Lending();
        public LendingModify()
        {
            InitializeComponent();
        }

        private void LendingModify_Load(object sender, EventArgs e)
        {
            loadLending();
            loadMembers();
        }

        private void presentMember()
        {
            listBoxMembers.Items.Clear();
            lendings.ForEach(item =>
            {
                listBoxMembers.Items.Add(item.Member.MemberFirstname + "/" + item.Member.MemberSurname);
            });
        }
        private void loadLending()
        {
            lendings = LendingRepository.Instance.findAllLendings();
        }

        private void loadMembers()
        {
            members = MemberRepository.Instance.findAllMembersWithLending();
            listBoxMembers.Items.Clear();
            listBoxExemplars.Items.Clear();
            members.ForEach(item => listBoxMembers.Items.Add(item.MemberFirstname + "/" + item.MemberSurname));
        }

        private void listBoxMembers_SelectedValueChanged(object sender, EventArgs e)
        {
            var selection = listBoxMembers.SelectedItem;
            listBoxExemplars.Items.Clear();
            bookExemplars.Clear();
            if (selection != null)
            {
                string[] content = selection.ToString().Split('/');

                List<Lending> temp = lendings
                    .FindAll(item => item.Member.MemberFirstname == content[0] && item.Member.MemberSurname == content[1]).ToList();

                member = temp[0].Member;

                temp.ForEach(l => bookExemplars.Add(l.BookExemplar));
                bookExemplars.ForEach(item => listBoxExemplars.Items.Add(item.Book.BookName + "-" + item.BookExemplarId));
            }
            else if (listBoxMembers.Items.Count > 0)
            {
                listBoxMembers.SelectedIndex = 0;
            }
        }

        private void listBoxExemplars_SelectedValueChanged(object sender, EventArgs e)
        {
            var selection = listBoxExemplars.SelectedItem;
            if (selection != null)
            {
                string[] content = selection.ToString().Split('-');
                Lending found = lendings.Find(item => item.BookExemplar.BookExemplarId == Int32.Parse(content[1]));
                if (found != null)
                {
                    lending = found;
                    bookExemplar = found.BookExemplar;
                    dateTimePickerFrom.Value = found.LendingDate;
                    dateTimePickerTo.Value = found.LendingReturn;
                }
            }
            else if (listBoxExemplars.Items.Count > 0)
            {
                listBoxExemplars.SelectedIndex = 0;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lending.BookExemplar != null)
            {
                DialogResult res = MessageBox.Show("Wollen sie die Ausleihe entfernen?\n\n\r" + member.MemberFirstname + " " + member.MemberSurname
                    + " <==> " + lending.BookExemplar.Book.BookName + "-" + lending.BookExemplar.BookExemplarId, "Löschen", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (res == DialogResult.Yes)
                {
                    if (LendingRepository.Instance.deleteLendingByLendingId(lending.LendingId))
                    {
                        MessageBox.Show("Die Ausleihe wurde erfolgreich gelöscht", "Abgeschlossen", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Beim Löschen trat ein Fehler auf", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    loadLending();
                    loadMembers();
                }
            }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            if (lending.BookExemplar != null)
            {
                DateTime from = dateTimePickerFrom.Value;
                DateTime to = dateTimePickerTo.Value;
                bool hasChanged = false;

                Lending l = new Lending()
                {
                    LendingId = lending.LendingId,
                    LendingDate = from,
                    LendingReturn = to
                };

                if (from != lending.LendingDate) hasChanged = true;
                if (to != lending.LendingDate) hasChanged = true;

                if (hasChanged)
                {
                    if (LendingRepository.Instance.updateLendingByLending(l))
                    {
                        MessageBox.Show("Die Ausleihe wurde erfolgreich geändert\n\n\r" + member.MemberFirstname + " " + member.MemberSurname
                         + " <==> " + lending.BookExemplar.Book.BookName + "-" + lending.BookExemplar.BookExemplarId, "Löschen", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Es trat ein Fehler bei der Verarbeitung auf", "Felher", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    loadLending();
                    loadMembers();
                }
            }
        }
    }
}
