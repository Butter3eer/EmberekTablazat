using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmberekTablazat
{
    class Ember
    {
        private string nev;
        private int kor;

        public Ember(string nev, int kor)
        {
            this.nev = nev;
            this.kor = kor;
        }

        public string Nev { get => nev; set => nev = value; }
        public int Kor { get => kor; set => kor = value; }
    }
}
