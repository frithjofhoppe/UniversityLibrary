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
    public partial class LocationView : Form
    {
        List<BookLocation> locations = new List<BookLocation>();
        BookLocation selected = new BookLocation();

        public LocationView()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void LocationView_Load(object sender, EventArgs e)
        {
            loadLocations();
        }

        private void loadLocations()
        {
            locations = LocationRepository.Instance.findAllBookLocations();
            listBoxLocation.Items.Clear();
            locations.ForEach(item => listBoxLocation.Items.Add(item.BookLocationPlace));
        }

        private void listBoxLocation_SelectedValueChanged(object sender, EventArgs e)
        {
            var selection = listBoxLocation.SelectedItem;

            if(selection != null)
            {
                BookLocation l = locations.Find(item => item.BookLocationPlace == selection.ToString());

                if(l != null)
                {
                    selected = l;
                    txtModifyLocation.Text = l.BookLocationPlace;
                }

            }else if(listBoxLocation.Items.Count > 0)
            {
                listBoxLocation.SelectedIndex = 0;
            }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            string location = "";
            bool isValid = true;

            location = txtModifyLocation.Text.Trim();

            if (location.Length < 2) isValid = false;

            if (isValid)
            {
                BookLocation toUpdate = new BookLocation()
                {
                    BookLocationId = selected.BookLocationId,
                    BookLocationPlace = location
                };

                if (LocationRepository.Instance.updateLocationByLocation(toUpdate))
                {
                    MessageBox.Show("Der Eintrag wurde erfolgreich geändert", "Abgeschlossen", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                loadLocations();
                txtModifyLocation.Clear();
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string location = "";
            bool isValid = true;

            location = txtCreateLocation.Text.Trim();

            if (location.Length < 2) isValid = false;

            if (isValid)
            {
                BookLocation toCreate = new BookLocation()
                {
                    BookLocationPlace = location
                };

                if (LocationRepository.Instance.createLocationByLocation(toCreate))
                {
                    MessageBox.Show("Der Standort \"" + location + "\" wurder erfolgreich erfasst", "Abgeschlossen", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Der Standort existiert bereits", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                loadLocations();
            }
            txtCreateLocation.Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Wollen sie den Standort \"" + selected.BookLocationPlace + "\" unwiederuflich löschen?", "Löschen" ,MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(res == DialogResult.Yes)
            {
                if (LocationRepository.Instance.deleteLocationByLocationId(selected.BookLocationId))
                {
                    MessageBox.Show("Der Eintrag wurde erfolgreich gelöscht", "Abgeschlossen", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Bei der Verarbeitung trat ein Fehler auf", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                loadLocations();
                txtModifyLocation.Clear();
            }
        }
    }
}
