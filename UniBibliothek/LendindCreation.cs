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
    public partial class LendindCreation : Form
    {
        private List<BookExemplar> exemplars = new List<BookExemplar>();
        private List<Member> members = new List<Member>();
        private Member member = new Member();
        private BookExemplar bookExemplar = new BookExemplar();
        
        public LendindCreation()
        {
            InitializeComponent();
        }

        private void LendingModifying_Load(object sender, EventArgs e)
        {
            loadMember();
            loadBookExemplar();
            comboBoxExemplarSort.SelectedIndex = 0;
            dateTimePickerFrom.Value = DateTime.Now;
            dateTimePickerFrom.MinDate = DateTime.Now;
        }

        private void loadMember()
        {
            members = MemberRepository.Instance.findAllMembers();
            listBoxMembers.Items.Clear();
            members.ForEach(item => listBoxMembers.Items.Add(item.MemberFirstname + "/" + item.MemberSurname));
        }

        private void loadBookExemplar()
        {
            exemplars = BookExemplarRepository.Instance
                .findAllBookExemplars()
                .FindAll(item => item.Lending == null);
            listBoxExemplars.Items.Clear();
            exemplars.ForEach(item => listBoxExemplars.Items.Add(item.Book.BookName + "-" + item.BookExemplarId));
        }

        private void comboBoxExemplarSort_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePickerFrom_ValueChanged(object sender, EventArgs e)
        {
            DateTime fromDate = dateTimePickerFrom.Value;
            DateTime toDate = fromDate.AddMonths(1);
            dateTimePickerTo.MinDate = toDate;
        }

        private void comboBoxExemplarSort_SelectedValueChanged(object sender, EventArgs e)
        {
            var sortMode = comboBoxExemplarSort.SelectedItem;
            if(sortMode != null)
            {
                switch (sortMode)
                {
                    case "Aufsteigend":
                        listBoxExemplars.Items.Clear();
                        exemplars
                            .OrderBy(entry => entry.Book.BookName)
                            .ToList()
                            .ForEach(item => {
                                listBoxExemplars.Items.Add(item.Book.BookName + "-" + item.BookExemplarId);
                            });
                        break;
                    case "Absteigend":
                        listBoxExemplars.Items.Clear();
                        exemplars
                            .OrderByDescending(entry => entry.Book.BookName)
                            .ToList()
                            .ForEach(item => {
                                listBoxExemplars.Items.Add(item.Book.BookName + "-" + item.BookExemplarId);
                            });
                        break;
                }
            }
        }

        private void btnLend_Click(object sender, EventArgs e)
        {
            bool isValid = true;

            DateTime from = dateTimePickerFrom.Value;
            DateTime to = dateTimePickerTo.Value;

            if (listBoxExemplars.SelectedItems.Count != 1) isValid = false;
            if (listBoxMembers.SelectedItems.Count != 1) isValid = false;
            if (this.member.MemberId == 0) isValid = false;
            if (this.bookExemplar.BookExemplarId == 0) isValid = false;

            if (isValid)
            {
                Lending lending = new Lending()
                {
                    LendingDate = from,
                    LendingReturn = to,
                    Member = new Member()
                    {
                        MemberFaculty = member.MemberFaculty,
                        MemberFirstname = member.MemberFirstname,
                        MemberId = member.MemberId,
                        MemberSemester = member.MemberSemester,
                        MemberSurname = member.MemberSurname
                    },
                    BookExemplar = new BookExemplar()
                    {
                        BookExemplarId = this.bookExemplar.BookExemplarId,
                    }
                };

                if (LendingRepository.Instance.createLendingByLending(lending))
                {
                    MessageBox.Show("Folgene Daten wurden erfasst\n\rBuch: " 
                        + this.bookExemplar.Book.BookName + "\n\rExemplar: " 
                        + this.bookExemplar.BookExemplarId.ToString() + "\n\rMitglied: "
                        + this.member.MemberFirstname + " " + this.member.MemberSurname
                        , "Abgeschlosen", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Beim Vorgang trat ein Fehler auf", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                loadBookExemplar();
                loadMember();
            }
        }

        private void listBoxExemplars_SelectedValueChanged(object sender, EventArgs e)
        {
            var content = listBoxExemplars.SelectedItem;
            if(content != null)
            {
                string[] contentArray = content.ToString().Split('-');
                this.bookExemplar = exemplars.Find(item => item.BookExemplarId == Int32.Parse(contentArray[1]));
            }
            else if(listBoxExemplars.Items.Count > 1)
            {
                listBoxExemplars.SelectedIndex = 0;
            }
        }

        private void listBoxMembers_SelectedValueChanged(object sender, EventArgs e)
        {
            var content = listBoxMembers.SelectedItem;
            if (content != null)
            {
                string[] contentArray = content.ToString().Split('/');
                this.member = members
                    .Find(item => item.MemberFirstname == contentArray[0] && item.MemberSurname == contentArray[1]);
            }
            else if (listBoxMembers.Items.Count > 1)
            {
                listBoxMembers.SelectedIndex = 0;
            }
        }
    }
}
