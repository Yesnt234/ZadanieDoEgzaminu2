using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadanieDoEgzaminu2
{
    internal class Strona
    {
        public string trescStrony;
        public uint numerStrony;
        public uint licznikStron;

        public Strona (string trescStrony, uint numerStrony)
        {
            this.trescStrony = trescStrony;
            this.numerStrony = numerStrony;
            licznikStron = numerStrony + 1;
        }

        public Strona(string trescStrony)
        {
            this.trescStrony = trescStrony;
            this.numerStrony = licznikStron++;
        }
    }
}
