using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cwiczenia7
{
    class Program
    {
        static void Main(string[] args)
        {
            Aplikacja App = new Aplikacja();

            App.WczytajKlawisz();
            App.WykonajDzialanie();

            Console.WriteLine("Do widzenia!");

            Console.ReadKey();
        }
    }
}
