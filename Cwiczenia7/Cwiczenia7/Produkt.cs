using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cwiczenia7
{
    class Produkt
    {
        public string nazwa;
        public double cenaJednostkowa;
        public int ilosc;

        public Produkt() { }
        public Produkt(string nazwa, double cenaJ, int ilosc) 
        {
            this.nazwa = nazwa;
            this.cenaJednostkowa = cenaJ;
            this.ilosc = ilosc;
        }
    }
}
