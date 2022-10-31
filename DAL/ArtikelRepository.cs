using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace DAL
{
    public class ArtikelRepository : IArtikelRepository<Artikel>
    {
        FileManager fileManager;
        List<Artikel> artikelList;

        public ArtikelRepository()
        {
            artikelList = new List<Artikel>();
            fileManager = new FileManager();
            artikelList = GetAll();
        }

        public void Save()
        {
            fileManager.SerializeArtikel(artikelList);
        }

        public void Create(Artikel artikel)
        {
            artikelList.Add(artikel);
            Save();
        }

        public void Delete(int index)
        {
            artikelList.RemoveAt(index);
            Save();
        }

        public void Update(int index, Artikel nyArtikel)
        {
            if (index >= 0)
            {
                artikelList[index] = nyArtikel;
            }
            Save();
        }

        public void Save(List<Artikel> artikel)
        {
            fileManager.SerializeArtikel(artikel);
        }

        public void DeleteOfKategori(string kategori)
        {
            artikelList.RemoveAll(artikel => artikel.Kategori == kategori);
            Save();
        }

        public void RenameKategoriOfArtikel(string kategori, string nyKategori)
        {
            artikelList.Where(artikel => artikel.Kategori == kategori).ToList().ForEach(artikel => artikel.Kategori = nyKategori);
            Save();
        }

        public int GetIndex(string titel)
        {
            return GetAll().FindIndex(a => a.Titel.Equals(titel));
        }

        public Artikel GetTitel(string titel)
        {
            return GetAll().First(a => a.Titel.Equals(titel));
        }

        public List<Artikel> GetAll()
        {
            List<Artikel> artiklar = new List<Artikel>();
            try
            {
                artiklar = fileManager.DeserializeArtikel();
            }
            catch (SerializerException e)
            {
                Console.WriteLine(e.Message);
            }
            return artiklar;
        }
    }
}
