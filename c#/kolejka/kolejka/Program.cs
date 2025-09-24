using System;
using System.Collections.Generic;

namespace kolejka
{
    class Program
    {
        static void Main(string[] args)
        {
            var kolejka = new Queue<string>();
            kolejka.Enqueue("Kamil Slimak");
            kolejka.Enqueue("Mariusz Kwasnik");

            foreach (var osoba in kolejka)
            {
                Console.WriteLine($"Osoba: {osoba}");
            }
        }
    }
}
