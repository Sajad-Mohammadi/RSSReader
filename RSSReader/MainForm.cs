using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BL;
using Models;

namespace RSSReader
{
    public partial class MainForm : Form
    {
        ArtikelController artikelController;
        KategoriController kategoriController;
        AvsnittController avsnittController;
        string nuvarandeKategori = "";
        string nuvarandeArtikel = "";
        public int antalForm = 1;

        public MainForm()
        {
            InitializeComponent();

            artikelController = new ArtikelController();
            kategoriController = new KategoriController();
            avsnittController = new AvsnittController();

            DisplayKategorier();
            DisplayArtiklar(artikelController.GetAllArtiklar());

            btnUppdateraKategori.Enabled = false;
            btnTaBortKategori.Enabled = false;
            btnUppdateraFeed.Enabled = false;
            btnTaBortFeed.Enabled = false;
        }

        async Task Delay()
        {
            await Task.Delay(300);
            DisplayArtiklar(artikelController.GetAllArtiklar());

            System.Diagnostics.Process.Start(Application.ExecutablePath);
            Application.Exit();
        }

        public void checkEnable()
        {
            if (antalForm>1)
            {
                this.Enabled=false;
            }
            else
            {
                this.Enabled=true;
            }
        }

        private void btnLaggTillKategori_Click(object sender, EventArgs e)
        {
            KategoriForm popUpKategori = new KategoriForm("ADD", nuvarandeKategori, kategoriController, artikelController, this);
            popUpKategori.Show();
        }

        private void btnUppdateraKategori_Click(object sender, EventArgs e)
        {
            KategoriForm popUpKategori = new KategoriForm("UPP", nuvarandeKategori, kategoriController, artikelController, this);
            popUpKategori.Show();
        }

        private void btnTaBortKategori_Click(object sender, EventArgs e)
        {
            //MessageBox för att låta användaren säkerställa att kategorin med tillhörande artiklar ska tas bort
            DialogResult result = MessageBox.Show("Är du säker på att du vill radera kategorin " + nuvarandeKategori + " ? \n Alla artiklar som tillhör kategorin kommer att raderas!", "Radera kategori med tiihörande artiklar", MessageBoxButtons.YesNoCancel);
            if (result == DialogResult.Yes)
            {
                kategoriController.DeleteKategori(nuvarandeKategori);
                DisplayKategorier();
                DisplayArtiklar(artikelController.GetAllArtiklar());

                tbxBeskrivning.Clear();
                cbbAvsnitt.Items.Clear();
            }
        }

        private void btnLaggTillFeed_Click(object sender, EventArgs e)
        {
            URLForm popUpURL = new URLForm("ADD", nuvarandeArtikel, nuvarandeKategori, kategoriController, artikelController, this);
            popUpURL.Show();
        }

        private void btnUppdateraFeed_Click(object sender, EventArgs e)
        {
            URLForm popUpURL = new URLForm("UPP", nuvarandeArtikel, nuvarandeKategori, kategoriController, artikelController, this);
            popUpURL.Show();
        }

        private void btnTaBortFeed_Click(object sender, EventArgs e)
        {
            string title = lvArtikel.SelectedItems[0].Text;

            //MessageBox för att låta användaren säkerställa att podcasten ska tas bort
            DialogResult result = MessageBox.Show("Vill du ta bort podcasten '" + title + "'?", "Warning", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                artikelController.DeleteArtikel(title);
                DisplayArtiklar(artikelController.GetAllArtiklar());

                tbxBeskrivning.Clear();
                cbbAvsnitt.Items.Clear();

                btnUppdateraFeed.Enabled = false;
                btnTaBortFeed.Enabled = false;
            }
        }

        public void DisplayKategorier()
        {
            lbKategori.Items.Clear();
            foreach(var item in kategoriController.GetAllKategorier())
            {
                if(item != null)
                {
                    lbKategori.Items.Add(item.Titel);
                }
            }
        }

        public void DisplayArtiklar(List<Artikel> artiklarToDisplay)
        {
            lvArtikel.Items.Clear();

            foreach (var item in artiklarToDisplay)
            {
                if (item != null)
                {
                    string numberOfAllaAvsnitt = item.AllaAvsnitt.Count().ToString();
                    ListViewItem newList = new ListViewItem(item.Titel);
                    newList.SubItems.Add(numberOfAllaAvsnitt);
                    newList.SubItems.Add(item.Kategori);
                    lvArtikel.Items.Add(newList);
                }
            }
        }

        private void lbKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbKategori.SelectedIndex>=0)
            {
                nuvarandeKategori= lbKategori.SelectedItem.ToString();

                List<string> selectedValues = new List<string>();
                selectedValues.Add(nuvarandeKategori);

                List<Artikel> filteredArtiklar = kategoriController.FilterArtiklar(selectedValues);
                DisplayArtiklar(filteredArtiklar);

                tbxBeskrivning.Clear();
                cbbAvsnitt.Items.Clear();

                btnUppdateraKategori.Enabled = true;
                btnTaBortKategori.Enabled = true;
            }
            else
            {
                btnUppdateraKategori.Enabled = false;
                btnTaBortKategori.Enabled = false;
            }
        }

        private void lvArtikel_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbxBeskrivning.Clear();
            cbbAvsnitt.Items.Clear();
            cbbAvsnitt.Items.Add("Valj Avsnitt");
            cbbAvsnitt.SelectedIndex=0;

            //Om en podcast är vald hämtas information om podcasten och fylls i respektive textfält/combobox.
            if (lvArtikel.SelectedItems.Count == 1)
            {
                nuvarandeArtikel = lvArtikel.SelectedItems[0].Text;

                btnTaBortFeed.Enabled = true;
                btnUppdateraFeed.Enabled = true;

                foreach (var item in artikelController.GetAllArtiklar())
                {
                    if (item.Titel.Equals(nuvarandeArtikel))
                    {
                        int numberArtikel = 1;
                        foreach (var item2 in item.AllaAvsnitt) //Hämtar antal avsnitt för vald podcast
                        {
                            cbbAvsnitt.Items.Add(item2.Titel);
                            numberArtikel++;
                        }
                    }
                }
                avsnittController.GetAvsnitt(nuvarandeArtikel); //Hämtar avsnitten för vald podcast
                tbxBeskrivning.Clear();
            }
            else
            {
                tbxBeskrivning.Clear();
                cbbAvsnitt.Items.Clear();

                btnTaBortFeed.Enabled = false;
                btnUppdateraFeed.Enabled = false;
            }
        }

        private void cbbAvsnitt_SelectedIndexChanged(object sender, EventArgs e)
        {
            string avsnitt= cbbAvsnitt.Text;

            foreach (var art in artikelController.GetAllArtiklar())
            {
                foreach(var avs in art.AllaAvsnitt)
                {
                    if ( avs.Titel.Equals(avsnitt) && art.Titel.Equals(nuvarandeArtikel))
                    {
                        tbxBeskrivning.Text = avs.Beskrivning;
                    }
                }
            }
        }
    }
}
