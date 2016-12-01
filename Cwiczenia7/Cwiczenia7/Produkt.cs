using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cwiczenia7
{
    class Produkt : ICloneable //interfejs do klonowania
    {
        private string nazwa; //hermetyzacja
        private double cenaJednostkowa; //hermetyzacjaa
        private double ilosc; // ilosc nie zawsze bedzie calkowita, np. przy wadze, hermetyzacja

        public Produkt() { }
        public Produkt(string nazwa, double cenaJ, double ilosc) 
        {
            this.nazwa = nazwa;
            this.cenaJednostkowa = cenaJ;
            this.ilosc = ilosc;
        }

        public object Clone()
        {
            return MemberwiseClone();
        }

        public string PodajOpis()
        {
            string opis = "Nazwa: " + nazwa + ", Cena jednostkowa: " + cenaJednostkowa + ", Ilość :" + ilosc + ", Łączna cena: " + PodajSume();
            return opis;
        }

        public void WypiszInfo()
        {
            Console.WriteLine(PodajOpis());
        }

        public double PodajSume()
        {
            return cenaJednostkowa * ilosc;
        }
    }
}
