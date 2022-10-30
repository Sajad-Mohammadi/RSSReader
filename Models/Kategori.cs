using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Kategori : Entitet
    {
        public string Titel { get; set; }


        public Kategori(string titel)
        {
            Titel = titel;
        }

        public Kategori()
        {

        }

        public override string EntitetTyp()
        {
            return "Kategori";
        }
    }
}
