using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Artikel : Entitet
    {
        public string Titel { get; set; }
        public string URL { get; set; }
        public string Kategori { get; set; }
        public List<Avsnitt> AllaAvsnitt { get; set; }



        public Artikel(string titel, string url, string kategori, List<Avsnitt> avsnitt)
        {
            Titel = titel;
            URL = url;
            Kategori = kategori;
            AllaAvsnitt = avsnitt;
        }

        public Artikel()
        {

        }

        public override string EntitetTyp()
        {
            return "Artikel";
        }
    }
}
