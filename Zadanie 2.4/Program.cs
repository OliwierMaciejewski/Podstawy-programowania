﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_2._4
{
    internal class Program
    {
        /*
         Napisać program wczytujący pięć liczb i wypisujący na ekranie wartość najmniejszej
        największej z tych liczb
        */
        static void Main(string[] args)
        {
            double a, b, c, d, e, min, max;
            Console.Write(" Podaj liczbe nr 1: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write(" Podaj liczbe nr 2: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write(" Podaj liczbe nr 3: ");
            c = Convert.ToDouble(Console.ReadLine());
            Console.Write(" Podaj liczbe nr 4: ");
            d = Convert.ToDouble(Console.ReadLine());
            Console.Write(" Podaj liczbe nr 5: ");
            e = Convert.ToDouble(Console.ReadLine());
            //szukamy liczby najmniejszej
            min = a;
            if (b < min) min = b;
            if (c < min) min = c;
            if (d < min) min = d;
            if (e < min) min = e;
            Console.WriteLine("Liczba {0} jest najmniejsza.", min);
            //szukamy liczby najwiekszej
            max = a;
            if (b > max) max = b;
            if (c > max) max = c;
            if (d > max) max = d;
            if (e > max) max = e;
            Console.WriteLine("Liczba {0} jest najwieksza.", max);
            Console.ReadKey(true); //pauza
        }
    }
}
