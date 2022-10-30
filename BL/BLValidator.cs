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
                    MessageBox.Show("Se till att URL är korrekt ifylld!");
                }
                return isUrlValid;
            }
            catch (Exception)
            {
                throw new URLException("Ogiltig url!");
            }
        }

        public static bool UrlContainsRSS(string url)
        {
            try
            {
                bool isUrlValid = url.Contains("rss") || url.Contains("feed");
                if (!isUrlValid)
                {
                    MessageBox.Show("Denna url innehåller ingen RSS, avsnitt går inte att hämta!");
                }
                return isUrlValid;
            }
            catch (Exception)
            {
                throw new URLException("Url innehöll ingen RSS!");
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
                    MessageBox.Show("Artikelen med denna url finns redan i din lista!");
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
                MessageBox.Show("Kontrollera att du fyllt i alla fält!");
            }
            return isNullOrEmptyOrWhiteSpace;
        }

        public static bool IsKategoriDuplicate(string newContent)
        {
            KategoriController kategoriController = new KategoriController();
            List<Kategori> kategorier = kategoriController.GetAllKategorier();
            bool isDuplicate = kategorier.Exists(kategori => kategori.Titel == newContent);

            if (isDuplicate)
            {
                MessageBox.Show("Kategorin " + newContent + " finns redan!");
            }
            return isDuplicate;
        }

        public static bool IsArtikelDuplicate(string newContent)
        {
            ArtikelController artikelController = new ArtikelController();
            List<Artikel> artiklar = artikelController.GetAllArtiklar();
            bool isDuplicate = artiklar.Exists(artikel => artikel.Titel == newContent);

            if (isDuplicate)
            {
                MessageBox.Show("Artikelen " + newContent + " finns redan!");
            }
            return isDuplicate;
        }
    }
}
