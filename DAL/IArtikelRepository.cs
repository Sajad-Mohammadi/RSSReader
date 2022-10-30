using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace DAL
{
    public interface IArtikelRepository<T> : IRepository<T> where T : Artikel
    {
        void Update(int index, Artikel nyArtikel);
        Artikel GetTitel(string titel);
        void Save(List<Artikel> artiklar);
        void DeleteOfKategori(string kategori);
        void RenameKategoriOfArtikel(string kategori, string nyKategori);
    }
}
