using System;

namespace zadaniacs
{
    class Program
    {
        static void Main(string[] args)
        {
            //1

            Console.Write("podaj liczbe od 0 do 9: ");
            int liczba = int.Parse(Console.ReadLine());

            switch (liczba)
            {
                case 0:
                    Console.WriteLine("Wybrałeś 0");
                    break;

                case 1:
                    Console.WriteLine("Wybrałeś 1");
                    break;

                case 2:
                    Console.WriteLine("Wybrałeś 2");
                    break;

                case 3:
                    Console.WriteLine("Wybrałeś 3");
                    break;

                case 4:
                    Console.WriteLine("Wybrałeś 4");
                    break;

                case 5:
                    Console.WriteLine("Wybrałeś 5");
                    break;

                case 6:
                    Console.WriteLine("Wybrałeś 6");
                    break;

                case 7:
                    Console.WriteLine("Wybrałeś 7");
                    break;

                case 8:
                    Console.WriteLine("Wybrałeś 8");
                    break;

                case 9:
                    Console.WriteLine("Wybrałeś 9");
                    break;

                default:
                    Console.WriteLine("Liczba spoza zakresu 0–9");
                    break;

            }

            Console.Write("\n\n\n");
            //9.2

            bool zmienna;

            int dzielnik, dzielna;
            Console.WriteLine("Podaj dzienik: ");
            dzielnik = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj dzielna: ");
            dzielna = int.Parse(Console.ReadLine());

            if (dzielnik%dzielna==0)
            {
                zmienna = true;
            }
            else
            {
                zmienna = false;
            }

            Console.WriteLine($"Czy dzieli sie bez reszty (true-tak false-nie) Wynik: {zmienna}");

            Console.WriteLine("\n\n\n");

            //9.3

            int zmiena;

            Console.WriteLine("Podaj liczbe do obliczneia bezwzglednej wartosci: ");
            zmiena = int.Parse(Console.ReadLine());

            int bzwz;
            bzwz = zmiena < 0 ? (zmiena * -1) : zmiena;

            Console.WriteLine($"Wartosc bezwzgledna z liczby to: {bzwz}\n\n\n");

            //9.4

            int liczba1;
            Console.WriteLine("Podaj liczbe do oblicznia: ");
            liczba1 = int.Parse(Console.ReadLine());
            int liczba2=0;
            if (liczba1>0)
            {
                liczba2 = 1;
            }
            if (liczba1 < 0)
            {
                liczba2 = -1;
            }

            Console.WriteLine($"Wynik: {liczba2}\n\n\n");

            //9.5

            Console.Write("podaj liczbe : ");
            int liczba3 = int.Parse(Console.ReadLine());

            switch (liczba3)
            {
                case 1 or 4 or 8:
                    Console.WriteLine("Wybrałeś 1, 4 lub 8");
                    break;

                case 2 or 3 or 7:
                    Console.WriteLine("Wybrałeś 2, 3 lub 7");
                    break;

                default:
                    Console.WriteLine("Liczba inną niż 1 4 8 lub 2 3 7");
                    break;

            }
        }
    }
}
