using System;
using System.IO;

namespace tworzenieplikow
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length < 1)
            {
                Console.WriteLine("Wywolanie programu: program plik");
                return;
            }
            String plik = args[0];
            FileInfo fi;
            try
            {
                fi = new FileInfo(plik);
            }
            catch (ArgumentException)
            {
                Console.WriteLine($"Nazwa {plik} zawiera nieprawidlowe znaki");
                return;
            }
            if (fi.Exists)
            {
                Console.WriteLine($"Plik {plik} nie moze byc utworzony2");
                return;
            }

            FileStream fs;
            try
            {
                fs = fi.Create();
            }
            catch (Exception)
            {
                Console.WriteLine($"Plik {plik} nie moze byc utworzony1");
                return;
            }
            if (!fi.Exists)
            {
                Console.WriteLine($"Plik {plik} nie istnieje. ");
                return;
            }

            Console.WriteLine($"Dane o pliku {plik} : " );
            Console.WriteLine($"Atrybuty: {fi.Attributes}" );
            Console.WriteLine($"Katalog: {fi.Directory} " );
            Console.WriteLine($"Rozszerzenie: {fi.Extension}" );
            Console.WriteLine($"Ścieżka: {fi.FullName} " );
            Console.WriteLine($"Długość: {fi.Length}" );
            Console.WriteLine($"Data utworzenia: {fi.CreationTime}" );
            Console.WriteLine($"Data ostatniej modyfi kacji : {fi.LastWriteTime}" );
            Console.WriteLine($"Data ostatniego dostępu: {fi.LastAccessTime} ");
            /* 
                tutaj można wykonać operacje na pliku 
            */
            fs.Close();
            Console.WriteLine($"Plik {plik} zostal utworzony");
            
        }
    }
}
