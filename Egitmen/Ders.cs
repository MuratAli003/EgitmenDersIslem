using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Egitmen
{
    internal class Ders
    {
        Egitmen egitmen = new Egitmen();
        public int ID { get; set; }
        public string DersAdı { get; set; }

        public int EgitmenID { get { return egitmen.ID; } set {egitmen.ID = value;} }

    }
}
