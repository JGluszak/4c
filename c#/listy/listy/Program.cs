using System;
using System.Collections.Generic;

namespace listy
{
    class Program
    {
        static void Main(string[] args)
        {
            //lista to tablica ale ze zmienna długoscia
            var listaosob = new List<string>();
            listaosob.Add("Jan Nowak");
            listaosob.Add("Monika Nowak");
            Console.WriteLine($"Na liście jest {listaosob.Count}osob");

            foreach (var osoba in listaosob)
            {
                Console.WriteLine($"Osoba: {osoba}");
            }

        }
    }
}
