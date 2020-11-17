using System;
using System.Collections.Generic;
using System.Text;

namespace Domaća_Zadaća_br._2
{
    class Description
    {
        public int Number;
        public TimeSpan Length;
        public string naziv; 
        public Description(int a, TimeSpan time, string ime) { this.Number = a; this.Length = time; this.naziv = ime;   }
    }
}
