﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_4._4
{
    class Program
    {
        /*
        Wczytaj dwie liczby naturalne dodatnie n i k. Narysuj z gwiazdek na ekranie prostokąt
posiadający n wierszy i k kolumn. Użyj pętli while. Dla n=3 i k=5 mamy:
*****
*****
*****
*/
        static void Main(string[] args)
        {
            int n, k, i, j;
            Console.Write("Podaj n = ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Podaj k = ");
            k = Convert.ToInt32(Console.ReadLine());
            i = 1;
            while ( i <= n) // liczba wierszy
            {
                j = 1;
                while ( j <= k) // liczba gwizadek
                {
                    Console.Write("*");
                    j++;
                } // while j
                Console.WriteLine(""); // nowa linia
                i++;
            } //while i
            Console.ReadKey(true); //pauza
        }
    }
}
