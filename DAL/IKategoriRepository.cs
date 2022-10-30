using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace DAL
{
    public interface IKategoriRepository<T> : IRepository<T> where T : Kategori
    {
        void Rename(int index, string newTitle);
        List<Artikel> Filter(List<string> lista);
    }
}
