using System;
using System.Collections.Generic;

namespace stos
{
    class Program
    {
        static void Main(string[] args)
        {
            var stos = new Stack<string>();
            stos.Push("Faktura 1");
            stos.Push("Faktura 2");
            stos.Push("dokumnt");

            foreach (var dokument in stos)
            {
                Console.WriteLine($"Dokument: {dokument}");
            }

            var zdjetydokument = stos.Pop();
            Console.WriteLine($"Zjety dokument: {zdjetydokument}");

            foreach (var dokument in stos)
            {
                Console.WriteLine($"Dokument: {dokument}");
            }
        }
    }
}
