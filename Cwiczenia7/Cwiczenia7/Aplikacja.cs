using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cwiczenia7
{
    class Aplikacja
    {
        public string klawisz;

        public void WczytajKlawisz()
        {
            Console.WriteLine("Dzień dobry!\nCo chcesz zrobić? Naciśnij odpowiedni klawisz.\n");
            Console.WriteLine("Legenda:\nP - dodaj produkt do koszyka\nK - skopiuj ostatnio wprowadzony produkt\nZ - pokaz zawartosc koszyka\nS - pokaz sume do zaplaty\nX - skasuj produkt z listy (musisz znac wczesniej dumer na liscie)\nW - wydrukuj paragon\nN - dodaj nowy koszyk\nE - zakończ działanie programu\n");
            klawisz = Console.ReadLine();
        }
        public void WykonajDzialanie()
        {
            switch (this.klawisz)
            {
                case "p":
                case "P":
                    Produkt pod = new Prod

                    Console.WriteLine("LOL p");
                    break;
                case "k":
                case "K":
                    Console.WriteLine("LOL k");
                    break;
                case "z":
                case "Z":
                    Console.WriteLine("LOL z");
                    break;
                case "s":
                case "S":
                    Console.WriteLine("LOL s");
                    break;
                case "x":
                case "X":
                    Console.WriteLine("LOL x");
                    break;
                case "w":
                case "W":
                    Console.WriteLine("LOL w");
                    break;
                case "n":
                case "N":
                    Console.WriteLine("LOL n");
                    break;
                case "e":
                case "E":
                    Console.WriteLine("LOL e");
                    break;
            }
                
        }

    }
}
