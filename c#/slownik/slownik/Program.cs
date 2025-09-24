using System;
using System.Collections.Generic;

namespace slownik
{
    class Program
    {
        static void Main(string[] args)
        {
            //tablica asocjacyja czyli ma klucz wartosc
            var slownik = new Dictionary<string, string>();
            slownik.Add("Anna", "Anna Nowak - tester");
            slownik.Add("Pawel", "Pawel Nowak - tester");

            Console.WriteLine($"Pozycje słownika dla kluczy anna to {slownik["Anna"]}");

        }
    }
}
