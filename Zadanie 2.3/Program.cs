﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_2._3
{
    /*
     Napisać program wczytujący trzy liczby i wypisujący na ekranie wartość najmniejszej i
     największej z tych liczb.
    */
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            Console.Write("Podaj liczbe nr 1: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Podaj liczbe nr 2: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Podaj liczbe nr 3: ");
            c = Convert.ToDouble(Console.ReadLine());
            // szukamy liczby najmniejszej
            if ((a <= b) && (a <= c))
                Console.WriteLine(" Liczba {0} jest najmniejsza.", a);
            else if ((b <= a) && (b <= c))
                Console.WriteLine(" Liczba {0} jest najmniejsza.", b);
            else
                Console.WriteLine(" Liczba {0} jest najmniejsza.", c);

            // szukamy liczby najwiekszej
            if ((a >= b) && (a >= c))
                Console.WriteLine("Liczba {0} jest najwieksza.", a);
            else if ((b >= a) && (b >= c))
                Console.WriteLine("Liczba {0} jest najwieksza.", b);
            else
                Console.WriteLine("Liczba {0} jest najwieksza.", c);
            Console.ReadKey(true); //pauza
        }
    }
}
