using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface IRepository<T> where T : class
    {
        void Create(T entitet);
        void Save();
        void Delete(int index);
        int GetIndex(string titel);
        List<T> GetAll();
    }
}
