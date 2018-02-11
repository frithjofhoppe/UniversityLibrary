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
    public partial class MemberForm : Form
    {
        private List<Member> members = new List<Member>();
        private Member selected = new Member();
        public MemberForm()
        {
            InitializeComponent();
        }

        private void MemberForm_Load(object sender, EventArgs e)
        {
            loadMember();
        }

        private void loadMember()
        {
            members = MemberRepository.Instance.findAllMembers();
            listBoxMember.Items.Clear();
            members.ForEach(item => {
                listBoxMember.Items.Add(item.MemberFirstname + "/" + item.MemberSurname);
            });
        }

        private void listBoxMember_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedMember = listBoxMember.SelectedItem;
            if(selectedMember != null)
            {
                string[] select = selectedMember.ToString().Split('/');
                Member m = members.Find(item => item.MemberFirstname == select[0] && item.MemberSurname == select[1]);
                if(m != null)
                {
                    this.selected = m;
                    txtModifyFirstname.Text = m.MemberFirstname;
                    txtModifyLastname.Text = m.MemberSurname;
                    txtModifySemester.Text = m.MemberSemester.ToString();
                    txtModifyFaculty.Text = m.MemberFaculty;
                }
            }
            else if(listBoxMember.Items.Count > 0)
            {
                listBoxMember.SetSelected(0, true);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string firstname = "", lastname = "", faculty = "";
            int semester = 0;
            bool isValid = true;

            try
            {
                firstname = txtCreateFirstname.Text.Trim();
                lastname = txtCreateLastname.Text.Trim();
                faculty = txtCreateFaculty.Text.Trim();
                Int32.TryParse(txtCreateSemester.Text.Trim(), out semester);
            }catch(Exception ex) { }

            if (firstname.Length < 2) isValid = false;
            if (lastname.Length < 2) isValid = false;
            if (faculty.Length < 4) isValid = false;
            if (semester < 0 && semester > 10) isValid = false;

            if (isValid)
            {
                Member m = new Member()
                {
                    MemberFirstname = firstname,
                    MemberSurname = lastname,
                    MemberSemester = semester,
                    MemberFaculty = faculty
                };

                if (MemberRepository.Instance.createMember(m))
                {
                    MessageBox.Show("Das Mitglied namens \"" + firstname + " " + lastname + "\" wurde erfolgreich erfasst", "Abgeschlosen", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadMember();
                }
                else
                {
                    MessageBox.Show("Das Mitglied namens \"" + firstname + " " + lastname + "\" exisitert bereits", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Überprüfen sie ihre Daten", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            txtCreateFaculty.Clear();
            txtCreateFirstname.Clear();
            txtCreateLastname.Clear();
            txtCreateSemester.Clear();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            String firstname = "", lastname = "", faculty = "";
            int semester = 0;
            bool isValid = true;
            bool hasChanged = false;

            try
            {
                firstname = txtCreateFirstname.Text.Trim();
                lastname = txtCreateLastname.Text.Trim();
                faculty = txtCreateFaculty.Text.Trim();
                Int32.TryParse(txtCreateSemester.Text.Trim(), out semester);
            }
            catch (Exception ex) { }

            if (firstname.Length < 2) isValid = false;
            if (lastname.Length < 2) isValid = false;
            if (faculty.Length < 4) isValid = false;
            if (semester < 0 && semester > 10) isValid = false;

            if (firstname != selected.MemberFirstname) hasChanged = true;
            if (lastname != selected.MemberSurname) hasChanged = false;
            if (faculty != selected.MemberFaculty) hasChanged = false;
            if (semester != selected.MemberSemester) hasChanged = false;

            if (hasChanged)
            {
                if (isValid)
                {
                    Member m = new Member()
                    {
                        MemberId = selected.MemberId,
                        MemberSurname = lastname,
                        MemberFirstname = firstname,
                        MemberSemester = semester
                    };

                    if (MemberRepository.Instance.updateMemberByMember(m))
                    {
                        MessageBox.Show("Das Mitglied \"" + firstname + " " + lastname + "\" wurde erfolgreich bearbeitet", "Geändert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Beim Bearbeiten trat ein Fehler auf", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    loadMember();
                }
                else
                {
                    MessageBox.Show("Überprüfen sie ihre Daten", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Es wurden keine Änderungen gemacht", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
