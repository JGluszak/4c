using System;
using System.IO;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            if (args.Length < 1)
            {
                Console.WriteLine("Wywołanie programu: Program katalog");
                return;
            }
            String katalog = args[0];
            DirectoryInfo di;
            try {
                di = new DirectoryInfo(katalog);
            }
            catch (ArgumentException)
            {
                Console.WriteLine($"Nazwa {katalog} zawiera nieprawidłowe znaki . ");
                return;
            }
            if (di.Exists)
            {
                Console.WriteLine($"Katalog {katalog} już istnieje");
                return;
            }
            try
            {
                di.Create();

            }
            catch (IOException)
            {
                Console.WriteLine($"Katalog katalog nie może być utworzony. ");
                return;
            }
            Console.WriteLine($"Katalog {katalog} został utworzony. ");
        }
    }
}
