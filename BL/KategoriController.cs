using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Models;

namespace BL
{
    public class KategoriController
    {
        private IKategoriRepository<Kategori> kategoriRepository;
        ArtikelRepository artikelRepository = new ArtikelRepository();

        public KategoriController()
        {
            kategoriRepository = new KategoriRepository();
        }

        public void CreateKategoriObject(string titel)
        {
            Kategori kategori = new Kategori(titel);
            kategoriRepository.Create(kategori);
        }

        public void RenameKategori(string titel, string nyTitel)
        {
            int index = kategoriRepository.GetIndex(titel);
            kategoriRepository.Rename(index, nyTitel);
            artikelRepository.RenameKategoriOfArtikel(titel, nyTitel);
        }

        public void DeleteKategori(string titel)
        {
            int index = kategoriRepository.GetIndex(titel);
            kategoriRepository.Delete(index);
            artikelRepository.DeleteOfKategori(titel);
        }

        public List<Artikel> FilterArtiklar(List<string> kategorier)
        {
            List<Artikel> filteredArtikel = kategoriRepository.Filter(kategorier);
            return filteredArtikel;
        }

        public List<Kategori> GetAllKategorier()
        {
            return kategoriRepository.GetAll();
        }
    }
}
