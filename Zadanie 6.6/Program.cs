using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_6._6
{
    internal class Program
    {
        /*
        Zadeklaruj tablicę zawierającą nazwy dni tygodnia. Wypisz elementy tablicy za pomocą pętli
        foreach.
        */
        static void Main(string[] args)
        {
            string[] dni = new string[] { "Poniedziałek", "Wtorek", "Środa", "Czwartek", "Piątek", "Sobota", "Niedziela" };

            //wypisujemy elementy tablicy
            foreach (string elem in dni)
                Console.Write("{0}, ", elem);

            Console.ReadKey(true); //pauza
        }
    }
}
