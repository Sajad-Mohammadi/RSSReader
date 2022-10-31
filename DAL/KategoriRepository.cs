using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace DAL
{
    public class KategoriRepository : IKategoriRepository<Kategori>
    {
        FileManager fileManager;
        List<Kategori> kategoriList;

        public KategoriRepository()
        {
            kategoriList = new List<Kategori>();
            fileManager = new FileManager();
            kategoriList = GetAll();
        }

        public int GetIndex(string titel)
        {
            return GetAll().FindIndex(e => e.Titel.Equals(titel));
        }

        public void Create(Kategori kategori)
        {
            kategoriList.Add(kategori);
            Save();
        }

        public void Delete(int index)
        {
            kategoriList.RemoveAt(index);
            Save();
        }

        public List<Kategori> GetAll()
        {
            List<Kategori> kategoriList = new List<Kategori>();
            try
            {
                kategoriList = fileManager.DeserializeKategori();
            }
            catch (SerializerException e)
            {
                Console.WriteLine(e.Message);
            }
            return kategoriList;
        }

        public void Save()
        {
            fileManager.SerializeKategori(kategoriList);
        }

        public void Rename(int index, string nyTitel)
        {
            Kategori kategori = kategoriList.ElementAt(index);
            kategori.Titel = nyTitel;
            Save();
        }

        public List<Artikel> Filter(List<string> kategorierToFilterBy)
        {
            ArtikelRepository artikelRepository = new ArtikelRepository();
            List<Artikel> allArtiklar = artikelRepository.GetAll();
            List<Artikel> filteredArtiklar = new List<Artikel>();
            foreach (string kategori in kategorierToFilterBy)
            {
                filteredArtiklar.AddRange(allArtiklar.Where(x => x.Kategori.Contains(kategori)));
            }
            return filteredArtiklar;
        }
    }
}
