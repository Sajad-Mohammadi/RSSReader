using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Models;

namespace BL
{
    public class BLValidator
    {
        public static bool IsUrlValid(string url)
        {
            try
            {
                bool isUrlValid = url.StartsWith("https://") || url.StartsWith("http://");
                if (!isUrlValid)
                {
                    MessageBox.Show("Felaktig URL!");
                }
                return isUrlValid;
            }
            catch (Exception)
            {
                throw new URLException("Ogiltig URL!");
            }
        }

        public static bool UrlContainsRSS(string url)
        {
            try
            {
                bool isUrlValid = url.Contains("rss") || url.Contains("feed");
                if (!isUrlValid)
                {
                    MessageBox.Show("RSS Feed saknas!");
                }
                return isUrlValid;
            }
            catch (Exception)
            {
                throw new URLException("Url saknar RSS!");
            }
        }

        public static bool UrlExsists(string url)
        {
            try
            {
                ArtikelController artikelController = new ArtikelController();
                List<Artikel> artiklar = artikelController.GetAllArtiklar();
                bool isDuplicate = artiklar.Exists(artikel => artikel.URL == url);

                if (isDuplicate)
                {
                    MessageBox.Show("Denna artikeln finns redan i listan!");
                }
                return isDuplicate;
            }
            catch (Exception)
            {
                throw new URLException("Artikelen finns redan!");
            }
        }

        public static bool IsFieldNullOrEmpty(string emptyField)
        {
            bool isNullOrEmptyOrWhiteSpace = String.IsNullOrEmpty(emptyField) || String.IsNullOrWhiteSpace(emptyField);
            if (isNullOrEmptyOrWhiteSpace)
            {
                MessageBox.Show("Alla fält måste vara ifyllda!");
            }
            return isNullOrEmptyOrWhiteSpace;
        }

        public static bool IsKategoriDuplicate(string nyttInnehall)
        {
            KategoriController kategoriController = new KategoriController();
            List<Kategori> kategorier = kategoriController.GetAllKategorier();
            bool isDuplicate = kategorier.Exists(kategori => kategori.Titel == nyttInnehall);

            if (isDuplicate)
            {
                MessageBox.Show("Kategorin " + nyttInnehall + " finns redan!");
            }
            return isDuplicate;
        }

        public static bool IsArtikelDuplicate(string nyttInnehall)
        {
            ArtikelController artikelController = new ArtikelController();
            List<Artikel> artiklar = artikelController.GetAllArtiklar();
            bool isDuplicate = artiklar.Exists(artikel => artikel.Titel == nyttInnehall);

            if (isDuplicate)
            {
                MessageBox.Show("Artikelen " + nyttInnehall + " finns redan!");
            }
            return isDuplicate;
        }
    }
}
