using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Avsnitt : Entitet
    {
        public string Titel { get; set; }
        public string Beskrivning { get; set; }


        public Avsnitt()
        {

        }

        public override string EntitetTyp()
        {
            return "Avsnitt";
        }
    }
}
