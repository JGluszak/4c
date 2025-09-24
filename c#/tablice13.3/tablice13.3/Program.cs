using System;

namespace tablice13._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] tab = new int[4][];
            tab[0] = new int[1];
            tab[1] = new int[2];
            tab[2] = new int[3];
            tab[3] = new int[4];

            int licznik = 10;

            for (int i = 0; i < tab.Length; i++)
            {
                for (int j = 0; j < tab[i].Length; j++)
                {
                    tab[i][j] = licznik--;
                }
            }
            for (int i = 0; i < tab.Length; i++)
            {
                Console.Write($"tab[{i}] = ");
                for (int j = 0; j < tab[i].Length; j++)
                {
                    Console.Write($" {tab[i][j]} ");
                }
                Console.WriteLine("");
            }
        }
    }
}
