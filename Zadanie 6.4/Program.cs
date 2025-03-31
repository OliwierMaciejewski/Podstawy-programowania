﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_6._4
{
    internal class Program
    {
        /*
        Napisać program wczytujący ciąg n (1<=n<=1000) liczb całkowitych i wypisujący na ekranie
        sumę wczytanych liczb.
        */
        static void Main(string[] args)
        {
            int[] tab = new int[1000]; // Tablica 1000 liczb typu int
            int i; // i - licznik pętli
            int n, suma; // n - ilość elementów tablicy, suma - suma elementów tablicy

            // Wczytuję n
            Console.Write("Podaj ilość elementów tablicy n<=1000: ");
            n = Convert.ToInt32(Console.ReadLine());

            // Wczytuję n elementów do tablicy
            for (i = 0; i < n; i++)
            {
                Console.Write("Podaj tab[{0}]=", i);
                tab[i] = Convert.ToInt32(Console.ReadLine());
            }

            // Obliczamy sumę wczytanych elementów
            suma = 0;
            for (i = 0; i < n; i++)
            {
                suma += tab[i];
            }

            // Wypisujemy wynik
            Console.WriteLine("Suma elementów tablicy wynosi {0}.", suma);
            Console.ReadKey(true); // Pauza
        }
    }
}
