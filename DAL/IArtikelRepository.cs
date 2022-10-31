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
        Artikel GetTitel(string titel);
        void Update(int index, Artikel nyArtikel);
        void Save(List<Artikel> artiklar);
        void DeleteOfKategori(string kategori);
        void RenameKategoriOfArtikel(string kategori, string nyKategori);
    }
}
