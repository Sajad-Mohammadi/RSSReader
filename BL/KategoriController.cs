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

        public void DeleteKategori(string titel) //Raderar kategori med tillhörande podcasts
        {
            int index = kategoriRepository.GetIndex(titel);
            kategoriRepository.Delete(index);
            artikelRepository.DeleteOfKategori(titel);
        }

        public List<Kategori> GetAllKategorier()
        {
            return kategoriRepository.GetAll();
        }

        public void RenameKategori(string titel, string nyTitel)
        {
            int index = kategoriRepository.GetIndex(titel);
            kategoriRepository.Rename(index, nyTitel);
            artikelRepository.RenameKategoriOfArtikel(titel, nyTitel); //Anrop för att uppdatera kategori på podcasts
        }

        /*Tar en lista av strings dvs de valda kategoriernas titlar som parameter som skickas med som parameter
          till Filter metoden i categoryRepository. Metoden returnerar en lista med de podcasts som man filtrerat utifrån.*/
        public List<Artikel> FilterArtiklar(List<string> kategorier)
        {
            List<Artikel> filteredArtikel = kategoriRepository.Filter(kategorier);
            return filteredArtikel;
        }
    }
}
