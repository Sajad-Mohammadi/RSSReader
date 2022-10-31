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
    public partial class URLForm : Form
    {
        MainForm mainForm;
        string addORupp = "ADD";
        string nuvarandeArtikel;
        string nuvarandeKategori;
        KategoriController kategoriController;
        ArtikelController artikelController;

        public URLForm(string addORupp, string nuvarandeArtikel, string nuvarandeKategori, KategoriController kategoriController, ArtikelController artikelController, MainForm mainForm)
        {
            InitializeComponent();
            this.addORupp = addORupp;
            this.mainForm = mainForm;
            this.nuvarandeArtikel = nuvarandeArtikel;
            this.kategoriController = kategoriController;
            this.artikelController = artikelController;
            this.nuvarandeKategori = nuvarandeKategori;
        }

        private void URLForm_Load(object sender, EventArgs e)
        {
            mainForm.antalForm++;
            mainForm.checkEnable();
            if (addORupp == "ADD")
            {
                btnLaggTill_Upp.Text = "Lägg Till";
                DisplayKategorier();
            }
            else
            {
                btnLaggTill_Upp.Text = "Uppdatera";

                foreach (var item in artikelController.GetAllArtiklar())
                {
                    if (item.Titel.Equals(nuvarandeArtikel))
                    {
                        tbxNamn.Text = item.Titel;
                        tbxURL.Text = item.URL;
                    }
                }
                foreach (var item in kategoriController.GetAllKategorier())
                {
                    if (item != null)
                    {
                        cbbKategori.Items.Add(item.Titel);
                    }
                }
                cbbKategori.SelectedItem= nuvarandeKategori;
            }
        }

        private void btnLaggTill_Upp_Click(object sender, EventArgs e)
        {
            if (addORupp == "ADD")
            {
                if (!BLValidator.IsFieldNullOrEmpty(tbxNamn.Text) && !BLValidator.IsFieldNullOrEmpty(cbbKategori.Text.ToString()))
                {
                    if (BLValidator.IsUrlValid(tbxURL.Text) && !BLValidator.UrlExsists(tbxURL.Text) && BLValidator.UrlContainsRSS(tbxURL.Text))
                    {
                        if (!BLValidator.IsArtikelDuplicate(tbxNamn.Text))
                        {
                            string kategori = this.cbbKategori.GetItemText(this.cbbKategori.SelectedItem);
                            artikelController.CreateArtikelObject(tbxNamn.Text, tbxURL.Text, kategori);
                            _ = mainForm.Delay();
                            this.Close();
                        }
                    }
                }
            }
            else
            {
                int index = artikelController.GetIndexByTitel(nuvarandeArtikel);
                if (!BLValidator.IsFieldNullOrEmpty(nuvarandeArtikel))
                {
                    string kategori = this.cbbKategori.GetItemText(this.cbbKategori.SelectedItem);
                    artikelController.UpdateArtikelObject(tbxNamn.Text, tbxURL.Text, kategori, index);
                    _ = mainForm.Delay();
                    this.Close();
                }
            }
        }

        private void btnAvbryt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void DisplayKategorier()
        {
            cbbKategori.Items.Clear();
            foreach (var item in kategoriController.GetAllKategorier())
            {
                if (item != null)
                {
                    cbbKategori.Items.Add(item.Titel);
                }
            }
            cbbKategori.Items.Add("Skapa Ny Kategori");
        }

        private void URLForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainForm.antalForm--;
            mainForm.checkEnable();
        }

        private void cbbKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbKategori.SelectedItem.ToString() == "Skapa Ny Kategori")
            {
                KategoriForm popUpKategori = new KategoriForm("ADD", kategoriController, mainForm, this);
                popUpKategori.Show();
            }
        }
    }
}
