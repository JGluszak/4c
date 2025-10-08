using System;
using System.Security;
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

            string katalog = args[0];
            DirectoryInfo di;

            try
            {
                di = new DirectoryInfo(katalog);
            }
            catch (ArgumentException)
            {
                Console.WriteLine($"Nazwa {katalog} zawiera nieprawidłowe znaki.");
                return;
            }

            try
            {
                if (!di.Exists)
                {
                    //tworzy katalog
                    di.Create();
                    Console.WriteLine($"Katalog {katalog} został utworzony.");
                }
                else
                {
                    Console.WriteLine($"Katalog {katalog} już istnieje.");
                }
                //usuwa katalog
                di.Delete(true); 
                Console.WriteLine($"Katalog {katalog} został usunięty.");
            }
            catch (IOException)
            {
                Console.WriteLine($"Katalog {katalog} nie może być utworzony lub usunięty.");
            }
            catch (SecurityException)
            {
                Console.WriteLine($"Brak uprawnień do usunięcia katalogu {katalog}.");
            }
        }
    }
}
