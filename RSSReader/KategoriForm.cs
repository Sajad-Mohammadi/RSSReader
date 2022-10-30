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
        KategoriController KategoriController;
        ArtikelController artikelController;

        public KategoriForm(string addORupp, string nuvarandeKategori, KategoriController kategoriController, ArtikelController artikelController, MainForm mainForm)
        {
            InitializeComponent();
            this.addORupp = addORupp;
            this.mainForm = mainForm;
            this.nuvarandeKategori = nuvarandeKategori;
            this.KategoriController = kategoriController;
            this.artikelController = artikelController;
        }

        private void KategoriForm_Load(object sender, EventArgs e)
        {
            mainForm.Enabled = false;

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
                    KategoriController.CreateKategoriObject(tbxNamn.Text);
                    mainForm.DisplayKategorier();
                }
            }
            else
            {
                string titel = tbxNamn.Text;

                if (!BLValidator.IsFieldNullOrEmpty(titel))
                {
                    if (!BLValidator.IsKategoriDuplicate(titel))
                    {
                        KategoriController.RenameKategori(nuvarandeKategori, titel);
                        mainForm.DisplayKategorier();
                        mainForm.DisplayArtiklar(artikelController.GetAllArtiklar());

                        //Startar om applikationen
                        System.Diagnostics.Process.Start(Application.ExecutablePath);
                        Application.Exit();
                    }
                }
            }

            this.Close();
        }

        private void btnAvbryt_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
