using System;

namespace przechwytywaniewyjatku
{
    class Program
    {
        static void Main(string[] args)
        {
            /*try
            {
                int liczba1 = 10, liczba2 = 0;
                liczba1 = liczba1 / liczba2;
            }
            catch (SystemException e)
            {
                Console.WriteLine("Wystąpił wyjątek systemowy ... ");
                Console.Write("Komunikat systemowy: ");
                Console.WriteLine(e.ToString());

            }*/
            Console.Write("\n\n\n\n");


            int liczba1 = 10, liczba2 = 0;
            try
            {
                try
                {
                    liczba1 = liczba1 / liczba2;
                }
                catch (ArithmeticException)
                {
                    Console.WriteLine("Nieprawidłowa operacja arytmetyczna");
                    Console.WriteLine("Przypisuję zmiennej l iczbal wartość 10. ");
                    liczba1 = 10;
                }
            }
            catch (Exception e)
            {
                Console.Write("Błąd ogólny: ");
                Console.WriteLine(e.Message);
            }
        }
    }
}

