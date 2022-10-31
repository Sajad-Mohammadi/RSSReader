using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using DAL;

namespace BL
{
    public class ArtikelController
    {
        private IArtikelRepository<Artikel> artikelRepository;
        private AvsnittRepository avsnittRepository;

        public ArtikelController()
        {
            artikelRepository = new ArtikelRepository();
            avsnittRepository = new AvsnittRepository();
        }
        public async void CreateArtikelObject(string titel, string url, string kategori)
        {
            List<Avsnitt> allaAvsnitt = await avsnittRepository.GetAllaAvsnittFromRSS(url);
            Artikel artikel = new Artikel(titel, url, kategori, allaAvsnitt);
            artikelRepository.Create(artikel);
        }

        public List<Artikel> GetAllArtiklar()
        {
            return artikelRepository.GetAll();
        }

        public int GetIndexByTitel(string titel)
        {
            int index = artikelRepository.GetIndex(titel);
            return index;
        }

        public string GetUrlByTitel(string titel)
        {
            Artikel artikel = artikelRepository.GetTitel(titel);
            string url = artikel.URL;
            return url;
        }

        public async void UpdateArtikelObject(string titel, string url, string kategori, int index)
        {
            List<Avsnitt> allaAvsnitt = await avsnittRepository.GetAllaAvsnittFromRSS(url);
            Artikel artikel = new Artikel(titel, url, kategori, allaAvsnitt);
            artikelRepository.Update(index, artikel);
        }

        public void DeleteArtikel(string titel)
        {
            int index = artikelRepository.GetIndex(titel);
            artikelRepository.Delete(index);
        }
    }
}
