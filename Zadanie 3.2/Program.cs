﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_3._2
{
    internal class Program
    {
        /*
        Napisać program wczytujący wartość liczby naturalnej n (n>=0), obliczający wartość 2^n (2 do
        potęgi n) i wypisujący wynik na ekranie w formacie (np. dla n=10) : 2^10=1024. Do obliczenia
        wartości wyrażenia użyj pętli for
        */
        static void Main(string[] args)
        {
            int i, wynik = 1, n;
            Console.Write("Podaj liczbe naturalna n = ");
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= n; i++)
                wynik *= 2;
            Console.WriteLine("2^{0}={1}", n, wynik);
            Console.ReadKey(true); //pauza
        }
    }
}
