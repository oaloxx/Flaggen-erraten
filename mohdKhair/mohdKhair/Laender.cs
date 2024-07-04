using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mohdKhair
{
    public class Laender
    {
        private int NR;
        private string name;
        private string Hauptstadt;
        private int KoNr;

        public int NR1 { get => NR; set => NR = value; }
        public string Name { get => name; set => name = value; }
        public string Hauptstadt1 { get => Hauptstadt; set => Hauptstadt = value; }
        public int KoNr1 { get => KoNr; set => KoNr = value; }

        public Laender(int nR1, string name, string hauptstadt1, int koNr1)
        {
            NR1 = nR1;
            Name = name;
            Hauptstadt1 = hauptstadt1;
            KoNr1 = koNr1;
        }
    }
}
