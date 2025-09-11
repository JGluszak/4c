using System;

namespace operator_warunkowy
{
    class Program
    {
        static void Main(string[] args)
        {

            int liczba = 10;
            int liczba2;
            liczba2 = liczba < 0 ? -1 : 1;
            Console.WriteLine(liczba2);
        }
    }
}
