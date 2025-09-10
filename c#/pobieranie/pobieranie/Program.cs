using System;

namespace pobieranie
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wprowadzaj linie tekstu. Wpisz 'quit' , aby zakończyć. ");
            String line;
            do
            {
                line = Console.ReadLine();
                Console.WriteLine($"Wprowadzona l inia to: {line} ");
            } while (line != "quit");
            Console.WriteLine("\n\n\n\n");






            Console.Write("Wprowadź liczbę całkowitą: ");
            String line2 = Console.ReadLine();
            int liczba;
            try
            {
                liczba = Int32.Parse(line2);
            }
            catch (Exception)
            {
                Console.Write("Wprowadzona wartość nie jest prawidłowa. ");
                return;
            }
            Console.Write($" {liczba} * 2 = {liczba * 2}\n");
            Console.ReadKey();
        }
    }
}
