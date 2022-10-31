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
    public partial class KategoriForm : Form
    {
        MainForm mainForm;
        string addORupp = "ADD";
        string nuvarandeKategori;
        KategoriController kategoriController;
        ArtikelController artikelController;

        public KategoriForm(string addORupp, string nuvarandeKategori, KategoriController kategoriController, ArtikelController artikelController, MainForm mainForm)
        {
            InitializeComponent();
            this.addORupp = addORupp;
            this.mainForm = mainForm;
            this.nuvarandeKategori = nuvarandeKategori;
            this.kategoriController = kategoriController;
            this.artikelController = artikelController;
        }

        private void KategoriForm_Load(object sender, EventArgs e)
        {
            mainForm.antalForm++;
            mainForm.checkEnable();
            if (addORupp == "ADD")
            {
                btnLaggTill_Upp.Text = "Lägg Till";
            }
            else
            {
                tbxNamn.Text = nuvarandeKategori;
                btnLaggTill_Upp.Text = "Uppdatera";
            }
        }

        private void btnLaggTill_Upp_Click(object sender, EventArgs e)
        {
            if (addORupp == "ADD")
            {
                if (!BLValidator.IsFieldNullOrEmpty(tbxNamn.Text) && !BLValidator.IsKategoriDuplicate(tbxNamn.Text))
                {
                    kategoriController.CreateKategoriObject(tbxNamn.Text);
                    mainForm.DisplayKategorier();
                    this.Close();
                }
            }
            else
            {
                string titel = tbxNamn.Text;

                if (!BLValidator.IsFieldNullOrEmpty(titel))
                {
                    if (!BLValidator.IsKategoriDuplicate(titel))
                    {
                        kategoriController.RenameKategori(nuvarandeKategori, titel);
                        mainForm.DisplayKategorier();
                        mainForm.DisplayArtiklar(artikelController.GetAllArtiklar());
                    }
                }
            }
        }

        private void btnAvbryt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void KategoriForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainForm.antalForm--;
            mainForm.checkEnable();
        }
    }
}
